using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using System.Text;
using Kistl.App.Base;
using Kistl.API;

namespace Kistl.Server.Generators.SQLServer
{
    /// <summary>
    /// Erzeugt die SQL Server Datenbank
    /// Das Objektmodell hat keine Ahnung von der Datenbank, 
    /// also keine GetTableName, GetColumnName etc. Funktionen.
    /// </summary>
    public class SQLServerDatabaseGenerator : IDatabaseGenerator
    {
        private SqlConnection db = null;
        private SqlTransaction tx = null;
        private Kistl.API.IKistlContext ctx = null;
        private List<ObjectClass> objClassList = new List<ObjectClass>();

        public void Generate(Kistl.API.IKistlContext ctx)
        {
            this.ctx = ctx;

            int propCount = 0;
            // Preload all ObjectClasses and Properties to avoid Deadlocks
            objClassList = ctx.GetQuery<ObjectClass>().ToList();
            // Preload Properties
            objClassList.ForEach(o => propCount += o.Properties.Count);
            // Touch BaseClasses
            objClassList.ForEach(o => { var tmp = o.BaseObjectClass; });
            // Touch Modules
            objClassList.ForEach(o => { var tmp = o.Module; });


            System.Diagnostics.Trace.TraceInformation("Checking {0} Tables with {1} Properties",
                objClassList.Count, propCount);

            using (SqlConnection _db = new SqlConnection(ApplicationContext.Current.Configuration.Server.ConnectionString))
            {
                db = _db;
                db.Open();
                // TODO: Geht leider doch nicht.
                // Jetzt meckert er in der Applikation, dass bei einem Update nix geändert wurde oder so...
                // d.H. r.Load() muss ausgelöst werden...
                //using (SqlTransaction _tx = db.BeginTransaction())
                {
                    //tx = _tx;

                    foreach (ObjectClass objClass in objClassList)
                    {
                        GenerateTable(objClass);
                    }

                    foreach (ObjectClass objClass in objClassList)
                    {
                        GenerateFKConstraints(objClass);
                    }

                    //tx.Commit();
                    // tx.Rollback();
                }
            }
        }

        #region GenerateFKConstraints
        private void GenerateFKConstraints(ObjectClass objClass)
        {
            // Create FK to BaseClass
            if (objClass.BaseObjectClass != null)
            {
                CreateFKConstraint(objClass.BaseObjectClass, objClass, "ID");
            }

            foreach (Property p in objClass.Properties.OfType<Property>())
            {
                if (p.IsList)
                {
                    CreateFKConstraint(objClass, p, "fk_" + p.ObjectClass.ClassName);
                }

                if (p is ObjectReferenceProperty)
                {
                    ObjectReferenceProperty orp = (ObjectReferenceProperty)p;
                    if (orp.IsList)
                    {
                        CreateFKConstraint(orp.ReferenceObjectClass, orp, "fk_" + orp.PropertyName);
                    }
                    else
                    {
                        CreateFKConstraint(orp.ReferenceObjectClass, objClass, "fk_" + orp.PropertyName);
                    }
                }
            }
        }

        private void CreateFKConstraint(ObjectClass parent, Property child, string fk_column)
        {
            string fk = Generator.GetAssociationName(parent.GetTypeMoniker(), Generator.GetAssociationChildType(child), fk_column);
            SqlCommand cmd = new SqlCommand("select dbo.fn_FKConstraintExists(@fk)", db, tx);
            cmd.Parameters.AddWithValue("@fk", fk);
            
            if (!((bool)cmd.ExecuteScalar()))
            {
                cmd = new SqlCommand(string.Format(@"ALTER TABLE [{0}]  WITH CHECK 
                    ADD CONSTRAINT [{1}] FOREIGN KEY([{2}])
                    REFERENCES [{3}] ([ID])", 
                       Generator.GetDatabaseTableName(child),
                       fk,
                       fk_column,
                       Generator.GetDatabaseTableName(parent)), db, tx); ;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(string.Format(@"ALTER TABLE [{0}] CHECK CONSTRAINT [{1}]",
                       Generator.GetDatabaseTableName(child),
                       fk), db, tx); ;
                cmd.ExecuteNonQuery();
            }
        }

        private void CreateFKConstraint(ObjectClass parent, ObjectClass child, string fk_column)
        {
            string fk = Generator.GetAssociationName(parent, child, fk_column);
            SqlCommand cmd = new SqlCommand("select dbo.fn_FKConstraintExists(@fk)", db, tx);
            cmd.Parameters.AddWithValue("@fk", fk);

            if (!((bool)cmd.ExecuteScalar()))
            {
                cmd = new SqlCommand(string.Format(@"ALTER TABLE [{0}]  WITH CHECK 
                    ADD CONSTRAINT [{1}] FOREIGN KEY([{2}])
                    REFERENCES [{3}] ([ID])",
                       Generator.GetDatabaseTableName(child),
                       fk,
                       fk_column,
                       Generator.GetDatabaseTableName(parent)), db, tx); ;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(string.Format(@"ALTER TABLE [{0}] CHECK CONSTRAINT [{1}]",
                       Generator.GetDatabaseTableName(child),
                       fk), db, tx); ;
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        private void CheckTableProperties(ObjectClass classToCheck, DataType obj, string parentPropertyName)
        {
            foreach (Property p in obj.Properties.OfType<Property>().Where(p => p.IsList == false))
            {
                if (p is StructProperty)
                {
                    CheckTableProperties(classToCheck, ((StructProperty)p).StructDefinition, 
                        p.PropertyName.CalcColumnName(parentPropertyName));
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select dbo.fn_ColumnExists(@t, @c)", db, tx);
                    cmd.Parameters.AddWithValue("@t", Generator.GetDatabaseTableName(classToCheck));
                    if (p is ObjectReferenceProperty)
                    {
                        cmd.Parameters.AddWithValue("@c", "fk_" + p.PropertyName.CalcColumnName(parentPropertyName));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@c", p.PropertyName.CalcColumnName(parentPropertyName));
                    }

                    bool columnExists = (bool)cmd.ExecuteScalar();
                    System.Diagnostics.Trace.TraceInformation("  " + (columnExists ? "Checking" : "Creating") + " Column " + classToCheck.TableName + "." + p.PropertyName.CalcColumnName(parentPropertyName));

                    cmd = new SqlCommand("", db, tx);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("alter table [{0}] ", Generator.GetDatabaseTableName(classToCheck));
                    sb.Append(columnExists ? " alter column " : " add ");

                    sb.Append(GetColumnStmt(p, parentPropertyName));

                    System.Diagnostics.Trace.TraceInformation("    " + sb.ToString());
                    cmd.CommandText = sb.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AppendTableProperties(StringBuilder sb, DataType obj, string parentPropertyName)
        {
            foreach (Property p in obj.Properties.OfType<Property>().Where(p => p.IsList == false))
            {
                if (p is StructProperty)
                {
                    AppendTableProperties(sb, ((StructProperty)p).StructDefinition, 
                        p.PropertyName.CalcColumnName(parentPropertyName));
                }
                else
                {
                    sb.Append(GetColumnStmt(p, parentPropertyName));
                    sb.AppendLine(",");
                }
            }
        }

        private void GenerateTable(ObjectClass objClass)
        {
            SqlCommand cmd = new SqlCommand("select dbo.fn_TableExists(@t)", db, tx);
            cmd.Parameters.AddWithValue("@t", objClass.TableName);

            #region Create/Update Table
            if ((bool)cmd.ExecuteScalar())
            {
                System.Diagnostics.Trace.TraceInformation("Checking Table " + Generator.GetDatabaseTableName(objClass));
                CheckTableProperties(objClass, objClass, "");
            }
            else
            {
                System.Diagnostics.Trace.TraceInformation("Creating Table " + Generator.GetDatabaseTableName(objClass));

                cmd = new SqlCommand("", db, tx);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("create table [{0}] ( ", Generator.GetDatabaseTableName(objClass));
                if (objClass.BaseObjectClass != null)
                {
                    sb.AppendLine("[ID] [int] NOT NULL, ");
                }
                else
                {
                    sb.AppendLine("[ID] [int] IDENTITY(1,1) NOT NULL, ");
                }

                AppendTableProperties(sb, objClass, "");

                sb.AppendFormat("CONSTRAINT [PK_{0}] PRIMARY KEY CLUSTERED ( [ID] ASC )", Generator.GetDatabaseTableName(objClass));
                sb.AppendLine();
                sb.Append(")");

                System.Diagnostics.Trace.TraceInformation("  " + sb.ToString());
                cmd.CommandText = sb.ToString();
                cmd.ExecuteNonQuery();
            }
            #endregion

            #region Create/Update List Properties
            foreach (Property p in objClass.Properties.OfType<Property>().Where(p => p.IsList))
            {
                cmd = new SqlCommand("select dbo.fn_TableExists(@t)", db, tx);
                cmd.Parameters.AddWithValue("@t", Generator.GetDatabaseTableName(p));

                if ((bool)cmd.ExecuteScalar())
                {
                    System.Diagnostics.Trace.TraceInformation("Checking Table " + Generator.GetDatabaseTableName(p));

                    cmd = new SqlCommand("", db, tx);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("alter table [{0}] alter column ", Generator.GetDatabaseTableName(p));

                    sb.Append(GetColumnStmt(p, ""));

                    System.Diagnostics.Trace.TraceInformation("    " + sb.ToString());
                    cmd.CommandText = sb.ToString();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    System.Diagnostics.Trace.TraceInformation("Creating Table " + Generator.GetDatabaseTableName(p));

                    cmd = new SqlCommand("", db, tx);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("create table [{0}] ( ", Generator.GetDatabaseTableName(p));
                    sb.AppendLine("[ID] [int] IDENTITY(1,1) NOT NULL, ");

                    sb.AppendLine(string.Format("[fk_{0}] [int] NOT NULL, ", p.ObjectClass.ClassName));

                    sb.Append(GetColumnStmt(p, ""));
                    sb.AppendLine(",");

                    sb.AppendFormat("CONSTRAINT [PK_{0}] PRIMARY KEY CLUSTERED ( [ID] ASC )", Generator.GetDatabaseTableName(p));
                    sb.AppendLine();
                    sb.Append(")");

                    System.Diagnostics.Trace.TraceInformation("  " + sb.ToString());
                    cmd.CommandText = sb.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
            #endregion
        }

        /// <summary>
        /// Das wird hier analysiert, weil ich nicht will, dass die Objektdefinition 
        /// etwas über die Datenbank wissen muss
        /// was ist, wenn wir andere Datenbanken unterstützen wollen?
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private string GetColumnStmt(Property p, string parentPropertyName)
        {
            StringBuilder sb = new StringBuilder();

            if (p is ObjectReferenceProperty)
            {
                sb.AppendFormat(" [fk_{0}] ", p.PropertyName.CalcColumnName(parentPropertyName));
            }
            else
            {
                sb.AppendFormat(" [{0}] ", p.PropertyName.CalcColumnName(parentPropertyName));
            }

            sb.Append(SQLServerHelper.GetDBType(p));

            if (p is StringProperty)
            {
                sb.AppendFormat(" ({0})", ((StringProperty)p).Length);
            }

            if (p.IsList) sb.AppendFormat(" NOT NULL ");
            else sb.AppendFormat(p.IsNullable ? " NULL " : " NOT NULL ");

            return sb.ToString();
        }
    }
}
