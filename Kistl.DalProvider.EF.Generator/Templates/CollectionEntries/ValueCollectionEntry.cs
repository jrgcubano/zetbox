
namespace Kistl.DalProvider.Ef.Generator.Templates.CollectionEntries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.Generator.Extensions;
    using Templates = Kistl.Generator.Templates;

    public partial class ValueCollectionEntry
        : Templates.CollectionEntries.ValueCollectionEntry
    {
        public ValueCollectionEntry(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Property prop)
            : base(_host, ctx, prop)
        {
        }

        protected override void ApplyConstructorTemplate()
        {
            // replace base constructors
            //base.ApplyConstructorTemplate();

            this.WriteObjects("[Obsolete]");
            this.WriteLine();
            this.WriteObjects("public ", GetCeClassName(), "()");
            this.WriteLine();
            this.WriteObjects(": base(null)");
            this.WriteLine();
            this.WriteObjects("{");
            this.WriteLine();

            if (this.prop is CompoundObjectProperty)
            {
                Templates.Properties.CompoundObjectPropertyInitialisation.Call(Host, ctx, prop.GetPropertyTypeString() + ImplementationSuffix, "Value", "_Value", false);
            }

            this.WriteObjects("}");
            this.WriteLine();

            this.WriteObjects("public ", GetCeClassName() ,"(Func<IFrozenContext> lazyCtx)");
            this.WriteLine();
            this.WriteObjects("    : base(lazyCtx)");
            this.WriteLine();
            this.WriteObjects("{");
            this.WriteLine();
            
            if (this.prop is CompoundObjectProperty)
            {
                Templates.Properties.CompoundObjectPropertyInitialisation.Call(Host, ctx, prop.GetPropertyTypeString() + ImplementationSuffix, "Value", "_Value", false);
            }

            this.WriteObjects("}");
            this.WriteLine();

        }

        protected override void ApplyClassAttributeTemplate()
        {
            base.ApplyClassAttributeTemplate();
            this.WriteObjects(@"    [EdmEntityType(NamespaceName=""Model"", Name=""",
                prop.GetCollectionEntryClassName(), @""")]");
            this.WriteLine();
        }
    }
}
