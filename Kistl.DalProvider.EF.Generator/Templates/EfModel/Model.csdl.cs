
namespace Kistl.DalProvider.Ef.Generator.Templates.EfModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator.Extensions;

    public partial class ModelCsdl
    {
        /// <summary>
        /// returns a &lt;Property/&gt; element describing the property 
        /// without regards for the IsList flag.
        /// </summary>
        /// therefore it can be used both when defining a type (IsList == 
        /// false) and when defining the CollectionEntry (IsList == true)
        internal static string PlainPropertyDefinitionFromValueType(ValueTypeProperty prop, string name, string implementationSuffix)
        {
            string type = prop.GetPropertyTypeString();
            string maxlength = String.Empty;
            string precScaleAttr = String.Empty;

            if (prop is EnumerationProperty)
            {
                type = "Int32";
                name += implementationSuffix;
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
            EfModel.ModelCsdlEntityTypeFields.Call(Host, ctx, properties);
        }

        protected virtual string GetAbstractModifier(ObjectClass cls)
        {
            return cls.IsAbstract ? " Abstract=\"true\"" : string.Empty;
        }
    }
}
