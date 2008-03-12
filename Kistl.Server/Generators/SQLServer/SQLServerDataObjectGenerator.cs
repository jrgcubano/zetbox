using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;

using Kistl.App.Base;
using System.IO;
using System.Reflection;
using System.Collections;
using Kistl.API;

namespace Kistl.Server.Generators.SQLServer
{
    public class SQLServerDataObjectGenerator : BaseDataObjectGenerator
    {
        #region AddDefaultNamespaces
        protected override void AddDefaultNamespaces(CodeNamespace ns)
        {
            base.AddDefaultNamespaces(ns);
            ns.Imports.Add(new CodeNamespaceImport("System.Data.Objects"));
            ns.Imports.Add(new CodeNamespaceImport("System.Data.Objects.DataClasses"));
        }
        #endregion

        #region GenerateAssemblyInfo
        protected override void GenerateAssemblyInfo(CodeCompileUnit code, ClientServerEnum clientServer)
        {
            base.GenerateAssemblyInfo(code, clientServer);

            if (clientServer == ClientServerEnum.Server)
            {
                code.AssemblyCustomAttributes.Add(new CodeAttributeDeclaration(
                    new CodeTypeReference(typeof(System.Data.Objects.DataClasses.EdmSchemaAttribute))));
            }
        }
        #endregion

        #region GenerateObjects
        protected override void GenerateObjects(Current current)
        {
            base.GenerateObjects(current);

            if (current.clientServer == ClientServerEnum.Server)
            {
                GenerateEdmRelationshipAttribute(current.objClass, current.code);

                current.code_class.CustomAttributes.Add(new CodeAttributeDeclaration("EdmEntityTypeAttribute",
                    new CodeAttributeArgument("NamespaceName",
                        new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument("Name",
                        new CodePrimitiveExpression(current.objClass.ClassName))));
            }
        }
        #endregion

        #region GenerateEdmRelationshipAttribute
        private void GenerateEdmRelationshipAttribute(ObjectType parentType, ObjectType childType, CodeCompileUnit code)
        {
            code.AssemblyCustomAttributes.Add(new CodeAttributeDeclaration("System.Data.Objects.DataClasses.EdmRelationshipAttribute",
            new CodeAttributeArgument(
                new CodePrimitiveExpression("Model")),
            new CodeAttributeArgument(
                new CodePrimitiveExpression(Generator.GetAssociationName(parentType, childType))),
            new CodeAttributeArgument(
                new CodePrimitiveExpression(Generator.GetAssociationParentRoleName(parentType))),
            new CodeAttributeArgument(
                new CodeSnippetExpression("System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne")),
            new CodeAttributeArgument(
                new CodeTypeOfExpression(parentType.NameDataObject)),
            new CodeAttributeArgument(
                new CodePrimitiveExpression(Generator.GetAssociationChildRoleName(childType))),
            new CodeAttributeArgument(
                new CodeSnippetExpression("System.Data.Metadata.Edm.RelationshipMultiplicity.Many")),
            new CodeAttributeArgument(
                new CodeTypeOfExpression(childType.NameDataObject))
                ));
        }

        private void GenerateEdmRelationshipAttribute(ObjectClass objClass, CodeCompileUnit code)
        {
            var props = objClass.Properties.OfType<ObjectReferenceProperty>();

            foreach (ObjectReferenceProperty prop in props)
            {
                ObjectType parentType = new ObjectType(prop.GetDataType());
                ObjectType childType = Generator.GetAssociationChildType(prop);

                GenerateEdmRelationshipAttribute(parentType, childType, code);
            }
        }
        #endregion

        #region GenerateServerDefaultProperties

        protected override void GenerateDefaultProperty_ID(Current current)
        {
            base.GenerateDefaultProperty_ID(current);

            if (current.clientServer == ClientServerEnum.Server)
            {
                current.code_property.CustomAttributes.Add(new CodeAttributeDeclaration("EdmScalarPropertyAttribute",
                    new CodeAttributeArgument("EntityKeyProperty",
                        new CodePrimitiveExpression(true)),
                    new CodeAttributeArgument("IsNullable",
                        new CodePrimitiveExpression(false))));
            }
        }

        #endregion

        #region GenerateValueTypeProperty
        protected override void GenerateProperties_ValueTypeProperty(Current current)
        {
            base.GenerateProperties_ValueTypeProperty(current);

            if (current.clientServer == ClientServerEnum.Server)
            {
                current.code_property.CustomAttributes.Add(new CodeAttributeDeclaration("EdmScalarPropertyAttribute"));
            }
        }
        #endregion

        #region GenerateProperties_ObjectReferenceProperty_Collection
        protected override void GenerateProperties_ObjectReferenceProperty_Collection(Current current, Current collectionClass, Current serializerValue, Current parent, Current serializerParent)
        {
            base.GenerateProperties_ObjectReferenceProperty_Collection(current, collectionClass, serializerValue, parent, serializerParent);

            if (current.clientServer == ClientServerEnum.Server)
            {
                // Assembly Code Relation

                GenerateEdmRelationshipAttribute(new ObjectType(current.code_namespace.Name, current.code_class.Name),
                    new ObjectType(collectionClass.code_namespace.Name, collectionClass.code_class.Name), current.code);

                // Class
                current.code_property.Type = new CodeTypeReference("EntityCollection", new CodeTypeReference(collectionClass.code_class.Name));

                current.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(current.code_namespace, current.code_class, collectionClass.code_namespace, collectionClass.code_class))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationChildRoleName(collectionClass.code_namespace, collectionClass.code_class)))));


                current.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityCollection<{0}> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<{0}>(""Model.{1}"", ""B_{2}"");
                if (!c.IsLoaded) c.Load(); 
                return c", collectionClass.code_class.Name, Generator.GetAssociationName(current.code_namespace, current.code_class, collectionClass.code_namespace, collectionClass.code_class), collectionClass.code_class.Name)));

                // Collection Class
                collectionClass.code_class.CustomAttributes.Add(new CodeAttributeDeclaration("EdmEntityTypeAttribute",
                    new CodeAttributeArgument("NamespaceName",
                        new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument("Name",
                        new CodePrimitiveExpression(collectionClass.code_class.Name))));

                ObjectReferenceProperty objRefProp = (ObjectReferenceProperty)current.property;

                collectionClass.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(objRefProp.ReferenceObjectClass, collectionClass.code_namespace, collectionClass.code_class))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationParentRoleName(objRefProp.ReferenceObjectClass)))));
                
                collectionClass.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value", current.property.GetDataType(), Generator.GetAssociationName(objRefProp.ReferenceObjectClass, collectionClass.code_namespace, collectionClass.code_class), objRefProp.ReferenceObjectClass.ClassName)));

                collectionClass.code_property.SetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value", current.property.GetDataType(), Generator.GetAssociationName(objRefProp.ReferenceObjectClass, collectionClass.code_namespace, collectionClass.code_class), objRefProp.ReferenceObjectClass.ClassName)));

                // Collection.Serializer.Value
                serializerValue.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Value == Helper.INVALIDID && Value != null)
                {{
                    _fk_Value = Value.ID;
                }}
                return _fk_Value", current.property.PropertyName)));
                serializerValue.code_property.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_fk_Value"), new CodePropertySetValueReferenceExpression()));

                // Collection.Serializer.Parent
                serializerParent.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Parent == Helper.INVALIDID && Parent != null)
                {{
                    _fk_Parent = Parent.ID;
                }}
                return _fk_Parent", current.property.PropertyName)));
                serializerParent.code_property.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_fk_Parent"), new CodePropertySetValueReferenceExpression()));

                // Collection.Parent
                parent.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(current.objClass, collectionClass.code_namespace, collectionClass.code_class))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationParentRoleName(current.objClass)))));

                parent.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value", current.objClass.ClassName, Generator.GetAssociationName(current.objClass, collectionClass.code_namespace, collectionClass.code_class), current.objClass.ClassName)));

                parent.code_property.SetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value", current.objClass.ClassName, Generator.GetAssociationName(current.objClass, collectionClass.code_namespace, collectionClass.code_class), current.objClass.ClassName)));
            }
            else
            {
                collectionClass.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"return Context.GetQuery<{0}>().Single(o => o.ID == fk_Value)", current.property.GetDataType())));
                collectionClass.code_property.SetStatements.Add(new CodeSnippetExpression(@"_fk_Value = value.ID"));

                parent.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"return Context.GetQuery<{0}>().Single(o => o.ID == fk_Parent)", current.objClass.ClassName)));
                parent.code_property.SetStatements.Add(new CodeSnippetExpression(@"_fk_Parent = value.ID"));

                serializerValue.code_property.GetStatements.Add(new CodeSnippetExpression(@"return _fk_Value"));
                serializerValue.code_property.SetStatements.Add(new CodeSnippetExpression("_fk_Value = value"));

                serializerParent.code_property.GetStatements.Add(new CodeSnippetExpression(@"return _fk_Parent"));
                serializerParent.code_property.SetStatements.Add(new CodeSnippetExpression("_fk_Parent = value"));
            }
        }
        #endregion

        #region GenerateProperties_ValueTypeProperty_Collection
        protected override void GenerateProperties_ValueTypeProperty_Collection(Current current, Current collectionClass, Current parent, Current serializerParent)
        {
            base.GenerateProperties_ValueTypeProperty_Collection(current, collectionClass, parent, serializerParent);

            if (current.clientServer == ClientServerEnum.Server)
            {
                collectionClass.code_property.CustomAttributes.Add(new CodeAttributeDeclaration("EdmScalarPropertyAttribute"));

                GenerateEdmRelationshipAttribute(new ObjectType(current.code_namespace.Name, current.code_class.Name),
                    new ObjectType(collectionClass.code_namespace.Name, collectionClass.code_class.Name), current.code);

                collectionClass.code_class.CustomAttributes.Add(new CodeAttributeDeclaration("EdmEntityTypeAttribute",
                    new CodeAttributeArgument("NamespaceName",
                        new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument("Name",
                        new CodePrimitiveExpression(collectionClass.code_class.Name))));

                current.code_property.Type = new CodeTypeReference("EntityCollection", new CodeTypeReference(collectionClass.code_class.Name));

                current.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(current.code_namespace, current.code_class, collectionClass.code_namespace, collectionClass.code_class))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationChildRoleName(collectionClass.code_namespace, collectionClass.code_class)))));


                current.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityCollection<{0}> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<{0}>(""Model.{1}"", ""B_{2}"");
                if (!c.IsLoaded) c.Load(); 
                return c", collectionClass.code_class.Name, Generator.GetAssociationName(current.code_namespace, current.code_class, collectionClass.code_namespace, collectionClass.code_class), collectionClass.code_class.Name)));

                // Collection.Serializer.Parent
                serializerParent.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Parent == Helper.INVALIDID && Parent != null)
                {{
                    _fk_Parent = Parent.ID;
                }}
                return _fk_Parent", current.property.PropertyName)));
                serializerParent.code_property.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_fk_Parent"), new CodePropertySetValueReferenceExpression()));

                // Collection.Parent
                parent.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(current.objClass, collectionClass.code_namespace, collectionClass.code_class))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationParentRoleName(current.objClass)))));

                parent.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value", current.objClass.ClassName, Generator.GetAssociationName(current.objClass, collectionClass.code_namespace, collectionClass.code_class), current.objClass.ClassName)));

                parent.code_property.SetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value", current.objClass.ClassName, Generator.GetAssociationName(current.objClass, collectionClass.code_namespace, collectionClass.code_class), current.objClass.ClassName)));
            }
            else
            {

                parent.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"return Context.GetQuery<{0}>().Single(o => o.ID == fk_Parent)", current.objClass.ClassName)));
                parent.code_property.SetStatements.Add(new CodeSnippetExpression(@"_fk_Parent = value.ID"));

                serializerParent.code_property.GetStatements.Add(new CodeSnippetExpression(@"return _fk_Parent"));
                serializerParent.code_property.SetStatements.Add(new CodeSnippetExpression("_fk_Parent = value"));
            }
        }
        #endregion

        #region GenerateObjectReferenceProperty

        protected override void GenerateProperties_ObjectReferenceProperty(Current current, Current serializer)
        {
            base.GenerateProperties_ObjectReferenceProperty(current, serializer);

            if (current.clientServer == ClientServerEnum.Server)
            {
                ObjectReferenceProperty objRefProp = (ObjectReferenceProperty)current.property;

                current.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(objRefProp.ReferenceObjectClass, current.objClass))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationParentRoleName(objRefProp.ReferenceObjectClass)))));


                current.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value", current.property.GetDataType(), Generator.GetAssociationName(objRefProp.ReferenceObjectClass, current.objClass), objRefProp.ReferenceObjectClass.ClassName)));

                current.code_property.SetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value", current.property.GetDataType(), Generator.GetAssociationName(objRefProp.ReferenceObjectClass, current.objClass), objRefProp.ReferenceObjectClass.ClassName)));

                serializer.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_{0} == Helper.INVALIDID && {0} != null)
                {{
                    _fk_{0} = {0}.ID;
                }}
                return _fk_{0}", current.property.PropertyName)));
                serializer.code_property.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_fk_" + current.property.PropertyName), new CodePropertySetValueReferenceExpression()));
            }
        }

        #endregion

        #region GenerateBackReferenceProperty

        protected override void GenerateProperties_BackReferenceProperty(Current current)
        {
            base.GenerateProperties_BackReferenceProperty(current);

            BackReferenceProperty backRefProp = (BackReferenceProperty)current.property;

            if (current.clientServer == ClientServerEnum.Client)
            {
                ObjectType childType = new ObjectType(current.property.GetDataType());
                current.code_property.Type = new CodeTypeReference("List", new CodeTypeReference(childType.NameDataObject));

                current.code_property.GetStatements.Add(
                    new CodeSnippetExpression(string.Format(
                        @"if(_{0} == null) _{0} = Context.GetListOf<{1}>(this, ""{0}"");
                return _{0}",
                    current.property.PropertyName, childType.NameDataObject)));

                CodeMemberField f = new CodeMemberField(current.code_property.Type,
                    "_" + current.property.PropertyName);

                current.code_class.Members.Add(f);
            }
            else
            {
                ObjectType childType = Generator.GetAssociationChildType((BackReferenceProperty)current.property);

                current.code_property.Type = new CodeTypeReference("EntityCollection", new CodeTypeReference(childType.NameDataObject));
                current.code_property.CustomAttributes.Add(new CodeAttributeDeclaration(
                    "EdmRelationshipNavigationPropertyAttribute",
                    new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationName(current.objClass, childType))),
                    new CodeAttributeArgument(new CodePrimitiveExpression(Generator.GetAssociationChildRoleName(childType)))));


                current.code_property.GetStatements.Add(
                    new CodeSnippetExpression(
                        string.Format(@"EntityCollection<{0}> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<{0}>(""Model.{1}"", ""{2}"");
                if (!c.IsLoaded) c.Load(); 
                return c", childType.NameDataObject, 
                         Generator.GetAssociationName(current.objClass, childType), 
                         Generator.GetAssociationChildRoleName(childType))));
            }
        }

        #endregion

    }
}
