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
    public class SQLServerDataObjectGenerator : IDataObjectGenerator
    {
        private string path = "";
        private Kistl.API.Server.KistlDataContext ctx = null;

        public void Generate(Kistl.API.Server.KistlDataContext ctx, string path)
        {
            this.ctx = ctx;
            Console.WriteLine("Generating Objects...");
            this.path = path + (path.EndsWith("\\") ? "" : "\\");

            var objClassList = from c in ctx.GetTable<ObjectClass>()
                               select c;

            Directory.GetFiles(this.path, "*.cs", SearchOption.AllDirectories).
                ToList().ForEach(f => File.Delete(f));

            foreach (ObjectClass objClass in objClassList)
            {
                GenerateObjectsClient(objClass);
                GenerateObjectsServer(objClass);
            }

            GenerateObjectSerializer(ClientServerEnum.Server, objClassList);
            GenerateObjectSerializer(ClientServerEnum.Client, objClassList);

            Console.WriteLine("...finished!");
        }

        #region Save / Helper
        private void SaveFile(CodeCompileUnit code, string fileName)
        {
            string path = Path.GetDirectoryName(fileName);
            Directory.CreateDirectory(path);

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            using (StreamWriter sourceWriter = new StreamWriter(fileName))
            {
                provider.GenerateCodeFromCompileUnit(
                    code, sourceWriter, options);
            }
        }

        private void AddDefaultNamespaces(CodeNamespace ns)
        {
            ns.Imports.Add(new CodeNamespaceImport("System"));
            ns.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            ns.Imports.Add(new CodeNamespaceImport("System.Linq"));
            ns.Imports.Add(new CodeNamespaceImport("System.Text"));
            ns.Imports.Add(new CodeNamespaceImport("System.Data.Objects"));
            ns.Imports.Add(new CodeNamespaceImport("System.Data.Objects.DataClasses"));
            ns.Imports.Add(new CodeNamespaceImport("System.Collections"));
            ns.Imports.Add(new CodeNamespaceImport("System.Xml"));
            ns.Imports.Add(new CodeNamespaceImport("System.Xml.Serialization"));
            ns.Imports.Add(new CodeNamespaceImport("Kistl.API"));
        }
        #endregion

        #region GenerateObjectSerializer
        private void GenerateObjectSerializer(ClientServerEnum clientServer, IQueryable<ObjectClass> objClassList)
        {
            CodeCompileUnit code = new CodeCompileUnit();

            // Create Namespace
            CodeNamespace ns = new CodeNamespace("Kistl.API");
            code.Namespaces.Add(ns);

            AddDefaultNamespaces(ns);

            // XMLObjectCollection
            CodeTypeDeclaration c = new CodeTypeDeclaration("XMLObjectCollection");
            ns.Types.Add(c);
            c.IsClass = true;
            c.BaseTypes.Add(new CodeTypeReference("IXmlObjectCollection"));
            c.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            c.CustomAttributes.Add(new CodeAttributeDeclaration("Serializable"));
            c.CustomAttributes.Add(new CodeAttributeDeclaration("XmlRoot", new CodeAttributeArgument("ElementName", new CodePrimitiveExpression("ObjectCollection"))));

            CodeMemberField f = new CodeMemberField(new CodeTypeReference("List", new CodeTypeReference("Object")), "_Objects");
            c.Members.Add(f);
            f.Attributes = MemberAttributes.Private;
            f.InitExpression = new CodeObjectCreateExpression(
                new CodeTypeReference("List", new CodeTypeReference("Object")));

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);
            p.Name = "Objects";
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.HasGet = true;
            p.HasSet = false;
            p.Type = f.Type;
            p.GetStatements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("_Objects")));
            foreach (ObjectClass objClass in objClassList)
            {
                p.CustomAttributes.Add(
                    new CodeAttributeDeclaration("XmlArrayItem",
                        new CodeAttributeArgument("Type", new CodeTypeOfExpression(objClass.Module.Namespace + "." + objClass.ClassName)),
                        new CodeAttributeArgument("ElementName", new CodePrimitiveExpression(objClass.ClassName))
                    ));
            }

            CodeMemberMethod m = new CodeMemberMethod();
            c.Members.Add(m);
            m.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            m.Name = "ToList";
            m.ReturnType = new CodeTypeReference("List", new CodeTypeReference("T"));
            CodeTypeParameter ct = new CodeTypeParameter("T");
            ct.Constraints.Add("IDataObject");
            m.TypeParameters.Add(ct);
            m.Statements.Add(new CodeSnippetExpression(@"return new List<T>(Objects.OfType<T>())"));

            // XMLObject
            c = new CodeTypeDeclaration("XMLObject");
            c.BaseTypes.Add(new CodeTypeReference("IXmlObject"));
            ns.Types.Add(c);
            c.IsClass = true;
            c.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            c.CustomAttributes.Add(new CodeAttributeDeclaration("Serializable"));
            c.CustomAttributes.Add(new CodeAttributeDeclaration("XmlRoot", new CodeAttributeArgument("ElementName", new CodePrimitiveExpression("Object"))));

            f = new CodeMemberField(new CodeTypeReference("Object"), "_Object");
            c.Members.Add(f);
            f.Attributes = MemberAttributes.Private;

            p = new CodeMemberProperty();
            c.Members.Add(p);
            p.Name = "Object";
            p.Type = new CodeTypeReference("Object");
            p.HasGet = true;
            p.HasSet = true;
            p.GetStatements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("_Object")));
            p.SetStatements.Add(new CodeAssignStatement(new CodeVariableReferenceExpression("_Object"), new CodePropertySetValueReferenceExpression()));
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            foreach (ObjectClass objClass in objClassList)
            {
                p.CustomAttributes.Add(
                    new CodeAttributeDeclaration("XmlElement",
                        new CodeAttributeArgument("Type", new CodeTypeOfExpression(objClass.Module.Namespace + "." + objClass.ClassName)),
                        new CodeAttributeArgument("ElementName", new CodePrimitiveExpression(objClass.ClassName))
                    ));
            }


            // Generate the code & save
            SaveFile(code, path + string.Format(@"Kistl.Objects.{0}\ObjectSerializer.cs", clientServer));
        }
        #endregion

        #region GenerateObjectsClient/Server
        private void GenerateObjectsClient(ObjectClass objClass)
        {
            CodeCompileUnit code = new CodeCompileUnit();

            // Create Namespace
            CodeNamespace ns = new CodeNamespace(objClass.Module.Namespace);
            code.Namespaces.Add(ns);

            AddDefaultNamespaces(ns);
            ns.Imports.Add(new CodeNamespaceImport("Kistl.API.Client"));

            GenerateClientDataObjects(code, ns, objClass);
            GenerateClientAccessLayer(objClass, ns);

            // Generate the code & save
            SaveFile(code, path + @"Kistl.Objects.Client\" + objClass.ClassName + ".Client.Designer.cs");
        }

        private void GenerateObjectsServer(ObjectClass objClass)
        {
            CodeCompileUnit code = new CodeCompileUnit();

            // Create Namespace
            CodeNamespace ns = new CodeNamespace(objClass.Module.Namespace);
            code.Namespaces.Add(ns);

            AddDefaultNamespaces(ns);
            ns.Imports.Add(new CodeNamespaceImport("Kistl.API.Server"));

            GenerateServerDataObjects(code, ns, objClass);
            GenerateServerAccessLayer(objClass, ns);

            // Generate the code & save
            SaveFile(code, path + @"Kistl.Objects.Server\" + objClass.ClassName + ".Server.Designer.cs");
        }

        private void GenerateServerAccessLayer(ObjectClass objClass, CodeNamespace ns)
        {
            CodeTypeDeclaration c = new CodeTypeDeclaration(objClass.ClassName + "Server");
            ns.Types.Add(c);
            c.IsClass = true;
            c.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            c.BaseTypes.Add(new CodeTypeReference("ServerObject", 
                new CodeTypeReference(objClass.ClassName), 
                new CodeTypeReference("XMLObjectCollection"), 
                new CodeTypeReference("XMLObject")));
        }

        private void GenerateClientAccessLayer(ObjectClass objClass, CodeNamespace ns)
        {
            CodeTypeDeclaration c = new CodeTypeDeclaration(objClass.ClassName + "Client");
            ns.Types.Add(c);
            c.IsClass = true;
            c.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            c.BaseTypes.Add(new CodeTypeReference("ClientObject", 
                new CodeTypeReference(objClass.ClassName),
                new CodeTypeReference("XMLObjectCollection"),
                new CodeTypeReference("XMLObject")));

            // Create GetListOf Methods
            foreach (BackReferenceProperty prop in objClass.Properties.OfType<BackReferenceProperty>())
            {
                CodeMemberMethod m = new CodeMemberMethod();
                c.Members.Add(m);
                m.Comments.Add(new CodeCommentStatement("Autogeneriert, um die gebundenen Listen zu bekommen"));

                m.Name = "GetListOf" + prop.PropertyName;
                m.Attributes = MemberAttributes.Public | MemberAttributes.Final;
                m.ReturnType = new CodeTypeReference("List", new CodeTypeReference(prop.GetDataType()));
                m.Parameters.Add(new CodeParameterDeclarationExpression(
                    new CodeTypeReference(typeof(int)), "ID"));
                m.Statements.Add(new CodeSnippetExpression(string.Format(
                        @"return Proxy.Service.GetListOf(Type, ID, ""{0}"").FromXmlString<XMLObjectCollection>().ToList<{1}>()",
                    prop.PropertyName, prop.GetDataType())));
            }
        }

        #endregion

        #region Generate Client/Server Data Objects
        private void GenerateServerDataObjects(CodeCompileUnit code, CodeNamespace ns, ObjectClass objClass)
        {
            GenerateEdmRelationshipAttribute(objClass, code);
            
            // Create Class
            CodeTypeDeclaration c = new CodeTypeDeclaration(objClass.ClassName);
            ns.Types.Add(c);
            c.IsClass = true;
            c.TypeAttributes = TypeAttributes.Public;
            if (objClass.BaseObjectClass != null)
            {
                c.BaseTypes.Add(objClass.BaseObjectClass.Module.Namespace + "." + objClass.BaseObjectClass.ClassName);
            }
            else
            {
                c.BaseTypes.Add("BaseServerDataObject");
            }
            c.CustomAttributes.Add(new CodeAttributeDeclaration("EdmEntityTypeAttribute",
                new CodeAttributeArgument("NamespaceName", 
                    new CodePrimitiveExpression("Model")),
                new CodeAttributeArgument("Name", 
                    new CodePrimitiveExpression(objClass.ClassName)) ));

            if (objClass.BaseObjectClass == null)
            {
                // Create Default Properties
                GenerateServerDefaultProperties(objClass, c);
            }

            // Create Properties
            GenerateServerProperties(objClass, c);

            // Create DataObject Default Methods
            GenerateDefaultMethods(objClass, c);

            // Create DataObject Methods
            GenerateMethods(objClass, c);
        }

        private void GenerateClientDataObjects(CodeCompileUnit code, CodeNamespace ns, ObjectClass objClass)
        {
            // Create Class
            CodeTypeDeclaration c = new CodeTypeDeclaration(objClass.ClassName);
            ns.Types.Add(c);
            c.IsClass = true;
            c.TypeAttributes = TypeAttributes.Public;
            if (objClass.BaseObjectClass != null)
            {
                c.BaseTypes.Add(objClass.BaseObjectClass.Module.Namespace + "." + objClass.BaseObjectClass.ClassName);
            }
            else
            {
                c.BaseTypes.Add("BaseClientDataObject");
            }

            if (objClass.BaseObjectClass == null)
            {
                // Create Default Properties
                GenerateClientDefaultProperties(objClass, c);
            }

            // Create Properties
            GenerateClientProperties(objClass, c);

            // Create DataObject Default Methods
            GenerateDefaultMethods(objClass, c);

            // Create DataObject Methods
            GenerateMethods(objClass, c);
        }

        #region GenerateEdmRelationshipAttribute
        private void GenerateEdmRelationshipAttribute(ObjectClass objClass, CodeCompileUnit code)
        {
            var props = objClass.Properties.OfType<ObjectReferenceProperty>();

            foreach (ObjectReferenceProperty prop in props)
            {
                string associationPropName = prop.PropertyName.Replace("fk_", "");
                ObjectType otherType = new ObjectType(prop.GetDataType());
                string assocName = "FK_" + objClass.ClassName + "_" + otherType.Classname;

                code.AssemblyCustomAttributes.Add(new CodeAttributeDeclaration("System.Data.Objects.DataClasses.EdmRelationshipAttribute",
                new CodeAttributeArgument(
                    new CodePrimitiveExpression("Model")),
                new CodeAttributeArgument(
                    new CodePrimitiveExpression(assocName)),
                new CodeAttributeArgument(
                    new CodePrimitiveExpression("A_" + otherType.Classname)),
                new CodeAttributeArgument(
                    new CodeSnippetExpression("System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne")),
                new CodeAttributeArgument(
                    new CodeTypeOfExpression(prop.GetDataType())),
                new CodeAttributeArgument(
                    new CodePrimitiveExpression("B_" + prop.ObjectClass.ClassName)),
                new CodeAttributeArgument(
                    new CodeSnippetExpression("System.Data.Metadata.Edm.RelationshipMultiplicity.Many")),
                new CodeAttributeArgument(
                    new CodeTypeOfExpression(prop.ObjectClass.Module.Namespace + "." + prop.ObjectClass.ClassName))
                    ));
            }
        }
        #endregion

        #region GenerateServerDefaultProperties
        private void GenerateServerDefaultProperties(ObjectClass objClass, CodeTypeDeclaration c)
        {
            // Create ID member
            CodeMemberField f = new CodeMemberField(typeof(int), "_ID");
            f.InitExpression = new CodeSnippetExpression("Helper.INVALIDID"); // TODO: Das ist c# Spezifisch
            c.Members.Add(f);

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = "ID";
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            p.Type = new CodeTypeReference(typeof(int));
            p.CustomAttributes.Add(new CodeAttributeDeclaration("EdmScalarPropertyAttribute",
                new CodeAttributeArgument("EntityKeyProperty",
                    new CodePrimitiveExpression(true)),
                new CodeAttributeArgument("IsNullable",
                    new CodePrimitiveExpression(false)) ));

            p.GetStatements.Add(new CodeMethodReturnStatement(new CodeSnippetExpression("_ID")));
            p.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_ID"), new CodePropertySetValueReferenceExpression()));

            p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = "EntitySetName";
            p.HasGet = true;
            p.HasSet = false;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            p.Type = new CodeTypeReference(typeof(string));
            p.GetStatements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression(objClass.ClassName)));
        }
        #endregion

        #region GenerateClientDefaultProperties
        private void GenerateClientDefaultProperties(ObjectClass objClass, CodeTypeDeclaration c)
        {
            // Create ID member
            CodeMemberField f = new CodeMemberField(typeof(int), "_ID");
            f.InitExpression = new CodeSnippetExpression("Helper.INVALIDID"); // TODO: Das ist c# Spezifisch
            c.Members.Add(f);

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = "ID";
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            p.Type = new CodeTypeReference(typeof(int));

            p.GetStatements.Add(new CodeMethodReturnStatement(new CodeSnippetExpression("_ID")));
            p.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_ID"), new CodePropertySetValueReferenceExpression()));
        }
        #endregion

        #region GenerateMethods
        private void GenerateMethods(ObjectClass objClass, CodeTypeDeclaration c)
        {
            ObjectClass baseObjClass = objClass;
            while (objClass != null)
            {
                foreach (Method method in objClass.Methods)
                {
                    if (objClass == baseObjClass)
                    {
                        // Create Delegate
                        // HACK!!! Die TypeParameter scheinen nicht zu funktionieren
                        CodeTypeDelegate d = new CodeTypeDelegate(method.MethodName + "_Handler<T>");

                        c.Members.Add(d);
                        d.Attributes = MemberAttributes.Public;

                        // HACK!!! Die TypeParameter scheinen nicht zu funktionieren
                        CodeTypeParameter ct = new CodeTypeParameter("T");
                        ct.Constraints.Add(new CodeTypeReference("IDataObject"));
                        d.TypeParameters.Add(ct);
                        // HACK!!! Die TypeParameter scheinen nicht zu funktionieren


                        d.Parameters.Add(new CodeParameterDeclarationExpression("T", "obj"));
                        d.Parameters.Add(new CodeParameterDeclarationExpression(
                            new CodeTypeReference("MethodReturnEventArgs", new CodeTypeReference(typeof(string))),
                            "e"));
                    }

                    // Create event
                    CodeMemberEvent e = new CodeMemberEvent();
                    c.Members.Add(e);

                    e.Attributes = MemberAttributes.Public;
                    e.Type = new CodeTypeReference(method.MethodName + "_Handler",
                        new CodeTypeReference(baseObjClass.ClassName));
                    e.Name = "On" + method.MethodName + "_" + baseObjClass.ClassName;

                    // Create Method
                    CodeMemberMethod m = new CodeMemberMethod();
                    c.Members.Add(m);
                    m.Name = method.MethodName;
                    m.Attributes = (objClass == baseObjClass) ? (MemberAttributes.Public) : (MemberAttributes.Public | MemberAttributes.Override);
                    m.ReturnType = new CodeTypeReference(typeof(string));

                    if (objClass == baseObjClass)
                    {
                        m.Statements.Add(new CodeSnippetExpression(string.Format(@"MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            if (On{1}_{0} != null)
            {{
                On{1}_{0}(this, e);
            }}
            return e.Result", baseObjClass.ClassName, method.MethodName)));// TODO: Das ist C# spezifisch
                    }
                    else
                    {
                        m.Statements.Add(new CodeSnippetExpression(string.Format(@"MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.{1}();
            if (On{1}_{0} != null)
            {{
                On{1}_{0}(this, e);
            }}
            return e.Result", baseObjClass.ClassName, method.MethodName)));// TODO: Das ist C# spezifisch
                    }
                }

                // Nächster bitte
                objClass = objClass.BaseObjectClass;
            }

        }
        #endregion

        #region GenerateDefaultMethods
        private void GenerateDefaultMethods(ObjectClass objClass, CodeTypeDeclaration c)
        {
            // Create ToString Delegate
            CodeMemberEvent e = new CodeMemberEvent();
            c.Members.Add(e);

            e.Attributes = MemberAttributes.Public;
            e.Type = new CodeTypeReference("ToStringHandler", new CodeTypeReference(objClass.ClassName));
            e.Name = "OnToString_" + objClass.ClassName;

            // Create PreSave Delegate
            e = new CodeMemberEvent();
            c.Members.Add(e);

            e.Attributes = MemberAttributes.Public;
            e.Type = new CodeTypeReference("ObjectEventHandler", new CodeTypeReference(objClass.ClassName));
            e.Name = "OnPreSave_" + objClass.ClassName;

            // Create PostSave Delegate
            e = new CodeMemberEvent();
            c.Members.Add(e);

            e.Attributes = MemberAttributes.Public;
            e.Type = new CodeTypeReference("ObjectEventHandler", new CodeTypeReference(objClass.ClassName));
            e.Name = "OnPostSave_" + objClass.ClassName;

            // Create ToString Method
            CodeMemberMethod m = new CodeMemberMethod();
            c.Members.Add(m);
            m.Name = "ToString";
            m.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            m.ReturnType = new CodeTypeReference(typeof(string));
            m.Statements.Add(new CodeSnippetExpression(string.Format(@"MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_{0} != null)
            {{
                OnToString_{0}(this, e);
            }}
            return e.Result", objClass.ClassName)));// TODO: Das ist C# spezifisch

            // Create NotifyPreSave Method
            m = new CodeMemberMethod();
            c.Members.Add(m);
            m.Name = "NotifyPreSave";
            m.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            m.ReturnType = new CodeTypeReference(typeof(void));
            m.Statements.Add(new CodeSnippetExpression(string.Format(@"base.NotifyPreSave();
            if (OnPreSave_{0} != null) OnPreSave_{0}(this)", objClass.ClassName)));// TODO: Das ist C# spezifisch

            // Create NotifyPostSave Method
            m = new CodeMemberMethod();
            c.Members.Add(m);
            m.Name = "NotifyPostSave";
            m.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            m.ReturnType = new CodeTypeReference(typeof(void));
            m.Statements.Add(new CodeSnippetExpression(string.Format(@"base.NotifyPostSave();
            if (OnPostSave_{0} != null) OnPostSave_{0}(this)",objClass.ClassName)));// TODO: Das ist C# spezifisch

        }
        #endregion

        #region GenerateServerProperties

        #region GenerateValueTypeProperty
        private void GenerateServerValueTypeProperty(ObjectClass objClass, ValueTypeProperty prop, CodeTypeDeclaration c)
        {
            CodeMemberField f = null;
            CodeTypeReference ctr = null;

            if (string.IsNullOrEmpty(prop.GetDataType())) throw new ApplicationException(
                 string.Format("ValueProperty {0}.{1} has an empty Datatype! Please implement BaseProperty.GetDataType()",
                     objClass.ClassName, prop.PropertyName, prop.GetDataType()));

            Type t = Type.GetType(prop.GetDataType());
            if(t == null) throw new ApplicationException(
                string.Format("ValueProperty {0}.{1} has a invalid Datatype of {2}", 
                    objClass.ClassName, prop.PropertyName, prop.GetDataType()));
            
            if (t.IsValueType)
            {
                ctr = new CodeTypeReference("System.Nullable", new CodeTypeReference(prop.GetDataType()));
            }
            else
            {
                // String etc.
                ctr = new CodeTypeReference(prop.GetDataType());
            }
            f = new CodeMemberField(ctr, 
                "_" + prop.PropertyName);

            c.Members.Add(f);

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = prop.PropertyName;
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = f.Type;
            p.CustomAttributes.Add(new CodeAttributeDeclaration("EdmScalarPropertyAttribute"));

            p.GetStatements.Add(new CodeMethodReturnStatement(new CodeSnippetExpression("_" + prop.PropertyName)));
            p.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_" + prop.PropertyName), new CodePropertySetValueReferenceExpression()));
        }
        #endregion

        #region GenerateObjectReferenceProperty
        private void GenerateServerObjectReferenceProperty(ObjectClass objClass, ObjectReferenceProperty prop, CodeTypeDeclaration c)
        {
            // Check if Datatype exits
            if (ctx.GetTable<ObjectClass>().ToList().First(o => o.Module.Namespace + "." + o.ClassName == prop.GetDataType()) == null)
                throw new ApplicationException(string.Format("ObjectReference {0} not found on ObjectReferenceProperty {1}.{2}", 
                    prop.GetDataType(), objClass.ClassName, prop.PropertyName));

            string associationPropName = prop.PropertyName.Replace("fk_", "");

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = associationPropName;
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = new CodeTypeReference(prop.GetDataType());

            ObjectType otherType = new ObjectType(prop.GetDataType());
            string assocName = "FK_" + objClass.ClassName + "_" + otherType.Classname;

            p.CustomAttributes.Add(new CodeAttributeDeclaration(
                "EdmRelationshipNavigationPropertyAttribute",
                new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                new CodeAttributeArgument(new CodePrimitiveExpression(assocName)),
                new CodeAttributeArgument(new CodePrimitiveExpression("A_" + otherType.Classname))));
            p.CustomAttributes.Add(new CodeAttributeDeclaration("XmlIgnore"));


            p.GetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value", prop.GetDataType(), assocName, otherType.Classname)));

            p.SetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"EntityReference<{0}> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<{0}>(""Model.{1}"", ""A_{2}"");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value", prop.GetDataType(), assocName, otherType.Classname)));

            // Serializer fk_ Field und Property
            CodeMemberField f = new CodeMemberField(typeof(int), "_" + prop.PropertyName);
            f.InitExpression = new CodeSnippetExpression("Helper.INVALIDID"); // TODO: Das ist c# Spezifisch
            c.Members.Add(f);

            p = new CodeMemberProperty();
            c.Members.Add(p);
            p.Name = prop.PropertyName;
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = new CodeTypeReference(typeof(int));

            p.GetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_{0} == Helper.INVALIDID && {0} != null)
                {{
                    _fk_{0} = {0}.ID;
                }}
                return _fk_{0}", associationPropName)));
            p.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_" + prop.PropertyName), new CodePropertySetValueReferenceExpression()));
        }
        #endregion

        #region GenerateBackReferenceProperty
        private void GenerateServerBackReferenceProperty(ObjectClass objClass, BackReferenceProperty prop, CodeTypeDeclaration c)
        {
            // Check if Datatype exits
            if (ctx.GetTable<ObjectClass>().ToList().First(o => o.Module.Namespace + "." + o.ClassName == prop.GetDataType()) == null)
                throw new ApplicationException(string.Format("ObjectReference {0} not found on BackReferenceProperty {1}.{2}",
                    prop.GetDataType(), objClass.ClassName, prop.PropertyName));

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = prop.PropertyName;
            p.HasGet = true;
            p.HasSet = false;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = new CodeTypeReference("EntityCollection", new CodeTypeReference(prop.GetDataType()));

            ObjectType otherType = new ObjectType(prop.GetDataType());
            string assocName = "FK_" + otherType.Classname + "_" + objClass.ClassName;

            p.CustomAttributes.Add(new CodeAttributeDeclaration(
                "EdmRelationshipNavigationPropertyAttribute",
                new CodeAttributeArgument(new CodePrimitiveExpression("Model")),
                new CodeAttributeArgument(new CodePrimitiveExpression(assocName)),
                new CodeAttributeArgument(new CodePrimitiveExpression("B_" + otherType.Classname))));
            p.CustomAttributes.Add(new CodeAttributeDeclaration("XmlIgnore"));


            p.GetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"EntityCollection<{0}> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<{0}>(""Model.{1}"", ""B_{2}"");
                if (!c.IsLoaded) c.Load(); 
                return c", prop.GetDataType(), assocName, otherType.Classname)));
        }
        #endregion

        private void GenerateServerProperties(ObjectClass objClass, CodeTypeDeclaration c)
        {
            foreach (BaseProperty baseProp in objClass.Properties)
            {
                if (baseProp is ValueTypeProperty)
                {
                    // Simple Property
                    GenerateServerValueTypeProperty(objClass, (ValueTypeProperty)baseProp, c);
                }
                else if (baseProp is ObjectReferenceProperty)
                {
                    // "pointer" zum Vater Objekt
                    GenerateServerObjectReferenceProperty(objClass, (ObjectReferenceProperty)baseProp, c);
                }
                else if (baseProp is BackReferenceProperty)
                {
                    // TODO: Das ist eigentlich falsch herum, das sollte generiert werden,
                    // wenn bei der referenzierenden Klasse ein FK eingetragen wurde.
                    // Das sind quasi "AutoProperties"
                    GenerateServerBackReferenceProperty(objClass, (BackReferenceProperty)baseProp, c);
                }
                else
                {
                    // not supported yet
                    // just ignore it for now
                    throw new ApplicationException("Unknonw Propertytype " + baseProp.GetType().Name);
                }
            }
        }
        #endregion

        #region GenerateClientProperties

        #region GenerateValueTypeProperty
        private void GenerateClientValueTypeProperty(ObjectClass objClass, ValueTypeProperty prop, CodeTypeDeclaration c)
        {
            CodeMemberField f = null;
            CodeTypeReference ctr = null;

            if (string.IsNullOrEmpty(prop.GetDataType())) throw new ApplicationException(
                 string.Format("ValueProperty {0}.{1} has an empty Datatype! Please implement BaseProperty.GetDataType()",
                     objClass.ClassName, prop.PropertyName, prop.GetDataType()));

            Type t = Type.GetType(prop.GetDataType());
            if (t == null) throw new ApplicationException(
                 string.Format("ValueProperty {0}.{1} has a invalid Datatype of {2}",
                     objClass.ClassName, prop.PropertyName, prop.GetDataType()));

            if (t.IsValueType)
            {
                ctr = new CodeTypeReference("System.Nullable", new CodeTypeReference(prop.GetDataType()));
            }
            else
            {
                // String etc.
                ctr = new CodeTypeReference(prop.GetDataType());
            }
            f = new CodeMemberField(ctr,
                "_" + prop.PropertyName);

            c.Members.Add(f);

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = prop.PropertyName;
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = f.Type;

            p.GetStatements.Add(new CodeMethodReturnStatement(new CodeSnippetExpression("_" + prop.PropertyName)));
            p.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_" + prop.PropertyName), new CodePropertySetValueReferenceExpression()));
        }
        #endregion

        #region GenerateObjectReferenceProperty
        private void GenerateClientObjectReferenceProperty(ObjectClass objClass, ObjectReferenceProperty prop, CodeTypeDeclaration c)
        {
            // Check if Datatype exits
            if (ctx.GetTable<ObjectClass>().ToList().First(o => o.Module.Namespace + "." + o.ClassName == prop.GetDataType()) == null)
                throw new ApplicationException(string.Format("ObjectReference {0} not found on ObjectReferenceProperty {1}.{2}",
                    prop.GetDataType(), objClass.ClassName, prop.PropertyName));

            string associationPropName = prop.PropertyName.Replace("fk_", "");

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = associationPropName;
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = new CodeTypeReference(prop.GetDataType());

            ObjectType otherType = new ObjectType(prop.GetDataType());
            string assocName = "FK_" + objClass.ClassName + "_" + otherType.Classname;

            p.CustomAttributes.Add(new CodeAttributeDeclaration("XmlIgnore"));


            p.GetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"return this.GetObject<{0}>({1})", prop.GetDataType(), prop.PropertyName)));

            p.SetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"_{0} = value.ID", prop.PropertyName)));

            // Serializer fk_ Field und Property
            CodeMemberField f = new CodeMemberField(typeof(int), "_" + prop.PropertyName);
            f.InitExpression = new CodeSnippetExpression("Helper.INVALIDID"); // TODO: Das ist c# Spezifisch
            c.Members.Add(f);

            p = new CodeMemberProperty();
            c.Members.Add(p);
            p.Name = prop.PropertyName;
            p.HasGet = true;
            p.HasSet = true;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = new CodeTypeReference(typeof(int));

            p.GetStatements.Add(
                new CodeSnippetExpression(
                    string.Format(@"return _fk_{0}", associationPropName)));
            p.SetStatements.Add(new CodeAssignStatement(new CodeSnippetExpression("_" + prop.PropertyName), new CodePropertySetValueReferenceExpression()));
        }
        #endregion

        #region GenerateBackReferenceProperty
        private void GenerateClientBackReferenceProperty(ObjectClass objClass, BackReferenceProperty prop, CodeTypeDeclaration c)
        {
            // Check if Datatype exits
            if (ctx.GetTable<ObjectClass>().ToList().First(o => o.Module.Namespace + "." + o.ClassName == prop.GetDataType()) == null)
                throw new ApplicationException(string.Format("ObjectReference {0} not found on BackReferenceProperty {1}.{2}",
                    prop.GetDataType(), objClass.ClassName, prop.PropertyName));

            CodeMemberProperty p = new CodeMemberProperty();
            c.Members.Add(p);

            p.Name = prop.PropertyName;
            p.HasGet = true;
            p.HasSet = false;
            p.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            p.Type = new CodeTypeReference("List", new CodeTypeReference(prop.GetDataType()));

            ObjectType otherType = new ObjectType(prop.GetDataType());
            string assocName = "FK_" + otherType.Classname + "_" + objClass.ClassName;

            p.CustomAttributes.Add(new CodeAttributeDeclaration("XmlIgnore"));

            p.GetStatements.Add(
                new CodeSnippetExpression(string.Format(
                    @"return Proxy.Service.GetListOf(Type, ID, ""{0}"").FromXmlString<XMLObjectCollection>().ToList<{1}>()",
                prop.PropertyName, prop.GetDataType())));
        }
        #endregion

        private void GenerateClientProperties(ObjectClass objClass, CodeTypeDeclaration c)
        {
            foreach (BaseProperty baseProp in objClass.Properties)
            {
                if (baseProp is ValueTypeProperty)
                {
                    // Simple Property
                    GenerateClientValueTypeProperty(objClass, (ValueTypeProperty)baseProp, c);
                }
                else if (baseProp is ObjectReferenceProperty)
                {
                    // "pointer" zum Vater Objekt
                    GenerateClientObjectReferenceProperty(objClass, (ObjectReferenceProperty)baseProp, c);
                }
                else if (baseProp is BackReferenceProperty)
                {
                    // TODO: Das ist eigentlich falsch herum, das sollte generiert werden,
                    // wenn bei der referenzierenden Klasse ein FK eingetragen wurde.
                    // Das sind quasi "AutoProperties"
                    GenerateClientBackReferenceProperty(objClass, (BackReferenceProperty)baseProp, c);
                }
                else
                {
                    // not supported yet
                    // just ignore it for now
                    throw new ApplicationException("Unknonw Propertytype " + baseProp.GetType().Name);
                }
            }
        }
        #endregion

        #endregion
    }
}
