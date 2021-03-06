// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.DalProvider.Client.Generator.Templates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API.Server;
    using Templates = Zetbox.Generator.Templates;

    public class ProjectFile
        : Templates.ProjectFile
    {

        public ProjectFile(Arebis.CodeGeneration.IGenerationHost _host, Zetbox.API.IZetboxContext ctx, string projectGuid, List<string> fileNames, IEnumerable<ISchemaProvider> schemaProviders)
            : base(_host, ctx, projectGuid, fileNames, schemaProviders)
        {
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

            // DAL Provider
            this.WriteLine(@"    <Reference Include=""Zetbox.DalProvider.ClientObjects"">");
            this.WriteLine(@"      <SpecificVersion>False</SpecificVersion>");
            this.WriteLine(@"      <HintPath>$(ZetboxAPIPath)\Client\Core\Zetbox.DalProvider.ClientObjects.dll</HintPath>");
            this.WriteLine(@"      <Private>False</Private>");
            this.WriteLine(@"    </Reference>");

            // Client API
            this.WriteLine(@"    <Reference Include=""Zetbox.API.Client"">");
            this.WriteLine(@"      <SpecificVersion>False</SpecificVersion>");
            this.WriteLine(@"      <HintPath>$(ZetboxAPIPath)\Client\Core\Zetbox.API.Client.dll</HintPath>");
            this.WriteLine(@"      <Private>False</Private>");
            this.WriteLine(@"    </Reference>");
        }

        protected override string GetRelativeOutputPath()
        {
            return @"Client\Core";
        }
    }
}
