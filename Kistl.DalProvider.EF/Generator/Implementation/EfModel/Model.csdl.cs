using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators.Extensions;

namespace Kistl.DalProvider.EF.Generator.Implementation.EfModel
{
    public partial class ModelCsdl
    {
        /// <summary>
        /// returns a &lt;Property/&gt; element describing the property 
        /// without regards for the IsList flag.
        /// </summary>
        /// therefore it can be used both when defining a type (IsList == 
        /// false) and when defining the CollectionEntry (IsList == true)
        internal static string PlainPropertyDefinitionFromValueType(ValueTypeProperty prop)
        {
            return PlainPropertyDefinitionFromValueType(prop, prop.Name);
        }

        /// <summary>
        /// returns a &lt;Property/&gt; element describing the property 
        /// without regards for the IsList flag.
        /// </summary>
        /// therefore it can be used both when defining a type (IsList == 
        /// false) and when defining the CollectionEntry (IsList == true)
        internal static string PlainPropertyDefinitionFromValueType(ValueTypeProperty prop, string name)
        {
            string type = prop.GetPropertyTypeString();
            string maxlength = String.Empty;
            string precScaleAttr = String.Empty;

            if (prop is EnumerationProperty)
            {
                type = "Int32";
                name += Kistl.API.Helper.ImplementationSuffix;
            }
            else
            {
                // translate to short name
                type = Type.GetType(type).Name;
            }

            if (prop is StringProperty)
            {
                maxlength = String.Format("MaxLength=\"{0}\" ", ((StringProperty)prop).GetMaxLength());
            }

            if (prop is DecimalProperty)
            {
                DecimalProperty dp = (DecimalProperty)prop;
                // must have one space at the end
                precScaleAttr = String.Format("Precision=\"{0}\" Scale=\"{1}\" ", dp.Precision, dp.Scale);
            }

            return String.Format("<Property Name=\"{0}\" Type=\"{1}\" Nullable=\"{2}\" {3}{4}/>",
                name, type, prop.IsNullable().ToString().ToLowerInvariant(), maxlength, precScaleAttr);
        }

        protected virtual void ApplyEntityTypeFieldDefs(IEnumerable<Property> properties)
        {
            Implementation.EfModel.ModelCsdlEntityTypeFields.Call(Host, ctx, properties);
        }

        protected virtual string GetAbstractModifier(ObjectClass cls)
        {
            return cls.IsAbstract ? " Abstract=\"true\"" : string.Empty;
        }

        internal static IEnumerable<Relation> GetRelationsWithSeparateStorage(IKistlContext ctx)
        {
            return ctx.GetQuery<Relation>()
                .Where(r => r.Storage == StorageType.Separate)
                .ToList()
                .OrderBy(r => r.GetAssociationName());
        }

        internal static IEnumerable<Relation> GetRelationsWithoutSeparateStorage(IKistlContext ctx)
        {
            return ctx.GetQuery<Relation>()
                .Where(r => r.Storage != StorageType.Separate)
                .ToList()
                .OrderBy(r => r.GetAssociationName());
        }

    }
}
