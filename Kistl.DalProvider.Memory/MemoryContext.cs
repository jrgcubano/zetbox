
namespace Kistl.DalProvider.Memory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.API.Utils;
    using Kistl.App.Base;

    public interface IMemoryActionsManager : ICustomActionsManager { }

    public class MemoryContext
        : BaseMemoryContext, IReadOnlyKistlContext
    {
        // private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Kistl.DalProvider.Memory");

        // private static readonly List<IPersistenceObject> emptylist = new List<IPersistenceObject>(0);
        private readonly Func<IFrozenContext> _lazyCtx;
        private readonly MemoryImplementationType.MemoryFactory _implTypeFactory;

        public MemoryContext(InterfaceType.Factory iftFactory, Func<IFrozenContext> lazyCtx, MemoryImplementationType.MemoryFactory implTypeFactory)
            : base(iftFactory)
        {
            _lazyCtx = lazyCtx;
            _implTypeFactory = implTypeFactory;
        }

        public override int SubmitChanges()
        {
            int count = 0;
            var removals = new List<IPersistenceObject>();
            foreach (var o in objects)
            {
                switch (o.ObjectState)
                {
                    case DataObjectState.New:
                    case DataObjectState.Modified:
                        ((BaseMemoryPersistenceObject)o).SetUnmodified();
                        count += 1;
                        break;
                    case DataObjectState.Unmodified:
                        break;
                    case DataObjectState.Deleted:
                        removals.Add(o);
                        break;
                    case DataObjectState.NotDeserialized:
                    case DataObjectState.Detached:
                    default:
                        throw new NotSupportedException(string.Format("Unexpected ObjectState encountered: {0}", o.ObjectState));
                }
            }
            foreach (var r in removals)
            {
                objects.Remove(r);
            }
            return count;
        }

        protected override object CreateUnattachedInstance(InterfaceType ifType)
        {
            // TODO: replace with generated switch factory
            return Activator.CreateInstance(this.ToImplementationType(ifType).Type, _lazyCtx);
        }

        public override ImplementationType ToImplementationType(InterfaceType t)
        {
            // TODO: replace with generated switch factory
            return GetImplementationType(Type.GetType(t.Type.FullName + "Memory" + Kistl.API.Helper.ImplementationSuffix + "," + MemoryProvider.GeneratedAssemblyName));
        }

        public override InterfaceType GetInterfaceType(string typeName)
        {
            return IftFactory(Type.GetType(typeName + "," + typeof(Kistl.App.Base.ObjectClass).Assembly.FullName));
        }

        public override ImplementationType GetImplementationType(Type t)
        {
            return _implTypeFactory(t);
        }

        /// <summary>Only implemented for the parent==null case.</summary>
        IList<T> IReadOnlyKistlContext.FetchRelation<T>(Guid relId, RelationEndRole endRole, IDataObject parent)
        {
            if (parent == null)
            {
                return GetPersistenceObjectQuery(IftFactory(typeof(T))).Cast<T>().ToList();
            }
            else
            {
                // TODO: #1571 This method expects IF Types, but Impl types are passed
                switch (endRole)
                {
                    case RelationEndRole.A:
                        return GetPersistenceObjectQuery(GetImplementationType(typeof(T)).ToInterfaceType()).Cast<T>().Where(i => i.AObject == parent).ToList();
                    case RelationEndRole.B:
                        return GetPersistenceObjectQuery(GetImplementationType(typeof(T)).ToInterfaceType()).Cast<T>().Where(i => i.BObject == parent).ToList();
                    default:
                        throw new NotImplementedException(String.Format("Unknown RelationEndRole [{0}]", endRole));
                }
            }
        }
    }
}
