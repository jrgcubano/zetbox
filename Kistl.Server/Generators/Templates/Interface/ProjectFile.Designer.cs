using System.Collections.Generic;


namespace Kistl.Server.Generators.Templates.Interface
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst")]
    public partial class ProjectFile : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected Kistl.API.IKistlContext ctx;
		protected string projectGuid;
		protected List<string> fileNames;


        public ProjectFile(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, string projectGuid, List<string> fileNames)
            : base(_host)
        {
			this.ctx = ctx;
			this.projectGuid = projectGuid;
			this.fileNames = fileNames;

        }
        
        public override void Generate()
        {
#line 9 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
this.WriteObjects("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n");
this.WriteObjects("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\r\n");
this.WriteObjects("  <PropertyGroup>\r\n");
this.WriteObjects("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>\r\n");
this.WriteObjects("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>\r\n");
this.WriteObjects("    <ProductVersion>9.0.21022</ProductVersion>\r\n");
this.WriteObjects("    <SchemaVersion>2.0</SchemaVersion>\r\n");
this.WriteObjects("    <ProjectGuid>",  projectGuid , "</ProjectGuid>\r\n");
this.WriteObjects("    <OutputType>Library</OutputType>\r\n");
this.WriteObjects("    <RootNamespace>",  GetAssemblyName() , "</RootNamespace>\r\n");
this.WriteObjects("    <AssemblyName>",  GetAssemblyName() , "</AssemblyName>\r\n");
this.WriteObjects("    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>\r\n");
this.WriteObjects("    <FileAlignment>512</FileAlignment>\r\n");
this.WriteObjects("    <DocumentationFile>$(OutputPath)\\",  GetAssemblyName() , ".xml</DocumentationFile>\r\n");
this.WriteObjects("  </PropertyGroup>\r\n");
this.WriteObjects("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">\r\n");
this.WriteObjects("    <DebugSymbols>true</DebugSymbols>\r\n");
this.WriteObjects("    <DebugType>full</DebugType>\r\n");
this.WriteObjects("    <Optimize>false</Optimize>\r\n");
this.WriteObjects("    <DefineConstants>DEBUG;TRACE</DefineConstants>\r\n");
this.WriteObjects("    <ErrorReport>prompt</ErrorReport>\r\n");
this.WriteObjects("    <WarningLevel>4</WarningLevel>\r\n");
this.WriteObjects("    <NoWarn>1591</NoWarn>\r\n");
this.WriteObjects("    <OutputPath>..\\bin\\Debug\\</OutputPath>\r\n");
this.WriteObjects("  </PropertyGroup>\r\n");
this.WriteObjects("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">\r\n");
this.WriteObjects("    <DebugType>pdbonly</DebugType>\r\n");
this.WriteObjects("    <Optimize>true</Optimize>\r\n");
this.WriteObjects("    <DefineConstants>TRACE</DefineConstants>\r\n");
this.WriteObjects("    <ErrorReport>prompt</ErrorReport>\r\n");
this.WriteObjects("    <WarningLevel>4</WarningLevel>\r\n");
this.WriteObjects("    <OutputPath>..\\bin\\Release\\</OutputPath>\r\n");
this.WriteObjects("  </PropertyGroup>\r\n");
this.WriteObjects("  <!-- Has to come later to receive correct $(OutputPath) -->\r\n");
this.WriteObjects("  <PropertyGroup>\r\n");
this.WriteObjects("     <DocumentationFile>$(OutputPath)\\",  GetAssemblyName() , ".xml</DocumentationFile>\r\n");
this.WriteObjects("  </PropertyGroup>\r\n");
this.WriteObjects("  <ItemGroup>\r\n");
this.WriteObjects("    <AdditionalReferencePath Include=\"$(OutputPath)\" />\r\n");
this.WriteObjects("    <Reference Include=\"System\" />\r\n");
this.WriteObjects("    <Reference Include=\"System.Core\">\r\n");
this.WriteObjects("      <RequiredTargetFramework>3.5</RequiredTargetFramework>\r\n");
this.WriteObjects("    </Reference>\r\n");
this.WriteObjects("    <Reference Include=\"System.Xml\" />\r\n");
this.WriteObjects("    <Reference Include=\"Kistl.API\" />\r\n");
#line 55 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
ApplyAdditionalReferences();

#line 57 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
this.WriteObjects("  </ItemGroup>\r\n");
this.WriteObjects("  <ItemGroup>\r\n");
#line 60 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
foreach (var name in fileNames)
	{

#line 63 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
this.WriteObjects("    <Compile Include=\"",  name , "\" />\r\n");
#line 65 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
}

#line 67 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
this.WriteObjects("  </ItemGroup>\r\n");
#line 69 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
ApplyAdditionalItemGroups();

#line 70 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\ProjectFile.cst"
this.WriteObjects("  \r\n");
this.WriteObjects("  <Import Project=\"$(MSBuildBinPath)\\Microsoft.CSharp.targets\" />\r\n");
this.WriteObjects("  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. \r\n");
this.WriteObjects("       Other similar extension points exist, see Microsoft.Common.targets.\r\n");
this.WriteObjects("  <Target Name=\"BeforeBuild\">\r\n");
this.WriteObjects("  </Target>\r\n");
this.WriteObjects("  -->\r\n");
this.WriteObjects("  <Target Name=\"AfterBuild\">\r\n");
this.WriteObjects("    <!--\r\n");
this.WriteObjects("        clutch for deploying generated assemblies always to the temp output directory\r\n");
this.WriteObjects("        TODO: split OutputPath into DeployLocation (always absolute, depnding on Builder) and \r\n");
this.WriteObjects("        OutputPath (always relative, dependent on Configuration)\r\n");
this.WriteObjects("    -->\r\n");
this.WriteObjects("    <Copy SourceFiles=\"$(TargetDir)$(TargetName).dll;$(TargetDir)$(TargetName).pdb\" DestinationFolder=\"C:\\temp\\KistlCodeGen\\bin\\Debug\" />\r\n");
this.WriteObjects("  </Target>\r\n");
this.WriteObjects("</Project>");

        }



    }
}