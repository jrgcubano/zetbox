using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.IO;
using System.Reflection;


namespace Kistl.API.Client
{
    internal class KistlContextProvider<T> : IQueryProvider
    {
        private ObjectType _type;
        private KistlContext _context;

        internal KistlContextProvider(KistlContext ctx, ObjectType type)
        {
            _context = ctx;
            _type = type;
        }

        internal List<T> GetListOf(int ID, string propertyName)
        {
            List<T> result = Proxy.Current.GetListOf(_context, _type, ID, propertyName).OfType<T>().ToList();
            //result.ForEach(r => _context.Attach(r as BaseClientDataObject));
            result.ForEach<BaseClientDataObject>(r => CacheController<BaseClientDataObject>.Current.Set(r.Type, r.ID,
                        (BaseClientDataObject)(r).Clone()) );
            return result;
        }

        #region IQueryProvider Members

        public IQueryable<TElement> CreateQuery<TElement>(Expression e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("CreateQuery {0}", e.ToString()));
            return new KistlContextQuery<TElement>(_context, _type, this as KistlContextProvider<TElement>, e) as IQueryable<TElement>;
        }

        public IQueryable CreateQuery(Expression e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("CreateQuery {0}", e.ToString()));
            return new KistlContextQuery<T>(_context, _type, this, e);
        }

        public TResult Execute<TResult>(Expression e)
        {
            return (TResult)(this as IQueryProvider).Execute(e);
        }

        public object Execute(Expression e)
        {
            Visit(e);

            if (SearchType == SearchTypeEnum.GetList)
            {
                List<T> result = Proxy.Current.GetList(_context, _type).OfType<T>().ToList();
                foreach (BaseClientDataObject obj in result.OfType<BaseClientDataObject>())
                {
                    CacheController<BaseClientDataObject>.Current.Set(obj.Type, obj.ID,
                        (BaseClientDataObject)(obj).Clone());
                    //    _context.Attach(obj);
                }
                return result;
            }
            else
            {
                if (ID != API.Helper.INVALIDID)
                {
                    T result = (T)(IDataObject)CacheController<BaseClientDataObject>.Current.Get(_type, ID);
                    if (result == null)
                    {
                        result = (T)(IDataObject)Proxy.Current.GetObject(_context, _type, ID);
                        if (result == null) throw new InvalidOperationException(string.Format("Object ID {0} of Type {1} not found", ID, _type));
                        CacheController<BaseClientDataObject>.Current.Set(_type, ID,
                            (BaseClientDataObject)(result as BaseClientDataObject).Clone());
                    }
                    else
                    {
                        result = (T)(result as BaseClientDataObject).Clone();
                        _context.Attach(result as BaseClientDataObject);
                    }                    
                    return result;
                }    
                else if(SearchType == SearchTypeEnum.GetObjectOrNew)
                {
                    return (T)(IDataObject)_context.Create(_type);
                }
            }

            return null;
        }

        #endregion

        #region Parameter
        
        private List<Expression> _filter = new List<Expression>();
        private int ID = API.Helper.INVALIDID;
        private enum SearchTypeEnum
        {
            GetObject,
            GetObjectOrNew,
            GetList,
        }

        private SearchTypeEnum SearchType = SearchTypeEnum.GetList;

        #endregion
        
        #region Visits
        private void Visit(Expression e)
        {
            // System.Diagnostics.Trace.WriteLine(string.Format("Visiting {0}", e.ToString()));
            switch (e.NodeType)
            {
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                    Visit((e as BinaryExpression).Left);
                    Visit((e as BinaryExpression).Right);
                    break;
                case ExpressionType.Equal:
                    VisitEqual(e as BinaryExpression);
                    break;
                case ExpressionType.LessThan:
                    VisitLessThan(e as BinaryExpression);
                    break;
                case ExpressionType.Call:
                    VisitMethodCall(e as MethodCallExpression);
                    break;
                case ExpressionType.Quote:
                    Visit((e as UnaryExpression).Operand);
                    break;
                case ExpressionType.Lambda:
                    Visit((e as LambdaExpression).Body);
                    break;
                case ExpressionType.Constant:
                    // Do nothing -> This is a "select all" Expression
                    break;
                default:
                    string exmsg = string.Format("Visit: Nodetype {0} is not supported: {1}", e.NodeType, e.ToString());
                    System.Diagnostics.Trace.WriteLine(exmsg);
                    throw new NotSupportedException(exmsg);
            }
        }

        private void VisitEqual(BinaryExpression e)
        {
            MemberExpression m = (MemberExpression)e.Left;
            if (m.Member.DeclaringType == typeof(BaseClientDataObject) && m.Member.Name == "ID")
            {
                ID = GetExpressionValue<int>(e.Right);
            }
            else
            {
                _filter.Add(e);
            }
        }

        private void VisitLessThan(BinaryExpression e)
        {
            _filter.Add(e);
        }

        private TYPE GetExpressionValue<TYPE>(Expression e)
        {
            if (e is ConstantExpression)
            {
                return (TYPE)(e as ConstantExpression).Value;
            }
            else if (e is MemberExpression)
            {
                MemberExpression me = e as MemberExpression;

                if(me.Member is PropertyInfo)
                    return (TYPE)(me.Member as PropertyInfo).GetValue((me.Expression as ConstantExpression).Value, null);
                else if(me.Member is FieldInfo)
                    return (TYPE)(me.Member as FieldInfo).GetValue((me.Expression as ConstantExpression).Value);
                else
                    throw new NotSupportedException(string.Format("Member of MemberExpression is not supported: {0}", e.ToString()));
            }
            else
            {
                throw new NotSupportedException(string.Format("Unable to get Value, Expression is not supported: {0}", e.ToString()));
            }
        }

        private void VisitMethodCall(MethodCallExpression m)
        {
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Where")
            {
                this.Visit(m.Arguments[1]);
            }
            else if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Select")
            {
                // No projection supportet, just finish
            }
            else if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Single")
            {
                SearchType = SearchTypeEnum.GetObject;
                this.Visit(m.Arguments[1]);
            }
            else if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "SingleOrDefault")
            {
                SearchType = SearchTypeEnum.GetObjectOrNew;
                this.Visit(m.Arguments[1]);
            }
            else
            {
                throw new NotSupportedException(string.Format("The method '{0}' is not supported", m.Method.Name));
            }
        }

        #endregion
    }
}
