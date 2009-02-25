using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.Server.Movables;

namespace Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses
{
    public partial class ObjectReferencePropertyTemplate
    {

        public static void Call(Arebis.CodeGeneration.IGenerationHost host,
            IKistlContext ctx,
            Templates.Implementation.SerializationMembersList serializationList,
            ObjectReferenceProperty prop)
        {
            Debug.Assert(!prop.IsList);

            string name = prop.PropertyName;
            string referencedInterface = prop.ReferenceObjectClass.Module.Namespace + "." + prop.ReferenceObjectClass.ClassName;

            var rel = NewRelation.Lookup(ctx, prop);
            var relEnd = rel.GetEnd(prop);
            Call(host, ctx, serializationList,
                name, referencedInterface, rel, relEnd);

        }

        public static void Call(Arebis.CodeGeneration.IGenerationHost host,
            IKistlContext ctx,
            Templates.Implementation.SerializationMembersList serializationList,
            string name,
            string referencedInterface,
            NewRelation rel,
            RelationEnd relEnd)
        {
            string efName = name + Kistl.API.Helper.ImplementationSuffix;
            string fkName = "fk_" + name;
            string fkBackingName = "_fk_" + name;

            var otherEnd = relEnd.Other;
            bool hasInverseNavigator = otherEnd.Navigator != null;

            Call(host, ctx, serializationList,
                name, efName, fkName, fkBackingName, referencedInterface, rel, relEnd, otherEnd, hasInverseNavigator, relEnd.Other.HasPersistentOrder);
        }


        public static void Call(Arebis.CodeGeneration.IGenerationHost host,
            IKistlContext ctx,
            Templates.Implementation.SerializationMembersList serializationList,
            string name,
            string efName,
            string fkName,
            string fkBackingName,
            string referencedInterface,
            NewRelation rel,
            RelationEnd relEnd,
            RelationEnd otherEnd,
            bool hasInverseNavigator,
            bool hasPositionStorage)
        {
            host.CallTemplate("Implementation.ObjectClasses.ObjectReferencePropertyTemplate", ctx, serializationList,
                name, efName, fkName, fkBackingName, referencedInterface, rel, relEnd, otherEnd, hasInverseNavigator, hasPositionStorage);
        }

        protected virtual void AddSerialization(Templates.Implementation.SerializationMembersList list, string memberName)
        {
            if (list != null)
                list.Add(memberName);
        }
    }
}
