using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.App.Base;
using Kistl.API;

namespace Kistl.Server
{
    public class EntityFrameworkModelGenerator
    {
        private string path = "";
        private Kistl.API.Server.KistlDataContext ctx = null;

        public void Generate(Kistl.API.Server.KistlDataContext ctx, string path)
        {
            Console.WriteLine("Generating EF-Model...");

            this.path = path + (path.EndsWith("\\") ? "" : "\\");
            this.ctx = ctx;

            IQueryable<ObjectClass> objClassList = from c in ctx.GetTable<ObjectClass>()
                                              select c;
            GenerateSSDL(objClassList);
            GenerateCSDL(objClassList);
            GenerateMSL(objClassList);

            Console.WriteLine("...finished!");
        }

        #region GenerateSSDL
        public void GenerateSSDL(IQueryable<ObjectClass> objClassList)
        {
            using (System.Xml.XmlTextWriter xml = new System.Xml.XmlTextWriter(path + @"Kistl.Objects\Model.ssdl", Encoding.UTF8))
            {
                xml.Indentation = 2;
                xml.IndentChar = ' ';
                xml.Formatting = System.Xml.Formatting.Indented;

                // Maintag
                xml.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-8\"");
                xml.WriteStartElement("Schema");
                xml.WriteAttributeString("Namespace", "Model.Store");
                xml.WriteAttributeString("Alias", "Self");
                xml.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ado/2006/04/edm/ssdl");

                // Write EntityContainer
                xml.WriteStartElement("EntityContainer");
                xml.WriteAttributeString("Name", "dbo");

                foreach (ObjectClass obj in objClassList)
                {
                    xml.WriteStartElement("EntitySet");
                    xml.WriteAttributeString("Name", obj.ClassName);
                    xml.WriteAttributeString("EntityType", "Model.Store." + obj.ClassName);
                    xml.WriteAttributeString("Table", obj.TableName);
                    xml.WriteEndElement(); // </EntitySet>
                }

                var assocProperties = from p in ctx.GetTable<ObjectProperty>()
                                      from o in objClassList
                                      where p.ObjectClass.ID == o.ID
                                            && p.IsAssociation.Value
                                            && !p.IsList.Value
                                      select p;

                foreach (ObjectProperty prop in assocProperties)
                {
                    xml.WriteStartElement("AssociationSet");
                    ObjectType otherType = new ObjectType(prop.DataType);
                    string assocName = "FK_" + prop.ObjectClass.ClassName + "_" + otherType.Classname;
                    xml.WriteAttributeString("Name", assocName);
                    xml.WriteAttributeString("Association", "Model.Store." + assocName);

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", otherType.Classname);
                    xml.WriteAttributeString("EntitySet", otherType.Classname);
                    xml.WriteEndElement(); // </End>

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", prop.ObjectClass.ClassName);
                    xml.WriteAttributeString("EntitySet", prop.ObjectClass.ClassName);
                    xml.WriteEndElement(); // </End>

                    xml.WriteEndElement(); // </AssociationSet>
                }


                xml.WriteEndElement(); // </EntityContainer>

                foreach (ObjectClass obj in objClassList)
                {
                    xml.WriteStartElement("EntityType");
                    xml.WriteAttributeString("Name", obj.ClassName);

                    xml.WriteStartElement("Key");
                    xml.WriteStartElement("PropertyRef");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteEndElement(); // </PropertyRef>
                    xml.WriteEndElement(); // </Key>

                    xml.WriteStartElement("Property");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteAttributeString("Type", "int");
                    xml.WriteAttributeString("Nullable", "false");
                    xml.WriteAttributeString("StoreGeneratedPattern", "identity");
                    xml.WriteEndElement(); // </Property>

                    foreach (ObjectProperty p in obj.Properties)
                    {
                        if (p.IsList.Value) continue;

                        xml.WriteStartElement("Property");
                        xml.WriteAttributeString("Name", p.PropertyName);
                        xml.WriteAttributeString("Type", p.IsAssociation.Value ? "int" : GetDBType(p.DataType));
                        if (p.DataType == "System.String")
                        {
                            xml.WriteAttributeString("MaxLength", "200");
                        }
                        xml.WriteAttributeString("Nullable", "true");
                        xml.WriteEndElement(); // </Property>
                    }

                    xml.WriteEndElement(); // </EntityType>
                }

                foreach (ObjectProperty prop in assocProperties)
                {
                    xml.WriteStartElement("Association");
                    ObjectType otherType = new ObjectType(prop.DataType);
                    string assocName = "FK_" + prop.ObjectClass.ClassName + "_" + otherType.Classname;
                    xml.WriteAttributeString("Name", assocName);

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", otherType.Classname);
                    xml.WriteAttributeString("Type", "Model.Store." + otherType.Classname);
                    xml.WriteAttributeString("Multiplicity", "0..1");
                    xml.WriteEndElement(); // </End>

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", prop.ObjectClass.ClassName);
                    xml.WriteAttributeString("Type", "Model.Store." + prop.ObjectClass.ClassName);
                    xml.WriteAttributeString("Multiplicity", "*");
                    xml.WriteEndElement(); // </End>

                    xml.WriteStartElement("ReferentialConstraint");

                    xml.WriteStartElement("Principal");
                    xml.WriteAttributeString("Role", otherType.Classname);
                    xml.WriteStartElement("PropertyRef");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteEndElement(); // </PropertyRef>
                    xml.WriteEndElement(); // </Principal>

                    xml.WriteStartElement("Dependent");
                    xml.WriteAttributeString("Role", prop.ObjectClass.ClassName);
                    xml.WriteStartElement("PropertyRef");
                    xml.WriteAttributeString("Name", prop.PropertyName);
                    xml.WriteEndElement(); // </PropertyRef>
                    xml.WriteEndElement(); // </Dependent>

                    xml.WriteEndElement(); // </ReferentialConstraint>

                    xml.WriteEndElement(); // </AssociationSet>
                }

                xml.WriteEndElement(); // </Schema>
            }
        }
        #endregion

        #region GenerateCSDL
        public void GenerateCSDL(IQueryable<ObjectClass> objClassList)
        {
            using (System.Xml.XmlTextWriter xml = new System.Xml.XmlTextWriter(path + @"Kistl.Objects\Model.csdl", Encoding.UTF8))
            {
                xml.Indentation = 2;
                xml.IndentChar = ' ';
                xml.Formatting = System.Xml.Formatting.Indented;

                // Maintag
                xml.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-8\"");
                xml.WriteStartElement("Schema");
                xml.WriteAttributeString("Namespace", "Model");
                xml.WriteAttributeString("Alias", "Self");
                xml.WriteAttributeString("xmlns", "http://schemas.microsoft.com/ado/2006/04/edm");

                // Write EntityContainer
                xml.WriteStartElement("EntityContainer");
                xml.WriteAttributeString("Name", "Entities");

                foreach (ObjectClass obj in objClassList)
                {
                    xml.WriteStartElement("EntitySet");
                    xml.WriteAttributeString("Name", obj.ClassName);
                    xml.WriteAttributeString("EntityType", "Model." + obj.ClassName);
                    xml.WriteEndElement(); // </EntitySet>
                }

                var assocProperties = from p in ctx.GetTable<ObjectProperty>()
                                      from o in objClassList
                                      where p.ObjectClass.ID == o.ID
                                            && p.IsAssociation.Value 
                                            && !p.IsList.Value
                                      select p;

                foreach (ObjectProperty prop in assocProperties)
                {
                    xml.WriteStartElement("AssociationSet");
                    ObjectType otherType = new ObjectType(prop.DataType);
                    string assocName = "FK_" + prop.ObjectClass.ClassName + "_" + otherType.Classname;
                    xml.WriteAttributeString("Name", assocName);
                    xml.WriteAttributeString("Association", "Model." + assocName);

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", otherType.Classname);
                    xml.WriteAttributeString("EntitySet", otherType.Classname);
                    xml.WriteEndElement(); // </End>

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", prop.ObjectClass.ClassName);
                    xml.WriteAttributeString("EntitySet", prop.ObjectClass.ClassName);
                    xml.WriteEndElement(); // </End>

                    xml.WriteEndElement(); // </AssociationSet>
                }

                xml.WriteEndElement(); // </EntityContainer>

                foreach (ObjectClass obj in objClassList)
                {
                    xml.WriteStartElement("EntityType");
                    xml.WriteAttributeString("Name", obj.ClassName);

                    xml.WriteStartElement("Key");
                    xml.WriteStartElement("PropertyRef");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteEndElement(); // </PropertyRef>
                    xml.WriteEndElement(); // </Key>

                    xml.WriteStartElement("Property");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteAttributeString("Type", "Int32");
                    xml.WriteAttributeString("Nullable", "false");
                    xml.WriteEndElement(); // </Property>

                    foreach (ObjectProperty p in obj.Properties)
                    {
                        if (p.IsList.Value && p.IsAssociation.Value)
                        {
                            xml.WriteStartElement("NavigationProperty");
                            xml.WriteAttributeString("Name", p.PropertyName);
                            ObjectType otherType = new ObjectType(p.DataType);
                            string assocName = "FK_" + otherType.Classname + "_" + p.ObjectClass.ClassName;
                            xml.WriteAttributeString("Relationship", "Model." + assocName);
                            xml.WriteAttributeString("FromRole", obj.ClassName);
                            xml.WriteAttributeString("ToRole", otherType.Classname);
                            xml.WriteEndElement(); // </NavigationProperty>
                        }
                        else if (!p.IsList.Value && p.IsAssociation.Value)
                        {
                            xml.WriteStartElement("NavigationProperty");
                            xml.WriteAttributeString("Name", p.PropertyName.Replace("fk_", ""));
                            ObjectType otherType = new ObjectType(p.DataType);
                            string assocName = "FK_" + p.ObjectClass.ClassName + "_" + otherType.Classname;
                            xml.WriteAttributeString("Relationship", "Model." + assocName);
                            xml.WriteAttributeString("FromRole", obj.ClassName);
                            xml.WriteAttributeString("ToRole", otherType.Classname);
                            xml.WriteEndElement(); // </NavigationProperty>
                        }
                        else if (!p.IsList.Value && !p.IsAssociation.Value)
                        {
                            xml.WriteStartElement("Property");
                            xml.WriteAttributeString("Name", p.PropertyName);
                            xml.WriteAttributeString("Type", Type.GetType(p.DataType).Name);
                            if (p.DataType == "System.String")
                            {
                                xml.WriteAttributeString("MaxLength", "200");
                            }
                            xml.WriteAttributeString("Nullable", "true");
                            xml.WriteEndElement(); // </Property>
                        }
                    }

                    xml.WriteEndElement(); // </EntityType>
                }

                foreach (ObjectProperty prop in assocProperties)
                {
                    xml.WriteStartElement("Association");
                    ObjectType otherType = new ObjectType(prop.DataType);
                    string assocName = "FK_" + prop.ObjectClass.ClassName + "_" + otherType.Classname;
                    xml.WriteAttributeString("Name", assocName);

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", otherType.Classname);
                    xml.WriteAttributeString("Type", "Model." + otherType.Classname);
                    xml.WriteAttributeString("Multiplicity", "0..1");
                    xml.WriteEndElement(); // </End>

                    xml.WriteStartElement("End");
                    xml.WriteAttributeString("Role", prop.ObjectClass.ClassName);
                    xml.WriteAttributeString("Type", "Model." + prop.ObjectClass.ClassName);
                    xml.WriteAttributeString("Multiplicity", "*");
                    xml.WriteEndElement(); // </End>

                    xml.WriteEndElement(); // </AssociationSet>
                }

                xml.WriteEndElement(); // </Schema>
            }
        }
        #endregion

        #region GenerateMSL
        public void GenerateMSL(IQueryable<ObjectClass> objClassList)
        {
            using (System.Xml.XmlTextWriter xml = new System.Xml.XmlTextWriter(path + @"Kistl.Objects\Model.msl", Encoding.UTF8))
            {
                xml.Indentation = 2;
                xml.IndentChar = ' ';
                xml.Formatting = System.Xml.Formatting.Indented;

                // Maintag
                xml.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"utf-8\"");
                xml.WriteStartElement("Mapping");
                xml.WriteAttributeString("Space", "C-S");
                xml.WriteAttributeString("xmlns", "urn:schemas-microsoft-com:windows:storage:mapping:CS");

                xml.WriteStartElement("EntityContainerMapping");
                xml.WriteAttributeString("StorageEntityContainer", "dbo");
                xml.WriteAttributeString("CdmEntityContainer", "Entities");

                foreach (ObjectClass obj in objClassList)
                {
                    xml.WriteStartElement("EntitySetMapping");
                    xml.WriteAttributeString("Name", obj.ClassName);

                    xml.WriteStartElement("EntityTypeMapping");
                    xml.WriteAttributeString("TypeName", "IsTypeOf(Model." + obj.ClassName + ")");

                    xml.WriteStartElement("MappingFragment");
                    xml.WriteAttributeString("StoreEntitySet", obj.ClassName);

                    xml.WriteStartElement("ScalarProperty");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteAttributeString("ColumnName", "ID");
                    xml.WriteEndElement(); // </ScalarProperty>

                    foreach (ObjectProperty p in obj.Properties)
                    {
                        if (p.IsList.Value || p.IsAssociation.Value) continue;

                        xml.WriteStartElement("ScalarProperty");
                        xml.WriteAttributeString("Name", p.PropertyName);
                        xml.WriteAttributeString("ColumnName", p.PropertyName);
                        xml.WriteEndElement(); // </ScalarProperty>
                    }

                    xml.WriteEndElement(); // </MappingFragment>

                    xml.WriteEndElement(); // </EntityTypeMapping>
                    xml.WriteEndElement(); // </EntitySetMapping>
                }

                var assocProperties = from p in ctx.GetTable<ObjectProperty>()
                                      from o in objClassList
                                      where p.ObjectClass.ID == o.ID
                                            && p.IsAssociation.Value
                                            && !p.IsList.Value
                                      select p;

                foreach (ObjectProperty prop in assocProperties)
                {
                    xml.WriteStartElement("AssociationSetMapping");
                    ObjectType otherType = new ObjectType(prop.DataType);
                    string assocName = "FK_" + prop.ObjectClass.ClassName + "_" + otherType.Classname;
                    xml.WriteAttributeString("Name", assocName);
                    xml.WriteAttributeString("TypeName", "Model." + assocName);
                    xml.WriteAttributeString("StoreEntitySet", prop.ObjectClass.ClassName);

                    xml.WriteStartElement("EndProperty");
                    xml.WriteAttributeString("Name", otherType.Classname);
                    xml.WriteStartElement("ScalarProperty");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteAttributeString("ColumnName", prop.PropertyName);
                    xml.WriteEndElement(); // </ScalarProperty>
                    xml.WriteEndElement(); // </EndProperty>

                    xml.WriteStartElement("EndProperty");
                    xml.WriteAttributeString("Name", prop.ObjectClass.ClassName);
                    xml.WriteStartElement("ScalarProperty");
                    xml.WriteAttributeString("Name", "ID");
                    xml.WriteAttributeString("ColumnName", "ID");
                    xml.WriteEndElement(); // </ScalarProperty>
                    xml.WriteEndElement(); // </EndProperty>

                    xml.WriteStartElement("Condition");
                    xml.WriteAttributeString("ColumnName", prop.PropertyName);
                    xml.WriteAttributeString("IsNull", "false");
                    xml.WriteEndElement(); // </Condition>


                    xml.WriteEndElement(); // </AssociationSet>
                }

                xml.WriteEndElement(); // </EntityContainerMapping>

                xml.WriteEndElement(); // </Mapping>
            }
        }
        #endregion

        #region GetDBType
        private string GetDBType(string clrType)
        {
            Type t = Type.GetType(clrType, false, false);

            // TODO: Lang lebe der Pfusch!
            if (t == null) return "unknown"; 

            // TODO: Get from Metadata
            if(t == typeof(int))
                return "int";
            if(t == typeof(string))
                return "nvarchar";
            if(t == typeof(double))
                return "float";
            if(t == typeof(bool))
                return "bit";
            if (t == typeof(DateTime))
                return "datetime";
            return "unknown";
        }
        #endregion
    }
}
