
namespace Kistl.App.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Kistl.API;
    using Kistl.App.Base;

    public static class RelationExtensions
    {
        public static Relation Lookup(IKistlContext ctx, ObjectReferenceProperty prop)
        {
            if (prop.RelationEnd == null) return null;
            return prop.RelationEnd.AParent ?? prop.RelationEnd.BParent;
        }

        /// <summary>
        /// Returns the association name for the association from the given end to the CollectionEntry
        /// </summary>
        public static string GetRelationAssociationName(this Relation rel, RelationEndRole endRole)
        {
            RelationEnd relEnd = rel.GetEndFromRole(endRole);

            return String.Format("FK_{0}_{1}_{2}_{3}", rel.A.Type.ClassName, rel.Verb, rel.B.Type.ClassName, relEnd.RoleName);
        }

        public static RelationEndRole GetRole(this RelationEnd relEnd)
        {
            if (relEnd.AParent == null && relEnd.BParent == null)
            {
                throw new ArgumentOutOfRangeException("relEnd", "RelationEnd not connected to any parent");
            }
            return relEnd.AParent != null ? RelationEndRole.A : RelationEndRole.B;
        }

        public static Relation GetParent(this RelationEnd relEnd)
        {
            return relEnd.AParent ?? relEnd.BParent;
        }

        public static ObjectClass GetReferencedObjectClass(this ObjectReferenceProperty prop)
        {
            var rel = prop.RelationEnd.GetParent();
            var relEnd = prop.RelationEnd;
            var otherEnd = rel.GetOtherEnd(relEnd);
            return otherEnd.Type;
        }

        public static bool IsNullable(this RelationEnd relEnd)
        {
            return relEnd.Multiplicity.LowerBound() == 0;
        }

        public static RelationEnd GetOtherEndFromRole(this Relation rel, RelationEndRole role)
        {
            switch (role)
            {
                case RelationEndRole.A:
                    return rel.B;
                case RelationEndRole.B:
                    return rel.A;
                default:
                    throw new ArgumentOutOfRangeException("role", String.Format("unknown RelationEndRole '{0}'", role));
            }
        }

        // Use after next commit
        //public static bool HasStorage(this Relation rel, RelationEndRole role)
        //{
        //    if (rel.Storage == StorageType.Replicate)
        //        throw new NotImplementedException();

        //    RelationType type = rel.GetRelationType();
        //    // n:m has no storage on A or B
        //    return
        //           (type == RelationType.one_n && rel.Storage == StorageType.MergeIntoA && role == RelationEndRole.A)
        //        || (type == RelationType.one_n && rel.Storage == StorageType.MergeIntoB && role == RelationEndRole.B)
        //        || (type == RelationType.one_one && rel.Storage == StorageType.Replicate)
        //        || (type == RelationType.one_one && rel.Storage == StorageType.MergeIntoA && role == RelationEndRole.A)
        //        || (type == RelationType.one_one && rel.Storage == StorageType.MergeIntoB && role == RelationEndRole.B);
        //}
    }
}
