
namespace Kistl.DalProvider.NHibernate.Generator.Templates.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Kistl.API;
    using Kistl.API.Server;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator;
    using Kistl.Generator.Extensions;

    public partial class ValueTypePropertyHbm
    {
        public static void Call(Arebis.CodeGeneration.IGenerationHost _host,
            string prefix,
            ValueTypeProperty prop,
            string propName,
            string columnName,
            bool forceDefinition,
            string implementationSuffix,
            bool needsConcurrency)
        {
            if (_host == null) { throw new ArgumentNullException("_host"); }

            // shortcut unmapped properties
            if (prop.IsCalculated)
            {
                _host.WriteOutput(string.Format("<!-- ValueTypeProperty {0} is calculated and persisted -->\n", prop.Name));
            }

            propName = string.IsNullOrEmpty(propName) ? prop.Name : propName;
            columnName = string.IsNullOrEmpty(columnName) ? propName : columnName;
            var optimisticLock = needsConcurrency && propName == "ChangedOn";

            string typeAttr = String.Empty;
            if (prop is DateTimeProperty)
            {
                typeAttr = "type=\"Timestamp\"";
            }

            string ceClassAttr;
            if (prop.IsList && !forceDefinition)
            {
                // set the proper type for collection entries
                ceClassAttr = String.Format("class=\"{0}.{1}{2}+{1}Proxy,Kistl.Objects.NHibernateImpl\"",
                    prop.GetCollectionEntryNamespace(),
                    prop.GetCollectionEntryClassName(),
                    implementationSuffix);
            }
            else
            {
                // not needed
                ceClassAttr = String.Empty;
            }

            string ceReverseKeyColumnName = prop.GetCollectionEntryReverseKeyColumnName();
            string listPositionColumnName = Construct.ListPositionColumnName(prop);

            Call(_host,
                prefix,
                propName,
                columnName,
                prop.IsList && !forceDefinition,
                typeAttr,
                ceClassAttr,
                ceReverseKeyColumnName,
                listPositionColumnName,
                optimisticLock);
        }
    }
}