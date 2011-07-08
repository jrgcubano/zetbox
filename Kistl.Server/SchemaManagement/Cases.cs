
namespace Kistl.Server.SchemaManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.API.Server;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator;
    using Kistl.Generator.Extensions;

    internal class Cases
        : IDisposable
    {
        private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Kistl.Server.Schema.Cases");

        #region Fields
        private readonly IKistlContext schema;
        private readonly ISchemaProvider db;

        private readonly IKistlContext _savedSchema;
        public IKistlContext savedSchema
        {
            get
            {
                return _savedSchema;
            }
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            // Do not dispose "schema" -> passed to this class
            // Do not dispose "db" -> passed to this class
            if (_savedSchema != null) _savedSchema.Dispose();
        }
        #endregion

        internal Cases(IKistlContext schema, ISchemaProvider db, IKistlContext savedSchema)
        {
            this.schema = schema;
            this.db = db;
            this._savedSchema = savedSchema;
        }

        // Add all IsCase_ + DoCase_ Methods

        #region Cases

        #region DeleteObjectClass
        public bool IsDeleteObjectClass(ObjectClass objClass)
        {
            return schema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid) == null;
        }
        public void DoDeleteObjectClass(ObjectClass objClass)
        {
            if (objClass.NeedsRightsTable())
            {
                DoDeleteObjectClassSecurityRules(objClass);
            }

            var tbl = db.GetQualifiedTableName(objClass.TableName);
            Log.InfoFormat("Drop Table: {0}", tbl);
            db.DropTable(tbl);
        }
        #endregion

        #region NewObjectClass
        public bool IsNewObjectClass(ObjectClass objClass)
        {
            return savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid) == null;
        }
        public void DoNewObjectClass(ObjectClass objClass)
        {
            Log.InfoFormat("New Table: {0}", db.GetQualifiedTableName(objClass.TableName));
            db.CreateTable(db.GetQualifiedTableName(objClass.TableName), objClass.BaseObjectClass == null);
        }
        #endregion

        #region RenameObjectClassTable
        public bool IsRenameObjectClassTable(ObjectClass objClass)
        {
            var saved = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            if (saved == null) return false;
            return saved.TableName != objClass.TableName;
        }
        public void DoRenameObjectClassTable(ObjectClass objClass)
        {
            var saved = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            db.RenameTable(db.GetQualifiedTableName(saved.TableName), db.GetQualifiedTableName(objClass.TableName));
        }
        #endregion

        #region RenameValueTypePropertyName
        public bool IsRenameValueTypePropertyName(ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.Name != prop.Name;
        }
        public void DoRenameValueTypePropertyName(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            // TODO: What if prefix has changed
            db.RenameColumn(db.GetQualifiedTableName(objClass.TableName), Construct.NestedColumnName(saved, prefix), Construct.NestedColumnName(prop, prefix));
        }
        #endregion

        #region MoveValueTypeProperty
        public bool IsMoveValueTypeProperty(ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.ObjectClass.ExportGuid != prop.ObjectClass.ExportGuid;
        }
        public void DoMoveValueTypeProperty(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);

            // TODO: What will happen if the object hierarchie is also changed?
            var movedUp = IsParentOf(objClass, (ObjectClass)saved.ObjectClass);
            var movedDown = IsParentOf((ObjectClass)saved.ObjectClass, objClass);

            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var srcTblName = db.GetQualifiedTableName(((ObjectClass)saved.ObjectClass).TableName);
            var colName = Construct.NestedColumnName(prop, prefix);
            var srcColName = Construct.NestedColumnName(saved, prefix); // TODO: What if prefix has changed
            var dbType = prop.GetDbType();
            var size = prop.GetSize();
            var scale = prop.GetScale();
            var defConstr = SchemaManager.GetDefaultContraint(prop);

            if (movedUp)
            {
                Log.InfoFormat("Moving property '{0}' from '{1}' up to '{2}'", prop.Name, saved.ObjectClass.Name, objClass.Name);
                db.CreateColumn(tblName, colName, dbType, size, scale, true, defConstr);

                db.CopyColumnData(srcTblName, srcColName, tblName, colName);

                if (!prop.IsNullable())
                {
                    if (db.CheckColumnContainsNulls(tblName, colName))
                    {
                        Log.ErrorFormat("column '{0}.{1}' contains NULL values, cannot set NOT NULLABLE", tblName, colName);
                    }
                    else
                    {
                        db.AlterColumn(tblName, colName, dbType, size, scale, prop.IsNullable(), defConstr);
                    }
                }

                db.DropColumn(srcTblName, srcColName);
            }
            else if (movedDown)
            {
                Log.InfoFormat("Moving property '{0}' from '{1}' down to '{2}' (dataloss possible)", prop.Name, saved.ObjectClass.Name, objClass.Name);
                db.CreateColumn(tblName, colName, dbType, size, scale, true, defConstr);

                db.CopyColumnData(srcTblName, srcColName, tblName, colName);

                if (!prop.IsNullable())
                {
                    db.AlterColumn(tblName, colName, dbType, size, scale, prop.IsNullable(), defConstr);
                }

                db.DropColumn(srcTblName, srcColName);
            }
            else
            {
                Log.ErrorFormat("moving a Property from '{0}' to '{1}' is not supported. ObjectClasses are not in the same hierarchy.", saved.ObjectClass.Name, prop.ObjectClass.Name);
            }
        }

        private static bool IsParentOf(ObjectClass objClass, ObjectClass child)
        {
            var cls = child;
            while (cls != null)
            {
                if (cls.ExportGuid == objClass.ExportGuid)
                {
                    return true;
                }
                cls = cls.BaseObjectClass;
            }
            return false;
        }
        #endregion

        #region NewValueTypeProperty nullable
        public bool IsNewValueTypePropertyNullable(ValueTypeProperty prop)
        {
            return prop.IsNullable() && savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid) == null;
        }
        public void DoNewValueTypePropertyNullable(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            string colName = Construct.NestedColumnName(prop, prefix);
            Log.InfoFormat("New nullable ValueType Property: '{0}' ('{1}')", prop.Name, colName);
            db.CreateColumn(db.GetQualifiedTableName(objClass.TableName), colName, prop.GetDbType(), prop.GetSize(), prop.GetScale(), true, SchemaManager.GetDefaultContraint(prop));
        }
        #endregion

        #region NewValueTypeProperty not nullable
        public bool IsNewValueTypePropertyNotNullable(ValueTypeProperty prop)
        {
            return !prop.IsNullable() && savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid) == null;
        }
        public void DoNewValueTypePropertyNotNullable(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var colName = Construct.NestedColumnName(prop, prefix);
            var dbType = prop.GetDbType();
            var size = prop.GetSize();
            var scale = prop.GetScale();
            var def = SchemaManager.GetDefaultContraint(prop);
            Log.InfoFormat("New not nullable ValueType Property: [{0}.{1}] (col:{2})", prop.ObjectClass.Name, prop.Name, colName);
            if (!db.CheckTableContainsData(tblName))
            {
                db.CreateColumn(tblName, colName, dbType, size, scale, false, def);
            }
            else
            {
                db.CreateColumn(tblName, colName, dbType, size, scale, true, def);
                Log.ErrorFormat("unable to create new not nullable ValueType Property '{0}' when table '{1}' contains data. Created nullable column instead.", colName, tblName);
            }
        }
        #endregion

        #region ChangeDefaultValue
        public bool IsChangeDefaultValue(Property prop)
        {
            var saved = savedSchema.FindPersistenceObject<Property>(prop.ExportGuid);
            if (saved == null) return false;
            if (saved.DefaultValue == null && prop.DefaultValue == null) return false;
            return
                (saved.DefaultValue != null && prop.DefaultValue == null)
                || (saved.DefaultValue == null && prop.DefaultValue != null)
                || (saved.DefaultValue.ExportGuid != prop.DefaultValue.ExportGuid);
        }
        public void DoChangeDefaultValue(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var colName = Construct.NestedColumnName(prop, prefix);
            db.AlterColumn(tblName, colName, prop.GetDbType(), prop.GetSize(), prop.GetScale(), prop.IsNullable(), SchemaManager.GetDefaultContraint(prop));
        }
        #endregion

        #region ChangeValueTypeProperty_To_NotNullable
        public bool IsChangeValueTypeProperty_To_NotNullable(ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.IsNullable() && !prop.IsNullable();
        }
        public void DoChangeValueTypeProperty_To_NotNullable(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var colName = Construct.NestedColumnName(prop, prefix);

            if (db.CheckColumnContainsNulls(tblName, colName))
            {
                Log.ErrorFormat("column '{0}.{1}' contains NULL values, cannot set NOT NULLABLE", tblName, colName);
            }
            else
            {
                db.AlterColumn(tblName, colName, prop.GetDbType(), prop.GetSize(), prop.GetScale(), prop.IsNullable(), null);
            }
        }
        #endregion

        #region ChangeValueTypeProperty_To_Nullable
        public bool IsChangeValueTypeProperty_To_Nullable(ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return !saved.IsNullable() && prop.IsNullable();
        }
        public void DoChangeValueTypeProperty_To_Nullable(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var colName = Construct.NestedColumnName(prop, prefix);

            db.AlterColumn(tblName, colName, prop.GetDbType(), prop.GetSize(), prop.GetScale(), prop.IsNullable(), null);
        }
        #endregion

        #region RenameValueTypePropertyListName
        public bool IsRenameValueTypePropertyListName(ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.Name != prop.Name;
        }
        public void DoRenameValueTypePropertyListName(ObjectClass objClass, ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            Log.ErrorFormat("renaming a Property from '{0}' to '{1}' is not supported yet", saved.Name, prop.Name);
        }
        #endregion

        #region MoveValueTypePropertyList
        public bool IsMoveValueTypePropertyList(ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.ObjectClass.ExportGuid != prop.ObjectClass.ExportGuid;
        }
        public void DoMoveValueTypePropertyList(ObjectClass objClass, ValueTypeProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid);
            Log.ErrorFormat("moving a Property from '{0}' to '{1}' is not supported yet", saved.ObjectClass.Name, prop.ObjectClass.Name);
        }
        #endregion

        #region NewValueTypePropertyList
        public bool IsNewValueTypePropertyList(ValueTypeProperty prop)
        {
            return savedSchema.FindPersistenceObject<Property>(prop.ExportGuid) == null;
        }
        public void DoNewValueTypePropertyList(ObjectClass objClass, ValueTypeProperty prop)
        {
            Log.InfoFormat("New ValueType Property List: {0}", prop.Name);
            var tblName = db.GetQualifiedTableName(prop.GetCollectionEntryTable());
            string fkName = prop.GetCollectionEntryReverseKeyColumnName();
            string valPropName = prop.Name;
            string valPropIndexName = prop.Name + "Index";
            string assocName = prop.GetAssociationName();
            bool hasPersistentOrder = prop.HasPersistentOrder;

            db.CreateTable(tblName, true);
            db.CreateColumn(tblName, fkName, System.Data.DbType.Int32, 0, 0, false);

            db.CreateColumn(tblName, valPropName, prop.GetDbType(), prop.GetSize(), prop.GetScale(), false, SchemaManager.GetDefaultContraint(prop));

            if (hasPersistentOrder)
            {
                db.CreateColumn(tblName, valPropIndexName, System.Data.DbType.Int32, 0, 0, false);
            }
            db.CreateFKConstraint(tblName, db.GetQualifiedTableName(objClass.TableName), fkName, assocName, true);
            db.CreateIndex(tblName, Construct.IndexName(tblName.Name, fkName), false, false, fkName);
        }
        #endregion

        #region NewCompoundObjectPropertyList
        public bool IsNewCompoundObjectPropertyList(CompoundObjectProperty prop)
        {
            return savedSchema.FindPersistenceObject<Property>(prop.ExportGuid) == null;
        }
        public void DoNewCompoundObjectPropertyList(ObjectClass objClass, CompoundObjectProperty prop)
        {
            Log.InfoFormat("New CompoundObject Property List: {0}", prop.Name);
            var tblName = db.GetQualifiedTableName(prop.GetCollectionEntryTable());
            string fkName = "fk_" + prop.ObjectClass.Name;

            // TODO: Support neested CompoundObject
            string valPropName = prop.Name;
            string valPropIndexName = prop.Name + "Index";
            string assocName = prop.GetAssociationName();
            bool hasPersistentOrder = prop.HasPersistentOrder;

            db.CreateTable(tblName, true);
            db.CreateColumn(tblName, fkName, System.Data.DbType.Int32, 0, 0, false);

            db.CreateColumn(tblName, valPropName, System.Data.DbType.Boolean, 0, 0, false);
            // TODO: Support neested CompoundObject
            foreach (ValueTypeProperty p in prop.CompoundObjectDefinition.Properties)
            {
                db.CreateColumn(tblName, valPropName + "_" + p.Name, p.GetDbType(), p.GetSize(), p.GetScale(), true, SchemaManager.GetDefaultContraint(prop));
            }

            if (hasPersistentOrder)
            {
                db.CreateColumn(tblName, valPropIndexName, System.Data.DbType.Int32, 0, 0, false);
            }
            db.CreateFKConstraint(tblName, db.GetQualifiedTableName(objClass.TableName), fkName, assocName, true);
            db.CreateIndex(tblName, Construct.IndexName(tblName.Name, fkName), false, false, fkName);
        }
        #endregion

        #region RenameCompoundObjectPropertyListName
        public bool IsRenameCompoundObjectPropertyListName(CompoundObjectProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<CompoundObjectProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.Name != prop.Name;
        }
        public void DoRenameCompoundObjectPropertyListName(ObjectClass objClass, CompoundObjectProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<CompoundObjectProperty>(prop.ExportGuid);
            Log.ErrorFormat("renaming a Property from '{0}' to '{1}' is not supported yet", saved.Name, prop.Name);
        }
        #endregion

        #region MoveCompoundObjectPropertyList
        public bool IsMoveCompoundObjectPropertyList(CompoundObjectProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<CompoundObjectProperty>(prop.ExportGuid);
            if (saved == null) return false;
            return saved.ObjectClass.ExportGuid != prop.ObjectClass.ExportGuid;
        }
        public void DoMoveCompoundObjectPropertyList(ObjectClass objClass, CompoundObjectProperty prop)
        {
            var saved = savedSchema.FindPersistenceObject<CompoundObjectProperty>(prop.ExportGuid);
            Log.ErrorFormat("moving a Property from '{0}' to '{1}' is not supported yet", saved.ObjectClass.Name, prop.ObjectClass.Name);
        }
        #endregion

        #region 1_N_RelationChange_FromNotIndexed_To_Indexed
        public bool Is_1_N_RelationChange_FromNotIndexed_To_Indexed(Relation rel)
        {
            var savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null) return false;
            return (rel.NeedsPositionStorage(RelationEndRole.A) && !savedRel.NeedsPositionStorage(RelationEndRole.A)) ||
                    (rel.NeedsPositionStorage(RelationEndRole.B) && !savedRel.NeedsPositionStorage(RelationEndRole.B));
        }
        public void Do_1_N_RelationChange_FromNotIndexed_To_Indexed(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Create 1:N Relation Position Storage: {0}", assocName);

            RelationEnd relEnd, otherEnd;

            switch (rel.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = rel.A;
                    relEnd = rel.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", assocName, rel.Storage);
                    return;
            }

            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            string colName = Construct.ListPositionColumnName(otherEnd);
            // always allow nulls for items missing a definite order
            db.CreateColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, true);
        }
        #endregion

        #region 1_N_RelationChange_FromIndexed_To_NotIndexed
        public bool Is_1_N_RelationChange_FromIndexed_To_NotIndexed(Relation rel)
        {
            var savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null) return false;
            return (!rel.NeedsPositionStorage(RelationEndRole.A) && savedRel.NeedsPositionStorage(RelationEndRole.A)) ||
                    (!rel.NeedsPositionStorage(RelationEndRole.B) && savedRel.NeedsPositionStorage(RelationEndRole.B));
        }
        public void Do_1_N_RelationChange_FromIndexed_To_NotIndexed(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Drop 1:N Relation Position Storage: {0}", assocName);

            TableRef tblName;
            RelationEnd otherEnd;
            if (rel.HasStorage(RelationEndRole.A))
            {
                tblName = db.GetQualifiedTableName(rel.A.Type.TableName);
                otherEnd = rel.B;
            }
            else if (rel.HasStorage(RelationEndRole.B))
            {
                tblName = db.GetQualifiedTableName(rel.B.Type.TableName);
                otherEnd = rel.A;
            }
            else
            {
                Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", assocName, rel.Storage);
                return;
            }

            db.DropColumn(tblName, Construct.ListPositionColumnName(otherEnd));
        }
        #endregion

        #region 1_N_RelationChange_FromNotNullable_To_Nullable
        public bool Is_1_N_RelationChange_FromNotNullable_To_Nullable(Relation rel)
        {
            var savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null) return false;
            return (rel.A.IsNullable() && !savedRel.A.IsNullable()) ||
                    (rel.B.IsNullable() && !savedRel.B.IsNullable());
        }
        public void Do_1_N_RelationChange_FromNotNullable_To_Nullable(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Make 1:N relation optional: {0}", assocName);

            RelationEnd relEnd, otherEnd;

            switch (rel.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = rel.A;
                    relEnd = rel.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", assocName, rel.Storage);
                    return;
            }

            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var colName = Construct.ForeignKeyColumnName(otherEnd);

            db.AlterColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, otherEnd.IsNullable(), null);
        }
        #endregion

        #region 1_N_RelationChange_FromNullable_To_NotNullable
        public bool Is_1_N_RelationChange_FromNullable_To_NotNullable(Relation rel)
        {
            var savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null) return false;
            return (!rel.A.IsNullable() && savedRel.A.IsNullable()) ||
                    (!rel.B.IsNullable() && savedRel.B.IsNullable());
        }
        public void Do_1_N_RelationChange_FromNullable_To_NotNullable(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Make 1:N relation mandatory: {0}", assocName);

            RelationEnd relEnd, otherEnd;

            switch (rel.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = rel.A;
                    relEnd = rel.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", assocName, rel.Storage);
                    return;
            }

            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var colName = Construct.ForeignKeyColumnName(otherEnd);

            if (db.CheckColumnContainsNulls(tblName, colName))
            {
                Log.ErrorFormat("column '{0}.{1}' contains NULL values, cannot set NOT NULLABLE", tblName, colName);
            }
            else
            {
                db.AlterColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, otherEnd.IsNullable(), null);
            }
        }
        #endregion

        #region Delete_1_N_Relation
        public bool IsDelete_1_N_Relation(Relation rel)
        {
            return schema.FindPersistenceObject<Relation>(rel.ExportGuid) == null;
        }
        public void DoDelete_1_N_Relation(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Deleting 1:N Relation: {0}", assocName);

            TableRef tblName;
            bool isIndexed = false;
            RelationEnd otherEnd;
            if (rel.HasStorage(RelationEndRole.A))
            {
                tblName = db.GetQualifiedTableName(rel.A.Type.TableName);
                isIndexed = rel.NeedsPositionStorage(RelationEndRole.A);
                otherEnd = rel.B;
            }
            else if (rel.HasStorage(RelationEndRole.B))
            {
                tblName = db.GetQualifiedTableName(rel.B.Type.TableName);
                isIndexed = rel.NeedsPositionStorage(RelationEndRole.B);
                otherEnd = rel.A;
            }
            else
            {
                Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", assocName, rel.Storage);
                return;
            }

            db.DropFKConstraint(tblName, assocName);

            string colName = Construct.ForeignKeyColumnName(otherEnd);
            db.DropColumn(tblName, colName);
            if (isIndexed)
            {
                db.DropColumn(tblName, Construct.ListPositionColumnName(otherEnd));
            }
        }
        #endregion

        #region ChangeRelationType
        public bool IsChangeRelationType(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return saved.GetRelationType() != rel.GetRelationType();
        }

        // public void DoChangeRelationType(Relation rel) { no implementaion }

        #region ChangeRelationType_from_1_1_to_1_n
        public bool IsChangeRelationType_from_1_1_to_1_n(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return
                saved.GetRelationType() == RelationType.one_one &&
                rel.GetRelationType() == RelationType.one_n;
        }
        public void DoChangeRelationType_from_1_1_to_1_n(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            string destAssocName = rel.GetAssociationName();
            Log.InfoFormat("Changing 1:1 Relation to 1:N: {0}", destAssocName);

            RelationEnd relEnd, otherEnd;

            switch (rel.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = rel.A;
                    relEnd = rel.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", destAssocName, rel.Storage);
                    return;
            }

            var destTblRef = db.GetQualifiedTableName(relEnd.Type.TableName);
            var destRefTblName = db.GetQualifiedTableName(otherEnd.Type.TableName);
            bool isIndexed = rel.NeedsPositionStorage(relEnd.GetRole());

            string destColName = Construct.ForeignKeyColumnName(otherEnd);
            string destIndexName = Construct.ListPositionColumnName(otherEnd);

            string srcTblName = string.Empty;
            string srcColName = string.Empty;

            // Difference to 1:N. 1:1 may have storage 'Replicate'
            // use best matching
            if (saved.HasStorage(RelationEndRole.A))
            {
                srcTblName = saved.A.Type.TableName;
                srcColName = Construct.ForeignKeyColumnName(saved.B);
            }
            if (saved.HasStorage(RelationEndRole.B) && (string.IsNullOrEmpty(srcTblName) || db.GetQualifiedTableName(srcTblName) != destTblRef))
            {
                srcTblName = saved.B.Type.TableName;
                srcColName = Construct.ForeignKeyColumnName(saved.A);
            }

            var srcTblRef = db.GetQualifiedTableName(srcTblName);

            if (srcTblRef == destTblRef && srcColName == destColName)
            {
                db.DropIndex(srcTblRef, Construct.IndexName(srcTblName, srcColName));
            }
            else if (srcTblRef == destTblRef && srcColName != destColName)
            {
                db.RenameColumn(srcTblRef, srcColName, destColName);
                db.DropIndex(srcTblRef, Construct.IndexName(srcTblName, srcColName));
            }
            else
            {
                db.CreateColumn(destTblRef, destColName, System.Data.DbType.Int32, 0, 0, true);
                db.MigrateFKs(srcTblRef, srcColName, destTblRef, destColName);
                if (!otherEnd.IsNullable())
                {
                    if (!db.CheckColumnContainsNulls(destTblRef, destColName))
                    {
                        db.AlterColumn(destTblRef, destColName, System.Data.DbType.Int32, 0, 0, false, null);
                    }
                    else
                    {
                        Log.ErrorFormat("Unable to alter NOT NULL column, since table contains data. Leaving nullable column instead");
                    }
                }
            }

            db.CreateFKConstraint(destTblRef, destRefTblName, destColName, destAssocName, false);
            db.CreateIndex(destTblRef, Construct.IndexName(destTblRef.Name, destColName), false, false, destColName); 
            if (isIndexed)
            {
                Log.InfoFormat("Creating position column '{0}.{1}'", destTblRef, destIndexName);
                db.CreateColumn(destTblRef, destIndexName, System.Data.DbType.Int32, 0, 0, true);
            }

            // Cleanup
            if (saved.HasStorage(RelationEndRole.A))
            {
                srcTblName = saved.A.Type.TableName;
                srcColName = Construct.ForeignKeyColumnName(saved.B);
                var srcAssocName = saved.GetRelationAssociationName(RelationEndRole.A);

                db.DropFKConstraint(srcTblRef, srcAssocName);
                if (srcTblRef != destTblRef || srcColName != destColName)
                {
                    db.DropColumn(srcTblRef, srcColName);
                }
            }
            if (saved.HasStorage(RelationEndRole.B))
            {
                srcTblName = saved.B.Type.TableName;
                srcColName = Construct.ForeignKeyColumnName(saved.A);
                var srcAssocName = saved.GetRelationAssociationName(RelationEndRole.B);

                db.DropFKConstraint(srcTblRef, srcAssocName);
                if (srcTblRef != destTblRef || srcColName != destColName)
                {
                    db.DropColumn(srcTblRef, srcColName);
                }
            }
        }
        #endregion

        #region ChangeRelationType_from_1_1_to_n_m
        public bool IsChangeRelationType_from_1_1_to_n_m(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return
                saved.GetRelationType() == RelationType.one_one &&
                rel.GetRelationType() == RelationType.n_m;
        }
        public void DoChangeRelationType_from_1_1_to_n_m(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            string srcAssocName = saved.GetAssociationName();

            RelationEnd relEnd, otherEnd;

            switch (saved.Storage)
            {
                case StorageType.Replicate:
                case StorageType.MergeIntoA:
                    relEnd = saved.A;
                    otherEnd = saved.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = saved.A;
                    relEnd = saved.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", srcAssocName, rel.Storage);
                    return;
            }

            var srcTblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var srcColName = Construct.ForeignKeyColumnName(otherEnd);

            var destTbl = db.GetQualifiedTableName(rel.GetRelationTableName());
            var destCol = rel.GetRelationFkColumnName(relEnd.GetRole());
            var destFKCol = rel.GetRelationFkColumnName(otherEnd.GetRole());

            // Drop relations first as 1:1 and n:m relations share the same names
            var srcAssocA = saved.GetRelationAssociationName(RelationEndRole.A);
            if (db.CheckFKConstraintExists(db.GetQualifiedTableName(rel.A.Type.TableName), srcAssocA)) db.DropFKConstraint(db.GetQualifiedTableName(rel.A.Type.TableName), srcAssocA);
            var srcAssocB = saved.GetRelationAssociationName(RelationEndRole.B);
            if (db.CheckFKConstraintExists(db.GetQualifiedTableName(rel.B.Type.TableName), srcAssocB)) db.DropFKConstraint(db.GetQualifiedTableName(rel.B.Type.TableName), srcAssocB);

            DoNew_N_M_Relation(rel);
            db.InsertFKs(srcTblName, srcColName, destTbl, destCol, destFKCol);

            // Drop columns
            if (saved.Storage == StorageType.MergeIntoA || saved.Storage == StorageType.Replicate)
            {
                db.DropColumn(db.GetQualifiedTableName(saved.A.Type.TableName), Construct.ForeignKeyColumnName(saved.B));
            }
            if (saved.Storage == StorageType.MergeIntoB || saved.Storage == StorageType.Replicate)
            {
                db.DropColumn(db.GetQualifiedTableName(saved.B.Type.TableName), Construct.ForeignKeyColumnName(saved.A));
            }
        }
        #endregion

        #region ChangeRelationType_from_1_n_to_1_1
        public bool IsChangeRelationType_from_1_n_to_1_1(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return
                saved.GetRelationType() == RelationType.one_n &&
                rel.GetRelationType() == RelationType.one_one;
        }
        public void DoChangeRelationType_from_1_n_to_1_1(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            string srcAssocName = saved.GetAssociationName();

            RelationEnd relEnd, otherEnd;

            switch (saved.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = saved.A;
                    otherEnd = saved.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = saved.A;
                    relEnd = saved.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", srcAssocName, rel.Storage);
                    return;
            }

            var srcTblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            string srcColName = Construct.ForeignKeyColumnName(otherEnd);
            bool srcIsIndexed = rel.NeedsPositionStorage(relEnd.GetRole());
            string srcIndexName = Construct.ListPositionColumnName(otherEnd);

            if (!db.CheckColumnContainsUniqueValues(srcTblName, srcColName))
            {
                Log.ErrorFormat("Unable to change Relation '{0}' from 1:n to 1:1. Data is not unique", srcAssocName);
                return;
            }

            db.DropFKConstraint(srcTblName, srcAssocName);
            if (srcIsIndexed)
            {
                db.DropColumn(srcTblName, srcIndexName);
            }

            bool aCreated = false;
            bool bCreated = false;

            // Difference to 1:N. 1:1 may have storage 'Replicate'
            // First try to migrate columns
            // And only migrate because the source data might be used twice
            if (rel.HasStorage(RelationEndRole.A))
            {
                var destTblName = db.GetQualifiedTableName(rel.A.Type.TableName);
                var destColName = Construct.ForeignKeyColumnName(rel.B);
                if (destTblName != srcTblName)
                {
                    New_1_1_Relation_CreateColumns(rel, rel.A, rel.B, RelationEndRole.A);
                    db.MigrateFKs(srcTblName, srcColName, destTblName, destColName);
                    aCreated = true;
                }
            }
            if (rel.HasStorage(RelationEndRole.B))
            {
                var destTblName = db.GetQualifiedTableName(rel.B.Type.TableName);
                var destColName = Construct.ForeignKeyColumnName(rel.A);
                if (destTblName != srcTblName)
                {
                    New_1_1_Relation_CreateColumns(rel, rel.B, rel.A, RelationEndRole.B);
                    db.MigrateFKs(srcTblName, srcColName, destTblName, destColName);
                    bCreated = true;
                }
            }
            bool srcColWasReused = false;
            // Then try to rename columns
            if (rel.HasStorage(RelationEndRole.A) && !aCreated)
            {
                var destTblName = db.GetQualifiedTableName(rel.A.Type.TableName);
                var destColName = Construct.ForeignKeyColumnName(rel.B);
                if (destTblName == srcTblName && destColName != srcColName)
                {
                    db.RenameColumn(destTblName, srcColName, destColName);
                }
                var assocName = rel.GetRelationAssociationName(RelationEndRole.A);
                var refTblName = db.GetQualifiedTableName(rel.B.Type.TableName);
                db.CreateFKConstraint(destTblName, refTblName, destColName, assocName, false);
                db.CreateIndex(destTblName, Construct.IndexName(destTblName.Name, destColName), true, false, destColName);
                srcColWasReused = true;
            }
            if (rel.HasStorage(RelationEndRole.B) && !bCreated)
            {
                var destTblName = db.GetQualifiedTableName(rel.B.Type.TableName);
                var destColName = Construct.ForeignKeyColumnName(rel.A);
                if (destTblName == srcTblName && destColName != srcColName)
                {
                    db.RenameColumn(destTblName, srcColName, destColName);
                }
                var assocName = rel.GetRelationAssociationName(RelationEndRole.B);
                var refTblName = db.GetQualifiedTableName(rel.A.Type.TableName);
                db.CreateFKConstraint(destTblName, refTblName, destColName, assocName, false);
                db.CreateIndex(destTblName, Construct.IndexName(destTblName.Name, destColName), true, false, destColName);
                srcColWasReused = true;
            }

            if (!srcColWasReused) db.DropColumn(srcTblName, srcColName);
        }
        #endregion

        #region ChangeRelationType_from_1_n_to_n_m
        public bool IsChangeRelationType_from_1_n_to_n_m(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return
                saved.GetRelationType() == RelationType.one_n &&
                rel.GetRelationType() == RelationType.n_m;
        }
        public void DoChangeRelationType_from_1_n_to_n_m(Relation rel)
        {
            string srcAssocName = rel.GetAssociationName();
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            RelationEnd relEnd, otherEnd;

            switch (saved.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = saved.A;
                    otherEnd = saved.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = saved.A;
                    relEnd = saved.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", srcAssocName, rel.Storage);
                    return;
            }

            var srcTblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var srcColName = Construct.ForeignKeyColumnName(otherEnd);

            var destTbl = db.GetQualifiedTableName(rel.GetRelationTableName());
            var destCol = rel.GetRelationFkColumnName(relEnd.GetRole());
            var destFKCol = rel.GetRelationFkColumnName(otherEnd.GetRole());

            DoNew_N_M_Relation(rel);
            db.InsertFKs(srcTblName, srcColName, destTbl, destCol, destFKCol);
            DoDelete_1_N_Relation(saved);
        }
        #endregion

        #region ChangeRelationType_from_n_m_to_1_1
        public bool IsChangeRelationType_from_n_m_to_1_1(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return
                saved.GetRelationType() == RelationType.n_m &&
                rel.GetRelationType() == RelationType.one_one;
        }
        public void DoChangeRelationType_from_n_m_to_1_1(Relation rel)
        {
            string destAssocName = rel.GetAssociationName();
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            var srcTblName = db.GetQualifiedTableName(saved.GetRelationTableName());

            // Drop relations first as 1:1 and n:m relations share the same names
            var srcAssocA = saved.GetRelationAssociationName(RelationEndRole.A);
            db.DropFKConstraint(srcTblName, srcAssocA);
            var srcAssocB = saved.GetRelationAssociationName(RelationEndRole.B);
            db.DropFKConstraint(srcTblName, srcAssocB);

            DoNew_1_1_Relation(rel);

            if (rel.HasStorage(RelationEndRole.A))
            {
                var destTblName = db.GetQualifiedTableName(rel.A.Type.TableName);
                var destColName = Construct.ForeignKeyColumnName(rel.B);
                var srcColName = rel.GetRelationFkColumnName(RelationEndRole.B);
                var srcFKColName = rel.GetRelationFkColumnName(RelationEndRole.A);

                if (!db.CheckColumnContainsUniqueValues(srcTblName, srcColName))
                {
                    Log.ErrorFormat("Unable to change Relation '{0}' from n:m to 1:1. Data is not unique", destAssocName);
                    return;
                }
                db.CopyFKs(srcTblName, srcColName, destTblName, destColName, srcFKColName);
            }
            if (rel.HasStorage(RelationEndRole.B))
            {
                var destTblName = db.GetQualifiedTableName(rel.B.Type.TableName);
                var destColName = Construct.ForeignKeyColumnName(rel.A);
                var srcColName = rel.GetRelationFkColumnName(RelationEndRole.A);
                var srcFKColName = rel.GetRelationFkColumnName(RelationEndRole.B);

                if (!db.CheckColumnContainsUniqueValues(srcTblName, srcColName))
                {
                    Log.ErrorFormat("Unable to change Relation '{0}' from n:m to 1:1. Data is not unique", destAssocName);
                    return;
                }
                db.CopyFKs(srcTblName, srcColName, destTblName, destColName, srcFKColName);
            }

            db.DropTable(srcTblName);
        }
        #endregion

        #region ChangeRelationType_from_n_m_to_1_n
        public bool IsChangeRelationType_from_n_m_to_1_n(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return
                saved.GetRelationType() == RelationType.n_m &&
                rel.GetRelationType() == RelationType.one_n;
        }
        public void DoChangeRelationType_from_n_m_to_1_n(Relation rel)
        {
            string destAssocName = rel.GetAssociationName();

            RelationEnd relEnd, otherEnd;

            switch (rel.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = rel.A;
                    relEnd = rel.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", destAssocName, rel.Storage);
                    return;
            }

            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            var srcTbl = db.GetQualifiedTableName(saved.GetRelationTableName());
            var srcCol = saved.GetRelationFkColumnName(otherEnd.GetRole());
            var srcFKCol = saved.GetRelationFkColumnName(relEnd.GetRole());

            if (!db.CheckColumnContainsUniqueValues(srcTbl, srcCol))
            {
                Log.ErrorFormat("Unable to change Relation '{0}' from n:m to 1:n. Data is not unique", destAssocName);
                return;
            }

            var destTblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var destColName = Construct.ForeignKeyColumnName(otherEnd);

            DoNew_1_N_Relation(rel);
            db.CopyFKs(srcTbl, srcCol, destTblName, destColName, srcFKCol);
            DoDelete_N_M_Relation(saved);
        }
        #endregion

        #endregion

        #region ChangeRelationEndTypes
        public bool IsChangeRelationEndTypes(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return saved.A.Type.ExportGuid != rel.A.Type.ExportGuid || saved.B.Type.ExportGuid != rel.B.Type.ExportGuid;
        }

        public void DoChangeRelationEndTypes(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            if (rel.GetRelationType() == RelationType.n_m)
            {
                var tblName = db.GetQualifiedTableName(saved.GetRelationTableName());
                if (db.CheckTableContainsData(tblName))
                {
                    Log.WarnFormat("Unable to drop old relation. Relation has some instances. Table: " + tblName);
                }
                else
                {
                    DoDelete_N_M_Relation(saved);
                    DoNew_N_M_Relation(rel);
                }
            }
            else if (rel.GetRelationType() == RelationType.one_n)
            {
                RelationEnd relEnd, otherEnd;

                switch (rel.Storage)
                {
                    case StorageType.MergeIntoA:
                        relEnd = saved.A;
                        otherEnd = saved.B;
                        break;
                    case StorageType.MergeIntoB:
                        otherEnd = saved.A;
                        relEnd = saved.B;
                        break;
                    default:
                        Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", rel.GetAssociationName(), rel.Storage);
                        return;
                }

                var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
                var colName = Construct.ForeignKeyColumnName(otherEnd);

                if (db.CheckColumnContainsValues(tblName, colName))
                {
                    Log.WarnFormat("Unable to drop old relation. Relation has some instances. Table: " + tblName);
                }
                else
                {
                    DoDelete_1_N_Relation(saved);
                    DoNew_1_N_Relation(rel);
                }
            }
            else if (rel.GetRelationType() == RelationType.one_one)
            {
                RelationEnd relEnd, otherEnd;

                switch (rel.Storage)
                {
                    case StorageType.MergeIntoA:
                    case StorageType.Replicate:
                        relEnd = saved.A;
                        otherEnd = saved.B;
                        break;
                    case StorageType.MergeIntoB:
                        otherEnd = saved.A;
                        relEnd = saved.B;
                        break;
                    default:
                        Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", rel.GetAssociationName(), rel.Storage);
                        return;
                }

                var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
                var colName = Construct.ForeignKeyColumnName(otherEnd);

                if (db.CheckColumnContainsValues(tblName, colName))
                {
                    Log.WarnFormat("Unable to drop old relation. Relation has some instances. Table: " + tblName);
                }
                else
                {
                    DoDelete_1_1_Relation(saved);
                    DoNew_1_1_Relation(rel);
                }
            }

        }
        #endregion

        #region ChangeRelationName
        public bool IsChangeRelationName(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            // GetAssociationName and GetRelationAssociationName contains both ARoleName, Verb and BRoleName
            return saved.GetAssociationName() != rel.GetAssociationName();
        }
        public void DoChangeRelationName(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            if (rel.GetRelationType() == RelationType.n_m)
            {
                var srcRelTbl = db.GetQualifiedTableName(saved.GetRelationTableName());
                var destRelTbl = db.GetQualifiedTableName(rel.GetRelationTableName());

                db.RenameFKConstraint(srcRelTbl, saved.GetRelationAssociationName(RelationEndRole.A), rel.GetRelationAssociationName(RelationEndRole.A));
                db.RenameFKConstraint(srcRelTbl, saved.GetRelationAssociationName(RelationEndRole.B), rel.GetRelationAssociationName(RelationEndRole.B));

                db.RenameTable(srcRelTbl, destRelTbl);

                db.RenameColumn(destRelTbl, saved.GetRelationFkColumnName(RelationEndRole.A), rel.GetRelationFkColumnName(RelationEndRole.A));
                db.RenameColumn(destRelTbl, saved.GetRelationFkColumnName(RelationEndRole.B), rel.GetRelationFkColumnName(RelationEndRole.B));
            }
            else if (rel.GetRelationType() == RelationType.one_n)
            {
                if (saved.HasStorage(RelationEndRole.A) &&
                    Construct.ForeignKeyColumnName(saved.B) != Construct.ForeignKeyColumnName(rel.B))
                {
                    var tbl = db.GetQualifiedTableName(rel.A.Type.TableName);
                    db.RenameFKConstraint(tbl, saved.GetAssociationName(), rel.GetAssociationName());
                    db.RenameColumn(tbl, Construct.ForeignKeyColumnName(saved.B), Construct.ForeignKeyColumnName(rel.B));
                }
                else if (saved.HasStorage(RelationEndRole.B) &&
                    Construct.ForeignKeyColumnName(saved.A) != Construct.ForeignKeyColumnName(rel.A))
                {
                    var tbl = db.GetQualifiedTableName(rel.B.Type.TableName);
                    db.RenameFKConstraint(tbl, saved.GetAssociationName(), rel.GetAssociationName());
                    db.RenameColumn(tbl, Construct.ForeignKeyColumnName(saved.A), Construct.ForeignKeyColumnName(rel.A));
                }
            }
            else if (rel.GetRelationType() == RelationType.one_one)
            {
                if (saved.HasStorage(RelationEndRole.A))
                {
                    var tbl = db.GetQualifiedTableName(rel.A.Type.TableName);
                    db.RenameFKConstraint(tbl, saved.GetRelationAssociationName(RelationEndRole.A), rel.GetRelationAssociationName(RelationEndRole.A));
                    if (Construct.ForeignKeyColumnName(saved.B) != Construct.ForeignKeyColumnName(rel.B))
                    {
                        db.RenameColumn(tbl, Construct.ForeignKeyColumnName(saved.B), Construct.ForeignKeyColumnName(rel.B));
                    }
                }
                if (saved.HasStorage(RelationEndRole.B))
                {
                    var tbl = db.GetQualifiedTableName(rel.B.Type.TableName);
                    db.RenameFKConstraint(tbl, saved.GetRelationAssociationName(RelationEndRole.B), rel.GetRelationAssociationName(RelationEndRole.B));
                    if (Construct.ForeignKeyColumnName(saved.A) != Construct.ForeignKeyColumnName(rel.A))
                    {
                        db.RenameColumn(tbl, Construct.ForeignKeyColumnName(saved.A), Construct.ForeignKeyColumnName(rel.A));
                    }
                }
            }
        }
        #endregion

        #region New_1_N_Relation
        public bool IsNew_1_N_Relation(Relation rel)
        {
            return savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid) == null;
        }
        public void DoNew_1_N_Relation(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("New 1:N Relation: {0}", assocName);

            RelationEnd relEnd, otherEnd;

            switch (rel.Storage)
            {
                case StorageType.MergeIntoA:
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    break;
                case StorageType.MergeIntoB:
                    otherEnd = rel.A;
                    relEnd = rel.B;
                    break;
                default:
                    Log.ErrorFormat("Relation '{0}' has unsupported Storage set: {1}, skipped", assocName, rel.Storage);
                    return;
            }

            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var refTblName = db.GetQualifiedTableName(otherEnd.Type.TableName);
            bool isIndexed = rel.NeedsPositionStorage(relEnd.GetRole());

            var colName = Construct.ForeignKeyColumnName(otherEnd);
            var indexName = Construct.ListPositionColumnName(otherEnd);

            CreateFKColumn(otherEnd, tblName, colName);
            db.CreateFKConstraint(tblName, refTblName, colName, assocName, false);
            db.CreateIndex(tblName, Construct.IndexName(tblName.Name, colName), false, false, colName);

            if (isIndexed)
            {
                Log.InfoFormat("Creating position column '{0}.{1}'", tblName, indexName);
                db.CreateColumn(tblName, indexName, System.Data.DbType.Int32, 0, 0, true);
            }
        }
        #endregion

        #region N_M_RelationChange_FromNotIndexed_To_Indexed
        public bool Is_N_M_RelationChange_FromNotIndexed_To_Indexed(Relation rel, RelationEndRole role)
        {
            var savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null) return false;
            return rel.NeedsPositionStorage(role) && !savedRel.NeedsPositionStorage(role);
        }
        public void Do_N_M_RelationChange_FromNotIndexed_To_Indexed(Relation rel, RelationEndRole role)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Create N:M Relation {1} PositionStorage: {0}", assocName, role);

            var tblName = db.GetQualifiedTableName(rel.GetRelationTableName());
            var fkName = rel.GetRelationFkColumnName(role);

            db.CreateColumn(tblName, fkName + Kistl.API.Helper.PositionSuffix, System.Data.DbType.Int32, 0, 0, true);
        }
        #endregion

        #region N_M_RelationChange_FromIndexed_To_NotIndexed
        public bool Is_N_M_RelationChange_FromIndexed_To_NotIndexed(Relation rel, RelationEndRole role)
        {
            var savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null) return false;
            return !rel.NeedsPositionStorage(role) && savedRel.NeedsPositionStorage(role);
        }
        public void Do_N_M_RelationChange_FromIndexed_To_NotIndexed(Relation rel, RelationEndRole role)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Drop N:M Relation {1} PositionStorage: {0}", assocName, role);

            var tblName = db.GetQualifiedTableName(rel.GetRelationTableName());
            var fkName = rel.GetRelationFkColumnName(role);

            db.DropColumn(tblName, fkName + Kistl.API.Helper.PositionSuffix);
        }
        #endregion

        #region Delete_N_M_Relation
        public bool IsDelete_N_M_Relation(Relation rel)
        {
            return schema.FindPersistenceObject<Relation>(rel.ExportGuid) == null;
        }
        public void DoDelete_N_M_Relation(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("Deleting N:M Relation: {0}", assocName);

            var tblName = db.GetQualifiedTableName(rel.GetRelationTableName());

            db.DropFKConstraint(tblName, rel.GetRelationAssociationName(RelationEndRole.A));
            db.DropFKConstraint(tblName, rel.GetRelationAssociationName(RelationEndRole.B));

            db.DropTable(tblName);
        }
        #endregion

        #region New_N_M_Relation
        public bool IsNew_N_M_Relation(Relation rel)
        {
            return savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid) == null;
        }
        public void DoNew_N_M_Relation(Relation rel)
        {
            string assocName = rel.GetAssociationName();
            Log.InfoFormat("New N:M Relation: {0}", assocName);

            var tblName = db.GetQualifiedTableName(rel.GetRelationTableName());
            var fkAName = rel.GetRelationFkColumnName(RelationEndRole.A);
            var fkBName = rel.GetRelationFkColumnName(RelationEndRole.B);

            db.CreateTable(tblName, true);

            db.CreateColumn(tblName, fkAName, System.Data.DbType.Int32, 0, 0, false);
            if (rel.NeedsPositionStorage(RelationEndRole.A))
            {
                db.CreateColumn(tblName, fkAName + Kistl.API.Helper.PositionSuffix, System.Data.DbType.Int32, 0, 0, true);
            }

            db.CreateColumn(tblName, fkBName, System.Data.DbType.Int32, 0, 0, false);
            if (rel.NeedsPositionStorage(RelationEndRole.B))
            {
                db.CreateColumn(tblName, fkBName + Kistl.API.Helper.PositionSuffix, System.Data.DbType.Int32, 0, 0, true);
            }

            if (rel.A.Type.ImplementsIExportable() && rel.B.Type.ImplementsIExportable())
            {
                db.CreateColumn(tblName, "ExportGuid", System.Data.DbType.Guid, 0, 0, false, new NewGuidDefaultConstraint());
            }

            db.CreateFKConstraint(tblName, db.GetQualifiedTableName(rel.A.Type.TableName), fkAName, rel.GetRelationAssociationName(RelationEndRole.A), false);
            db.CreateIndex(tblName, Construct.IndexName(tblName.Name, fkAName), false, false, fkAName);
            db.CreateFKConstraint(tblName, db.GetQualifiedTableName(rel.B.Type.TableName), fkBName, rel.GetRelationAssociationName(RelationEndRole.B), false);
            db.CreateIndex(tblName, Construct.IndexName(tblName.Name, fkBName), false, false, fkBName);
        }
        #endregion

        #region Delete_1_1_Relation
        public bool IsDelete_1_1_Relation(Relation rel)
        {
            return schema.FindPersistenceObject<Relation>(rel.ExportGuid) == null;
        }
        public void DoDelete_1_1_Relation(Relation rel)
        {
            Log.InfoFormat("Deleting 1:1 Relation: {0}", rel.GetAssociationName());

            if (rel.HasStorage(RelationEndRole.A))
            {
                Delete_1_1_Relation_DropColumns(rel, rel.A, rel.B, RelationEndRole.A);
            }
            // Difference to 1:N. 1:1 may have storage 'Replicate'
            if (rel.HasStorage(RelationEndRole.B))
            {
                Delete_1_1_Relation_DropColumns(rel, rel.B, rel.A, RelationEndRole.B);
            }
        }

        private void Delete_1_1_Relation_DropColumns(Relation rel, RelationEnd end, RelationEnd otherEnd, RelationEndRole role)
        {
            var tblName = db.GetQualifiedTableName(end.Type.TableName);
            var colName = Construct.ForeignKeyColumnName(otherEnd);
            var assocName = rel.GetRelationAssociationName(role);

            db.DropFKConstraint(tblName, assocName);
            db.DropColumn(tblName, colName);

            if (rel.NeedsPositionStorage(role))
            {
                db.DropColumn(tblName, Construct.ListPositionColumnName(otherEnd));
            }
        }
        #endregion

        #region New_1_1_Relation
        public bool IsNew_1_1_Relation(Relation rel)
        {
            return savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid) == null;
        }
        public void DoNew_1_1_Relation(Relation rel)
        {
            Log.InfoFormat("New 1:1 Relation: {0}", rel.GetAssociationName());

            if (rel.Storage == StorageType.MergeIntoA || rel.Storage == StorageType.Replicate)
            {
                New_1_1_Relation_CreateColumns(rel, rel.A, rel.B, RelationEndRole.A);
            }

            if (rel.Storage == StorageType.MergeIntoB || rel.Storage == StorageType.Replicate)
            {
                New_1_1_Relation_CreateColumns(rel, rel.B, rel.A, RelationEndRole.B);
            }
        }

        private void New_1_1_Relation_CreateColumns(Relation rel, RelationEnd relEnd, RelationEnd otherEnd, RelationEndRole role)
        {
            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var refTblName = db.GetQualifiedTableName(otherEnd.Type.TableName);
            var colName = Construct.ForeignKeyColumnName(otherEnd);
            var assocName = rel.GetRelationAssociationName(role);
            var idxName = Construct.IndexName(tblName.Name, colName);

            CreateFKColumn(otherEnd, tblName, colName);
            db.CreateFKConstraint(tblName, refTblName, colName, assocName, false);
            db.CreateIndex(tblName, idxName, true, false, colName);

            if (rel.NeedsPositionStorage(role))
            {
                Log.ErrorFormat("1:1 Relation should never need position storage, but this one does!");
            }
        }

        private void CreateFKColumn(RelationEnd otherEnd, TableRef tblName, string colName)
        {
            if (otherEnd.IsNullable() || !db.CheckTableContainsData(tblName))
            {
                db.CreateColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, otherEnd.IsNullable());
            }
            else
            {
                db.CreateColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, true);
                Log.ErrorFormat("Unable to create NOT NULL column, since table contains data. Created nullable column instead");
            }
        }
        #endregion

        #region Change_1_1_Storage
        public bool IsChange_1_1_Storage(Relation rel)
        {
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (saved == null) return false;
            return rel.Storage != saved.Storage;
        }
        public void DoChange_1_1_Storage(Relation rel)
        {
            Log.InfoFormat("Changing 1:1 Relation Storage: {0}", rel.GetAssociationName());
            var saved = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);

            if (saved.Storage == StorageType.Replicate)
            {
                // To MergeIntoA or MergeIntoB
                if (rel.HasStorage(RelationEndRole.B))
                {
                    Delete_1_1_Relation_DropColumns(saved, saved.A, saved.B, RelationEndRole.A);
                }
                else if (rel.HasStorage(RelationEndRole.A))
                {
                    Delete_1_1_Relation_DropColumns(saved, saved.B, saved.A, RelationEndRole.B);
                }
            }
            else
            {
                RelationEnd relEnd;
                RelationEnd otherEnd;
                RelationEndRole role;
                RelationEndRole otherRole;
                if (saved.Storage == StorageType.MergeIntoA)
                {
                    // To MergeIntoB or Replicate
                    relEnd = rel.B;
                    otherEnd = rel.A;
                    role = RelationEndRole.B;
                    otherRole = RelationEndRole.A;

                }
                else if (saved.Storage == StorageType.MergeIntoB)
                {
                    // To MergeIntoA or Replicate
                    relEnd = rel.A;
                    otherEnd = rel.B;
                    role = RelationEndRole.A;
                    otherRole = RelationEndRole.B;
                }
                else
                {
                    throw new InvalidOperationException("Unexpected saved stroage type " + saved.Storage.ToString());
                }

                New_1_1_Relation_CreateColumns(rel, relEnd, otherEnd, role);
                var srcTbl = db.GetQualifiedTableName(otherEnd.Type.TableName);
                var srcCol = Construct.ForeignKeyColumnName(relEnd);
                var destTbl = db.GetQualifiedTableName(relEnd.Type.TableName);
                var destCol = Construct.ForeignKeyColumnName(otherEnd);
                db.MigrateFKs(srcTbl, srcCol, destTbl, destCol);
                if (!relEnd.IsNullable())
                {
                    if (!db.CheckColumnContainsNulls(destTbl, destCol))
                    {
                        db.AlterColumn(destTbl, destCol, System.Data.DbType.Int32, 0, 0, false, null);
                    }
                    else
                    {
                        Log.ErrorFormat("Unable to alter NOT NULL column, since table contains data. Leaving nullable column instead");
                    }
                }

                if (rel.Storage != StorageType.Replicate)
                {
                    Delete_1_1_Relation_DropColumns(rel, otherEnd, relEnd, otherRole);
                }
            }
        }
        #endregion

        #region 1_1_RelationChange_FromNullable_To_NotNullable
        public bool Is1_1_RelationChange_FromNullable_To_NotNullable(Relation rel, RelationEndRole role)
        {
            Relation savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null)
            {
                return false;
            }
            return savedRel.GetOtherEndFromRole(role).IsNullable() && !rel.GetOtherEndFromRole(role).IsNullable()
                && ((rel.Storage == StorageType.MergeIntoA && role == RelationEndRole.A)
                    || (rel.Storage == StorageType.MergeIntoB && role == RelationEndRole.B)
                    || (rel.Storage == StorageType.Replicate));
        }
        public void Do1_1_RelationChange_FromNullable_To_NotNullable(Relation rel, RelationEndRole role)
        {
            RelationEnd relEnd = rel.GetEndFromRole(role);
            RelationEnd otherEnd = rel.GetOtherEndFromRole(role);

            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var colName = Construct.ForeignKeyColumnName(otherEnd);

            db.AlterColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, otherEnd.IsNullable(), null);
        }
        #endregion

        #region 1_1_RelationChange_FromNotNullable_To_Nullable
        public bool Is1_1_RelationChange_FromNotNullable_To_Nullable(Relation rel, RelationEndRole role)
        {
            Relation savedRel = savedSchema.FindPersistenceObject<Relation>(rel.ExportGuid);
            if (savedRel == null)
            {
                return false;
            }
            return !savedRel.GetOtherEndFromRole(role).IsNullable() && rel.GetOtherEndFromRole(role).IsNullable()
                && ((rel.Storage == StorageType.MergeIntoA && role == RelationEndRole.A)
                    || (rel.Storage == StorageType.MergeIntoB && role == RelationEndRole.B)
                    || (rel.Storage == StorageType.Replicate));
        }
        public void Do1_1_RelationChange_FromNotNullable_To_Nullable(Relation rel, RelationEndRole role)
        {
            RelationEnd relEnd = rel.GetEndFromRole(role);
            RelationEnd otherEnd = rel.GetOtherEndFromRole(role);

            var tblName = db.GetQualifiedTableName(relEnd.Type.TableName);
            var colName = Construct.ForeignKeyColumnName(otherEnd);

            if (db.CheckColumnContainsNulls(tblName, colName))
            {
                Log.ErrorFormat("column '{0}.{1}' contains NULL values, cannot set NOT NULLABLE", tblName, colName);
            }
            else
            {
                db.AlterColumn(tblName, colName, System.Data.DbType.Int32, 0, 0, otherEnd.IsNullable(), null);
            }
        }
        #endregion

        #region NewObjectClassInheritance
        public bool IsNewObjectClassInheritance(ObjectClass objClass)
        {
            if (objClass.BaseObjectClass == null) return false;

            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            return savedObjClass == null || savedObjClass.BaseObjectClass == null;
        }
        public void DoNewObjectClassInheritance(ObjectClass objClass)
        {
            var assocName = Construct.InheritanceAssociationName(objClass.BaseObjectClass, objClass);
            var tblName = db.GetQualifiedTableName(objClass.TableName);

            Log.InfoFormat("New ObjectClass Inheritance: {0} -> {1}: {2}", objClass.Name, objClass.BaseObjectClass.Name, assocName);

            if (db.CheckTableContainsData(tblName))
            {
                Log.ErrorFormat("Table '{0}' contains data. Unable to add inheritence.", tblName);
                return;
            }

            db.CreateFKConstraint(tblName, db.GetQualifiedTableName(objClass.BaseObjectClass.TableName), "ID", assocName, false);
        }
        #endregion

        #region ChangeObjectClassInheritance
        public bool IsChangeObjectClassInheritance(ObjectClass objClass)
        {
            if (objClass.BaseObjectClass == null) return false;

            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            if (savedObjClass == null) return false;
            if (savedObjClass.BaseObjectClass == null) return false;

            return savedObjClass.BaseObjectClass.ExportGuid != objClass.BaseObjectClass.ExportGuid;
        }
        public void DoChangeObjectClassInheritance(ObjectClass objClass)
        {
            Log.InfoFormat("Changing ObjectClass Inheritance: {0} -> {1}", objClass.Name, objClass.BaseObjectClass.Name);
            DoRemoveObjectClassInheritance(objClass);
            DoNewObjectClassInheritance(objClass);
        }
        #endregion

        #region RemoveObjectClassInheritance
        public bool IsRemoveObjectClassInheritance(ObjectClass objClass)
        {
            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            if (savedObjClass == null) return false;

            return savedObjClass.BaseObjectClass != null && objClass.BaseObjectClass == null;
        }
        public void DoRemoveObjectClassInheritance(ObjectClass objClass)
        {
            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            string assocName = Construct.InheritanceAssociationName(savedObjClass.BaseObjectClass, savedObjClass);
            var tblName = db.GetQualifiedTableName(objClass.TableName);

            Log.InfoFormat("Remove ObjectClass Inheritance: {0} -> {1}: {2}", savedObjClass.Name, savedObjClass.BaseObjectClass.Name, assocName);

            db.DropFKConstraint(tblName, assocName);
        }
        #endregion

        #region NewObjectClassACL
        public bool IsNewObjectClassACL(ObjectClass objClass)
        {
            if (!objClass.NeedsRightsTable()) return false;
            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            return savedObjClass == null || !savedObjClass.NeedsRightsTable();
        }
        public void DoNewObjectClassACL(ObjectClass objClass)
        {
            Log.InfoFormat("New ObjectClass Security Rules: {0}", objClass.Name);
            var tblRightsName = db.GetQualifiedTableName(Construct.SecurityRulesTableName(objClass));

            db.CreateTable(tblRightsName, false, false);
            db.CreateColumn(tblRightsName, "Identity", System.Data.DbType.Int32, 0, 0, false);
            db.CreateColumn(tblRightsName, "Right", System.Data.DbType.Int32, 0, 0, false);

            db.CreateIndex(tblRightsName, Construct.SecurityRulesIndexName(objClass), true, true, "ID", "Identity");
            db.CreateFKConstraint(tblRightsName, db.GetQualifiedTableName(objClass.TableName), "ID", Construct.SecurityRulesFKName(objClass), true);

            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var rightsViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(objClass));
            var refreshRightsOnProcedureName = db.GetQualifiedProcedureName(Construct.SecurityRulesRefreshRightsOnProcedureName(objClass));

            DoCreateUpdateRightsTrigger(objClass);
            DoCreateRightsViewUnmaterialized(objClass);
            db.CreateRefreshRightsOnProcedure(refreshRightsOnProcedureName, rightsViewUnmaterializedName, tblName, tblRightsName);
            db.ExecRefreshRightsOnProcedure(refreshRightsOnProcedureName);
        }

        public void DoCreateRightsViewUnmaterialized(ObjectClass objClass)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var tblRightsName = db.GetQualifiedTableName(Construct.SecurityRulesTableName(objClass));
            var rightsViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(objClass));

            if (objClass.AccessControlList.Count == 0)
            {
                Log.ErrorFormat("Unable to create RightsViewUnmaterialized: ObjectClass '{0}' has an empty AccessControlList", objClass.Name);
                db.CreateEmptyRightsViewUnmaterialized(rightsViewUnmaterializedName);
                return;
            }


            List<ACL> viewAcls = new List<ACL>();
            foreach (var ac in objClass.AccessControlList.OfType<RoleMembership>())
            {
                if (ac.Relations.Count == 0)
                {
                    Log.ErrorFormat("Unable to create RightsViewUnmaterialized: RoleMembership '{0}' has no relations", ac.Name);
                    db.CreateEmptyRightsViewUnmaterialized(rightsViewUnmaterializedName);
                    return;
                }

                var viewAcl = new ACL();
                viewAcls.Add(viewAcl);
                viewAcl.Right = (Kistl.API.AccessRights)ac.Rights;
                try
                {
                    viewAcl.Relations.AddRange(SchemaManager.CreateJoinList(db, objClass, ac.Relations));
                }
                catch (SchemaManager.JoinListException ex)
                {
                    Log.ErrorFormat(ex.Message);
                    db.CreateEmptyRightsViewUnmaterialized(rightsViewUnmaterializedName);
                    return;
                }
            }

            db.CreateRightsViewUnmaterialized(rightsViewUnmaterializedName, tblName, tblRightsName, viewAcls);
        }

        public void DoCreateUpdateRightsTrigger(ObjectClass objClass)
        {
            var updateRightsTriggerName = Construct.SecurityRulesUpdateRightsTriggerName(objClass);
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            if (db.CheckTriggerExists(tblName, updateRightsTriggerName)) db.DropTrigger(tblName, updateRightsTriggerName);

            var tblList = new List<RightsTrigger>();
            tblList.Add(new RightsTrigger()
            {
                TblName = db.GetQualifiedTableName(objClass.TableName),
                TblNameRights = db.GetQualifiedTableName(Construct.SecurityRulesTableName(objClass)),
                ViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(objClass))
            });

            // Get all ObjectClasses that depends on current object class
            var list = schema.GetQuery<ObjectClass>()
                .Where(o => o.AccessControlList.OfType<RoleMembership>()
                    .Where(rm => rm.Relations
                        .Where(r => r.A.Type == objClass || r.B.Type == objClass).Count() > 0).Count() > 0)
                .Distinct().ToList().Where(o => o.NeedsRightsTable() && o != objClass);
            foreach (var dep in list)
            {
                Log.DebugFormat("  Additional update Table: {0}", dep.TableName);
                foreach (var ac in dep.AccessControlList.OfType<RoleMembership>())
                {
                    var rel = ac.Relations.FirstOrDefault(r => r.A.Type == objClass || r.B.Type == objClass);
                    if (rel != null)
                    {
                        var rt = new RightsTrigger()
                        {
                            TblName = db.GetQualifiedTableName(dep.TableName),
                            TblNameRights = db.GetQualifiedTableName(Construct.SecurityRulesTableName(dep)),
                            ViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(dep)),
                        };
                        rt.Relations.AddRange(SchemaManager.CreateJoinList(db, dep, ac.Relations, rel));
                        tblList.Add(rt);
                    }
                }
            }

            db.CreateUpdateRightsTrigger(updateRightsTriggerName, tblName, tblList);
        }

        public void DoCreateUpdateRightsTrigger(Relation rel)
        {
            var updateRightsTriggerName = Construct.SecurityRulesUpdateRightsTriggerName(rel);
            var tblName = db.GetQualifiedTableName(rel.GetRelationTableName());
            if (db.CheckTriggerExists(tblName, updateRightsTriggerName)) db.DropTrigger(tblName, updateRightsTriggerName);

            var tblList = new List<RightsTrigger>();

            // Get all ObjectClasses that depends on current relation
            var list = schema.GetQuery<ObjectClass>()
                .Where(o => o.AccessControlList.OfType<RoleMembership>()
                    .Where(rm => rm.Relations
                        .Where(r => r == rel).Count() > 0).Count() > 0)
                .Distinct().ToList().Where(o => o.NeedsRightsTable());

            foreach (var dep in list)
            {
                Log.DebugFormat("  Additional update Table: {0}", dep.TableName);
                foreach (var ac in dep.AccessControlList.OfType<RoleMembership>())
                {
                    if (ac.Relations.Contains(rel))
                    {
                        var rt = new RightsTrigger()
                        {
                            TblName = db.GetQualifiedTableName(dep.TableName),
                            TblNameRights = db.GetQualifiedTableName(Construct.SecurityRulesTableName(dep)),
                            ViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(dep)),
                        };
                        // Ignore last one - this is our n:m end
                        var joinList = SchemaManager.CreateJoinList(db, dep, ac.Relations, rel);
                        rt.Relations.AddRange(joinList.Take(joinList.Count - 1));
                        tblList.Add(rt);
                    }
                }
            }

            db.CreateUpdateRightsTrigger(updateRightsTriggerName, tblName, tblList);
        }
        #endregion

        #region ChangeObjectClassACL
        public bool IsChangeObjectClassACL(ObjectClass objClass)
        {
            if (objClass == null) throw new ArgumentNullException("objClass");

            // Basic checks
            if (!objClass.NeedsRightsTable()) return false;
            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            if (savedObjClass == null) return false;
            if (!savedObjClass.NeedsRightsTable()) return false;

            // Check each AccessControl
            var acl = objClass.AccessControlList;
            var savedAcl = savedObjClass.AccessControlList;

            if (acl.Count != savedAcl.Count) return true;

            foreach (var ac in acl.OfType<RoleMembership>())
            {
                var sac = savedAcl.OfType<RoleMembership>().FirstOrDefault(i => i.ExportGuid == ac.ExportGuid);
                if (sac == null) return true;

                if (ac.Relations.Count != sac.Relations.Count) return true;

                for (int i = 0; i < ac.Relations.Count; i++)
                {
                    if (ac.Relations[i].ExportGuid != sac.Relations[i].ExportGuid) return true;
                }
            }

            return false;
        }

        public void DoChangeObjectClassACL(ObjectClass objClass)
        {
            var rightsViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(objClass));
            var refreshRightsOnProcedureName = db.GetQualifiedProcedureName(Construct.SecurityRulesRefreshRightsOnProcedureName(objClass));

            db.DropView(rightsViewUnmaterializedName);
            DoCreateRightsViewUnmaterialized(objClass);
            db.ExecRefreshRightsOnProcedure(refreshRightsOnProcedureName);
        }
        #endregion

        #region DeleteObjectClassSecurityRules
        public bool IsDeleteObjectClassSecurityRules(ObjectClass objClass)
        {
            if (objClass.NeedsRightsTable()) return false;
            ObjectClass savedObjClass = savedSchema.FindPersistenceObject<ObjectClass>(objClass.ExportGuid);
            return savedObjClass != null && savedObjClass.NeedsRightsTable();
        }
        public void DoDeleteObjectClassSecurityRules(ObjectClass objClass)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var tblRightsName = db.GetQualifiedTableName(Construct.SecurityRulesTableName(objClass));
            var rightsViewUnmaterializedName = db.GetQualifiedTableName(Construct.SecurityRulesRightsViewUnmaterializedName(objClass));
            var refreshRightsOnProcedureName = Construct.SecurityRulesRefreshRightsOnProcedureName(objClass);
            var updateRightsTriggerName = Construct.SecurityRulesUpdateRightsTriggerName(objClass);

            Log.InfoFormat("Delete ObjectClass Security Rules: {0}", objClass.Name);

            db.DropTrigger(tblName, updateRightsTriggerName);
            db.DropProcedure(db.GetQualifiedProcedureName(refreshRightsOnProcedureName));
            db.DropView(rightsViewUnmaterializedName);
            db.DropTable(tblRightsName);
        }
        #endregion

        #region DeleteValueTypeProperty
        public bool IsDeleteValueTypeProperty(ValueTypeProperty prop)
        {
            return schema.FindPersistenceObject<ValueTypeProperty>(prop.ExportGuid) == null;
        }

        public void DoDeleteValueTypeProperty(ObjectClass objClass, ValueTypeProperty prop, string prefix)
        {
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var colName = Construct.NestedColumnName(prop, prefix);
            Log.InfoFormat("Drop Column: {0}.{1}", tblName, colName);
            db.DropColumn(tblName, colName);
        }
        #endregion

        #region NewValueTypeProperty nullable
        public bool IsNewCompoundObjectProperty(CompoundObjectProperty prop)
        {
            return savedSchema.FindPersistenceObject<CompoundObjectProperty>(prop.ExportGuid) == null;
        }
        public void DoNewCompoundObjectProperty(ObjectClass objClass, CompoundObjectProperty cprop, string prefix)
        {
            string colName_IsNull = Construct.NestedColumnName(cprop, prefix);            
            Log.InfoFormat("New is null column for CompoundObject Property: '{0}' ('{1}')", cprop.Name, colName_IsNull);
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var hasData = db.CheckTableContainsData(tblName);
            var constr = cprop.IsNullable()
                ? new DatabaseConstraint[] { new BoolDefaultConstraint() { Value = true } }
                : new DatabaseConstraint[] { new BoolDefaultConstraint() { Value = false }, new BoolCheckConstraint() { Value = false } };
            if (!hasData)
            {
                db.CreateColumn(tblName, colName_IsNull, System.Data.DbType.Boolean, 0, 0, false, constr);
            }
            else
            {
                db.CreateColumn(tblName, colName_IsNull, System.Data.DbType.Boolean, 0, 0, true, constr);
                Log.ErrorFormat("unable to create new not nullable CompoundObject Property '{0}' when table '{1}' contains data. Created nullable column instead.", cprop.Name, tblName);
            }

            foreach (var valProp in cprop.CompoundObjectDefinition.Properties.OfType<ValueTypeProperty>())
            {
                var colName = Construct.NestedColumnName(valProp, colName_IsNull);
                Log.InfoFormat("New nullable ValueType Property: '{0}' ('{1}')", valProp.Name, colName);
                db.CreateColumn(
                    tblName,
                    colName,
                    valProp.GetDbType(),
                    valProp.GetSize(),
                    valProp.GetScale(),
                    hasData || cprop.IsNullable() || valProp.IsNullable(),
                    SchemaManager.GetDefaultContraint(valProp));
            }

            // TODO: Add neested CompoundObjectProperty
        }
        #endregion

        #region NewIndexConstraint
        public bool IsNewIndexConstraint(IndexConstraint uc)
        {
            return uc.Constrained is ObjectClass && savedSchema.FindPersistenceObject<IndexConstraint>(uc.ExportGuid) == null;
        }
        public void DoNewIndexConstraint(IndexConstraint uc)
        {
            var objClass = (ObjectClass)uc.Constrained;
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var columns = GetUCColNames(uc);
            Log.InfoFormat("New Index Contraint: {0} on {1}({2})", uc.Reason, tblName, string.Join(", ", columns));
            db.CreateIndex(tblName, Construct.IndexName(objClass.TableName, columns), uc.IsUnique, false, columns);
        }

        internal static string[] GetUCColNames(IndexConstraint uc)
        {
            var vt_columns = uc.Properties.OfType<ValueTypeProperty>().Select(p => Construct.NestedColumnName(p, null)).ToArray();
            var columns = vt_columns.Union(uc.Properties.OfType<ObjectReferenceProperty>().Select(p => Construct.ForeignKeyColumnName(p.RelationEnd.Parent.GetOtherEnd(p.RelationEnd)))).OrderBy(n => n).ToArray();
            return columns;
        }
        #endregion

        #region DeleteIndexConstraint
        public bool IsDeleteIndexConstraint(IndexConstraint uc)
        {
            return uc.Constrained is ObjectClass && schema.FindPersistenceObject<IndexConstraint>(uc.ExportGuid) == null;
        }
        public void DoDeleteIndexConstraint(IndexConstraint uc)
        {
            var objClass = (ObjectClass)uc.Constrained;
            var tblName = db.GetQualifiedTableName(objClass.TableName);
            var columns = GetUCColNames(uc);
            Log.InfoFormat("Drop Index Contraint: {0} on {1}({2})", uc.Reason, objClass.TableName, string.Join(", ", columns));
            db.DropIndex(tblName, Construct.IndexName(objClass.TableName, columns));
        }
        #endregion

        #region ChangeIndexConstraint
        public bool IsChangeIndexConstraint(IndexConstraint uc)
        {
            if (!(uc is IndexConstraint)) return false;
            var saved = savedSchema.FindPersistenceObject<IndexConstraint>(uc.ExportGuid);
            if (saved == null) return false;

            if (uc.IsUnique != saved.IsUnique) return true;

            var newCols = GetUCColNames(uc);
            var savedCols = GetUCColNames(saved);
            if (newCols.Length != savedCols.Length) return true;
            foreach (var c in newCols)
            {
                if (!savedCols.Contains(c)) return true;
            }
            return false;
        }
        public void DoChangeIndexConstraint(IndexConstraint uc)
        {
            var saved = savedSchema.FindPersistenceObject<IndexConstraint>(uc.ExportGuid);
            DoDeleteIndexConstraint(saved);
            DoNewIndexConstraint(uc);
        }
        #endregion

        #region NewSchema
        internal bool IsNewSchema(string schemaName)
        {
            return db.CheckSchemaExists(schemaName);
        }

        internal void DoNewSchema(string schemaName)
        {
            Log.InfoFormat("New Schema: {0}", schemaName);
            db.CreateSchema(schemaName);
        }
        #endregion

        #endregion

        public void DoCreateRefreshAllRightsProcedure(List<ObjectClass> allACLTables)
        {
            var procName = db.GetQualifiedProcedureName(Construct.SecurityRulesRefreshAllRightsProcedureName());
            if (db.CheckProcedureExists(procName))
            {
                db.DropProcedure(procName);
            }
            var refreshProcNames = allACLTables
                .Select(i => db.GetQualifiedProcedureName(Construct.SecurityRulesRefreshRightsOnProcedureName(i)))
                .ToList();
            db.CreateRefreshAllRightsProcedure(refreshProcNames);
        }
    }
}
