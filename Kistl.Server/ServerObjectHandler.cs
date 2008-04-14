using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Xml;
using System.Reflection;
using System.ComponentModel;
using System.Data.Metadata.Edm;
using Kistl.API;
using Kistl.API.Server;

namespace Kistl.Server
{
    /// <summary>
    /// Interface für das Server BL Objekt.
    /// </summary>
    internal interface IServerObjectHandler
    {
        /// <summary>
        /// Implementiert den GetList Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        IEnumerable GetList(int maxListCount, Expression filter, Expression orderBy);

        /// <summary>
        /// Implementiert den GetListOf Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="ID"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        IEnumerable GetListOf(int ID, string property);

        /// <summary>
        /// Implementiert den GetObject Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        IDataObject GetObject(int ID);

        /// <summary>
        /// Implementiert den SetObject Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        IDataObject SetObject(IDataObject xml);
    }

    /// <summary>
    /// TODO: Objekte verwaltuen & Serialisierung trennen!!!
    /// </summary>
    internal class ServerObjectHandlerFactory
    {
        /// <summary>
        /// Helper Method for generic object access
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        // [System.Diagnostics.DebuggerStepThrough]
        public static IServerObjectHandler GetServerObjectHandler(ObjectType type)
        {
            using (TraceClient.TraceHelper.TraceMethodCall(type.ToString()))
            {
                if (type == null) throw new ArgumentException("Type is null");
                if (string.IsNullOrEmpty(type.FullNameDataObject)) throw new ArgumentNullException("type", "Type is empty");

                Type objType = Type.GetType(type.FullNameDataObject);
                if (objType == null) throw new ApplicationException("Invalid Type");

                Type t = typeof(ServerObjectHandler<>);
                Type result = t.MakeGenericType(objType);

                IServerObjectHandler obj = Activator.CreateInstance(result) as IServerObjectHandler;
                if (obj == null) throw new ApplicationException("Cannot create instance");

                return obj;
            }
        }
    }

    /// <summary>
    /// Basis Objekt für die generische Server BL. Implementiert Linq
    /// Das ist nur für den generischen Teil gedacht, alle anderen Custom Actions
    /// können mit Linq auf den Context direkt zugreifen, da die Actions am Objekt & am Context
    /// selbst implementiert sind
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class ServerObjectHandler<T> : IServerObjectHandler
        where T : class, IDataObject, new()
    {
        /// <summary>
        /// Events registrieren
        /// </summary>
        public ServerObjectHandler()
        {
        }

        /// <summary>
        /// Implementiert den GetList Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public IEnumerable GetList(int maxListCount, Expression filter, Expression orderBy)
        {
            using (TraceClient.TraceHelper.TraceMethodCall())
            {
                if (maxListCount > Kistl.API.Helper.MAXLISTCOUNT)
                {
                    maxListCount = Kistl.API.Helper.MAXLISTCOUNT;
                }

                var result = from a in KistlDataContext.Current.GetQuery<T>()
                             select a;

                if (filter != null)
                {
                    result = result.AddFilter<T>(filter);
                }

                if (orderBy != null)
                {
                    result = result.AddOrderBy<T>(orderBy);
                }

                return result.Take(maxListCount);
            }
        }

        /// <summary>
        /// Implementiert den GetListOf Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="ID"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public IEnumerable GetListOf(int ID, string property)
        {
            using (TraceClient.TraceHelper.TraceMethodCall(string.Format("ID = {0}, Property = {1}", ID, property)))
            {
                if (ID == API.Helper.INVALIDID) throw new ArgumentException("ID must not be invalid");
                T obj = GetObjectInstance(ID);
                if (obj == null) throw new ArgumentOutOfRangeException("ID", "Object not found");

                IEnumerable list = (IEnumerable)obj.GetPropertyValue <IEnumerable>(property);

                using (IKistlContext ctx = KistlDataContext.GetContext())
                {
                    // If ObjectReferenc is a List -> convert data
                    Kistl.App.Base.BackReferenceProperty prop = (Kistl.App.Base.BackReferenceProperty)obj.Type.GetObjectClass(ctx)
                        .GetProperty(ctx, property);
                    if (prop.ReferenceProperty.IsList)
                    {
                        List<IDataObject> result = new List<IDataObject>();
                        list.ForEach<ICollectionEntry>(ce => result.Add(ce.GetPropertyValue<IDataObject>("Parent")));
                        return result;
                    }
                    else
                    {
                        return list;
                    }
                }
            }
        }

        /// <summary>
        /// Gibt eine typisierte Objektinstanz zurück.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        private static T GetObjectInstance(int ID)
        {
            using (TraceClient.TraceHelper.TraceMethodCall(string.Format("ID = {0}", ID)))
            {
                var result = from a in KistlDataContext.Current.GetQuery<T>()
                             where a.ID == ID
                             select a;
                return result.FirstOrDefault<T>();
            }
        }

        /// <summary>
        /// Implementiert den GetObject Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IDataObject GetObject(int ID)
        {
            return GetObjectInstance(ID);
        }

        /// <summary>
        /// Implementiert den SetObject Befehl.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        public IDataObject SetObject(IDataObject obj)
        {
            using (TraceClient.TraceHelper.TraceMethodCall())
            {
                if (obj.ObjectState == DataObjectState.Deleted)
                {
                    KistlDataContext.Current.Delete(obj);
                }
                else
                {
                    if (obj.ObjectState != DataObjectState.New)
                    {
                        MarkEveryPropertyAsModified(obj as EntityObject);
                    }

                    UpdateRelationships(obj as T);
                }

                KistlDataContext.Current.SubmitChanges();

                return obj;
            }
        }

        /// <summary>
        /// Update Relationships
        /// TODO: Bad hack, weil EF keine Relationen serialisieren kann
        /// Note: Change Tracking is "enabled" by setting every Reference
        /// </summary>
        /// <param name="obj"></param>
        private static void UpdateRelationships(T obj)
        {
            using (IKistlContext ctx = KistlDataContext.GetContext())
            {
                Kistl.App.Base.ObjectClass objClass = obj.Type.GetObjectClass(ctx); 
                while(objClass != null)
                {
                    foreach (Kistl.App.Base.ObjectReferenceProperty p in objClass.Properties.OfType<Kistl.App.Base.ObjectReferenceProperty>())
                    {
                        if (!p.IsList)
                        {
                            int fk = obj.GetPropertyValue<int>("fk_" + p.PropertyName);

                            IServerObjectHandler so = ServerObjectHandlerFactory.GetServerObjectHandler(new ObjectType(p.GetDataType()));
                            IDataObject other = so.GetObject(fk);
                            obj.SetPropertyValue<IDataObject>(p.PropertyName, other);
                        }
                        else
                        {
                            // Liste
                            foreach (ICollectionEntry ce in obj.GetPropertyValue<IEnumerable>(p.PropertyName))
                            {
                                int fk = ce.GetPropertyValue<int>("fk_Value");

                                IServerObjectHandler so = ServerObjectHandlerFactory.GetServerObjectHandler(new ObjectType(p.GetDataType()));
                                IDataObject other = so.GetObject(fk);
                                ce.SetPropertyValue<IDataObject>("Value", other);
                            }
                        }
                    }

                    objClass = objClass.BaseObjectClass;
                }
            }
        }

        /// <summary>
        /// TODO: Bad Hack!
        /// Es gibt angeblich jetzt eine bessere MEthode
        /// </summary>
        /// <param name="obj"></param>
        private static void MarkEveryPropertyAsModified(EntityObject obj)
        {
            // TODO: Bad Hack!!
            ObjectStateEntry stateEntry = ((KistlDataContextEntityFramework)KistlDataContext.Current).ObjectStateManager.GetObjectStateEntry(obj.EntityKey);
            MetadataWorkspace workspace = ((KistlDataContextEntityFramework)KistlDataContext.Current).MetadataWorkspace;
            EntityType entityType = workspace.GetItem<EntityType>("Model." + obj.GetType().Name, DataSpace.CSpace);

            foreach (EdmProperty property in entityType.Properties)
            {
                stateEntry.SetModifiedProperty(property.Name);
            }

            if (obj is IDataObject)
            {
                using (IKistlContext ctx = KistlDataContext.GetContext())
                {
                    Kistl.App.Base.ObjectClass objClass = (obj as IDataObject).Type.GetObjectClass(ctx);
                    while (objClass != null)
                    {
                        foreach (Kistl.App.Base.ValueTypeProperty p in objClass.Properties.OfType<Kistl.App.Base.ValueTypeProperty>().Where(p => p.IsList))
                        {
                            foreach (ICollectionEntry ce in obj.GetPropertyValue<IEnumerable>(p.PropertyName))
                            {
                                MarkEveryPropertyAsModified(ce as EntityObject);
                            }
                        }
                        objClass = objClass.BaseObjectClass;
                    }
                }
            }
        }
    }
}
