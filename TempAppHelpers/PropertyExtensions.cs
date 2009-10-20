using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.App.Base;
using Kistl.API;

namespace Kistl.App.Extensions
{
    public static class PropertyExtensions
    {
        /// <summary>
        /// Returns the association name for the given ValueTypeProperty
        /// </summary>
        public static string GetAssociationName(this ValueTypeProperty prop)
        {
            if (!prop.IsList) throw new NotSupportedException("GetAssociationName is only valid for Lists");
            return String.Format("FK_{0}_{1}_{2}", prop.ObjectClass.ClassName, "value", prop.PropertyName);
        }

        public static bool IsNullable(this Property p)
        {
            if (p is ObjectReferenceProperty)
            {
                return IsNullable((ObjectReferenceProperty)p);
            }
            else
            {
                return p.Constraints.OfType<NotNullableConstraint>().Count() == 0;
            }
        }

        private static bool IsNullable(this ObjectReferenceProperty p)
        {
            var relEnd = p.RelationEnd;
            var rel = relEnd.GetParent();
            var otherEnd = rel.GetOtherEnd(relEnd);

            return otherEnd.IsNullable();
        }

        public static bool HasLengthConstraint(this StringProperty prop)
        {
            return prop.Constraints.OfType<StringRangeConstraint>().Count() > 0;
        }

        public static StringRangeConstraint GetLengthConstraint(this StringProperty prop)
        {
            return prop.Constraints.OfType<StringRangeConstraint>().FirstOrDefault();
        }

        public static int GetMaxLength(this StringProperty prop)
        {
            StringRangeConstraint constraint = prop.GetLengthConstraint();
            // create unconstrained maxLength if no constrain is specified
            return constraint == null ? 4000 : constraint.MaxLength;
        }

        public static bool IsList(this ObjectReferenceProperty prop)
        {
            RelationEnd relEnd = prop.RelationEnd;
            Relation rel = relEnd.GetParent();
            RelationEnd otherEnd = rel.GetOtherEnd(relEnd);

            return otherEnd.Multiplicity.UpperBound() > 1;
        }

    }
}
