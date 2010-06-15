using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kistl.Server.Generators.ClientObjects.Implementation
{
    public class ProjectFile
        : Templates.Implementation.ProjectFile
    {

        public ProjectFile(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, string projectGuid, List<string> fileNames)
            : base(_host, ctx, projectGuid, fileNames)
        {
        }

        protected override string GetAssemblyName()
        {
            return "Kistl.Objects." + TaskEnum.Client;
        }

        protected override void ApplyAdditionalReferences()
        {
            base.ApplyAdditionalReferences();

            // used all over the place
            this.WriteLine(@"    <Reference Include=""System.Data.Linq"">");
            this.WriteLine(@"      <RequiredTargetFramework>3.5</RequiredTargetFramework>");
            this.WriteLine(@"    </Reference>");

            // used for INotifyCollectionChanged
            this.WriteLine(@"    <Reference Include=""WindowsBase"">");
            this.WriteLine(@"      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            this.WriteLine(@"    </Reference>");

            // Client API
            this.WriteLine(@"    <Reference Include=""Kistl.API.Client"">");
            this.WriteLine(@"      <SpecificVersion>False</SpecificVersion>");
            this.WriteLine(@"      <HintPath>$(KistlAPIPath)\Client\Kistl.API.Client.dll</HintPath>");
            this.WriteLine(@"      <Private>False</Private>");
            this.WriteLine(@"    </Reference>");

            // DAL Provider
            this.WriteLine(@"    <Reference Include=""Kistl.DalProvider.ClientObjects"">");
            this.WriteLine(@"      <SpecificVersion>False</SpecificVersion>");
            this.WriteLine(@"      <HintPath>$(KistlAPIPath)\Client\Kistl.DalProvider.ClientObjects.dll</HintPath>");
            this.WriteLine(@"      <Private>False</Private>");
            this.WriteLine(@"    </Reference>");
        }

    }
}
