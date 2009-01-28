using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.Server.Movables;
using System.Data.Metadata.Edm;
using Kistl.API;
using Kistl.App.Base;

namespace Kistl.Server.Generators.EntityFramework.Implementation
{

    public static class RelationExtensions
    {

        /// <summary>
        /// Calculates EF's preferred storage for a given NewRelation
        /// </summary>
        public static StorageHint GetPreferredStorage(this NewRelation rel)
        {
            if (rel.A.Multiplicity.UpperBound() == 1 && rel.B.Multiplicity.UpperBound() == 1)
            {
                // arbitrary 1:1 relations default 
                return StorageHint.MergeA;
            }
            else if (rel.A.Multiplicity.UpperBound() == 1 && rel.B.Multiplicity.UpperBound() > 1)
            {
                // if multiple Bs can exist, they get the fk
                return StorageHint.MergeB;
            }
            else if (rel.A.Multiplicity.UpperBound() > 1 && rel.B.Multiplicity.UpperBound() == 1)
            {
                // if multiple As ca exist, they get the fk
                return StorageHint.MergeA;
            }
            else if (rel.A.Multiplicity.UpperBound() > 1 && rel.B.Multiplicity.UpperBound() > 1)
            {
                // N:M needs "weak" entity
                return StorageHint.Separate;
            }

            // this means that UpperBound() < 1 for some end
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the association name for the given relation
        /// </summary>
        public static string GetAssociationName(this NewRelation rel)
        {
            return String.Format("FK_{0}_{1}_{2}_{3}", rel.A.Type.ClassName, rel.B.Type.ClassName, rel.A.RoleName, rel.ID);
        }

        /// <summary>
        /// Returns the association name for the given ValueTypeProperty
        /// </summary>
        public static string GetAssociationName(this ValueTypeProperty prop)
        {
            return String.Format("FK_{0}_{1}_{2}", prop.ObjectClass.ClassName, prop.GetPropertyType().Name, prop.PropertyName);
        }

        /// <summary>
        /// Returns the association name for the association from the given end to the CollectionEntry
        /// </summary>
        public static string GetCollectionEntryAssociationName(this NewRelation rel, RelationEnd end)
        {
            return String.Format("FK_{0}_{1}_{2}_{3}", rel.A.Type.ClassName, rel.B.Type.ClassName, end.RoleName, rel.ID);
        }

        public static string GetCollectionEntryClassName(this NewRelation rel)
        {
            return String.Format("{0}_{1}{2}CollectionEntry", rel.A.Type.ClassName, rel.A.Navigator.PropertyName, rel.ID);
        }

        public static string GetCollectionEntryFullName(this NewRelation rel)
        {
            return String.Format("{0}.{1}", rel.A.Type.Namespace, rel.GetCollectionEntryClassName());
        }

        public static string GetCollectionEntryClassName(this ValueTypeProperty prop)
        {
            return String.Format("{0}_{1}CollectionEntry", prop.ObjectClass.ClassName, prop.PropertyName);
        }

        public static string GetCollectionEntryFullName(this ValueTypeProperty prop)
        {
            return String.Format("{0}.{1}", prop.ObjectClass.Module.Namespace, prop.GetCollectionEntryClassName());
        }

        /// <summary>
        /// maps from a NewRelationship.Multiplicity to EF's RelationshipMultiplicity as used in the CSDL part of EDMX
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static RelationshipMultiplicity ToCsdlRelationshipMultiplicity(this Multiplicity m)
        {
            switch (m)
            {
                case Multiplicity.One:
                case Multiplicity.ZeroOrOne:
                    // ObjectReferences in C# are always nullable
                    return RelationshipMultiplicity.ZeroOrOne;
                case Multiplicity.ZeroOrMore:
                    return RelationshipMultiplicity.Many;
                default:
                    throw new ArgumentOutOfRangeException("m");
            }
        }

        /// <summary>
        /// maps from a NewRelationship.Multiplicity to EF's RelationshipMultiplicity as used in the SSDL part of EDMX
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static RelationshipMultiplicity ToSsdlMultiplicity(this Multiplicity m)
        {
            switch (m)
            {
                case Multiplicity.One:
                case Multiplicity.ZeroOrOne:
                    return RelationshipMultiplicity.ZeroOrOne;
                case Multiplicity.ZeroOrMore:
                    return RelationshipMultiplicity.Many;
                default:
                    throw new ArgumentOutOfRangeException("m");
            }
        }
        /// <summary>
        /// Calculate how the RelationshipMultiplicity is written as EDMX attribute value
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static string ToXmlValue(this RelationshipMultiplicity m)
        {
            switch (m)
            {
                case RelationshipMultiplicity.One:
                    return "1";
                case RelationshipMultiplicity.ZeroOrOne:
                    return "0..1";
                case RelationshipMultiplicity.Many:
                    return "*";
                default:
                    throw new ArgumentOutOfRangeException("m");
            }
        }

        ///// <summary>
        ///// Whether or not the given relation will result in two association 
        ///// sets. Note that this is true exactly if this is a N:M relation.
        ///// </summary>
        //public static bool IsTwoProngedAssociation(this NewRelation rel, IKistlContext ctx)
        //{
        //    return rel.GetPreferredStorage() == StorageHint.Separate;
        //}

    }
}
