﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace Zetbox.ConfigEditor
{
    public class ModuleType
    {
        public Type Type { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public bool IsFeature { get; set; }
        public bool NotOnFallback { get; set; }
    }

    public class ModulesCache
    {
        private ModulesCache()
        {
            // ReflectionOnlyLoadFrom.GetTypes -> dependent assemblies must be pre-loaded or loaded on demand through the ReflectionOnlyAssemblyResolve event
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += new ResolveEventHandler(CurrentDomain_ReflectionOnlyAssemblyResolve);
        }

        private Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
        {
            var aName = new AssemblyName(args.Name);
            var file = Directory.GetFiles(Environment.CurrentDirectory, aName.Name + ".dll", SearchOption.AllDirectories).FirstOrDefault();
            if (file != null)
                return System.Reflection.Assembly.ReflectionOnlyLoadFrom(file);
            else
                return System.Reflection.Assembly.ReflectionOnlyLoad(args.Name);
        }

        private static ModulesCache _instance;
        public static ModulesCache Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModulesCache();
                }
                return _instance;
            }
        }

        public ModuleType this[string typeName]
        {
            get
            {
                EnsureCache();
                if (_modules.ContainsKey(typeName))
                    return _modules[typeName];
                else
                    return new ModuleType() { TypeName = typeName };
            }
        }

        public bool Contains(string typeName)
        {
            EnsureCache();
            return _modules.ContainsKey(typeName);
        }

        public IEnumerable<ModuleType> All
        {
            get
            {
                EnsureCache();
                return _modules.Values;
            }
        }

        private Dictionary<string, Assembly> _assemblies;
        private Dictionary<string, ModuleType> _modules;

        private void EnsureCache()
        {
            if (_assemblies == null)
            {
                _assemblies = new Dictionary<string, Assembly>();
                _modules = new Dictionary<string, ModuleType>();
                foreach (var file in Directory.GetFiles(Environment.CurrentDirectory, "*.dll", SearchOption.AllDirectories))
                {
                    if (file.ToLowerInvariant().EndsWith(".resources.dll")) continue;
                    try
                    {
                        LoadAssembly(file);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void LoadAssembly(string file)
        {
            if (_assemblies.ContainsKey(FileToAssemblyName(file))) return;

            Assembly assembly = TryLoadAssembly(file);
            if (assembly == null) return;

            var assemblyName = assembly.GetName().Name;
            _assemblies[assemblyName] = assembly;

            foreach (var type in GetTypes(assembly))
            {
                if (type == null) continue; // Oh, yes!

                if (type.BaseType != null && type.BaseType.FullName == "Autofac.Module") // By string, as we do not want to rely on a specific autofac version
                {
                    var mt = new ModuleType()
                    {
                        Type = type,
                        TypeName = string.Format("{0}, {1}", type.FullName, assemblyName),
                        Description = ExtractDescription(type),
                        IsFeature = ExtractIsFeature(type),
                        NotOnFallback = ExtractNotOnFallback(type)
                    };
                    _modules[mt.TypeName] = mt;
                }
            }
        }

        private static string ExtractDescription(Type type)
        {
            string description = string.Empty;
            var attr = CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(i => i.Constructor.DeclaringType.FullName == typeof(System.ComponentModel.DescriptionAttribute).FullName);
            if (attr != null)
            {
                var namedArg = attr.NamedArguments.FirstOrDefault(i => i.MemberInfo.Name == "Description");
                if (namedArg != null && namedArg.TypedValue.Value != null)
                {
                    description = (string)namedArg.TypedValue.Value;
                }
                else if (attr.ConstructorArguments.Count > 0)
                {
                    description = (string)attr.ConstructorArguments.First().Value;
                }
            }
            return description;
        }

        private static bool ExtractIsFeature(Type type)
        {
            var attr = CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(i => i.Constructor.DeclaringType.FullName == typeof(Zetbox.API.Configuration.FeatureAttribute).FullName);
            return attr != null;
        }

        private static bool ExtractNotOnFallback(Type type)
        {
            bool notOnFallback = false;
            var attr = CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(i => i.Constructor.DeclaringType.FullName == typeof(Zetbox.API.Configuration.FeatureAttribute).FullName);
            if (attr != null)
            {
                var namedArg = attr.NamedArguments.FirstOrDefault(i => i.MemberInfo.Name == "NotOnFallback");
                if (namedArg != null)
                {
                    notOnFallback = namedArg.TypedValue.Value as bool? == true;
                }
            }
            return notOnFallback;
        }

        private static Type[] GetTypes(Assembly assembly)
        {
            Type[] types;
            try
            {
                types = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                // These where all types without an error - we are a simple tool, we can ignore all other load errors
                types = ex.Types;
            }
            return types;
        }

        private Assembly TryLoadAssembly(string file)
        {
            var assemblyName = FileToAssemblyName(file);
            if (_assemblies.ContainsKey(assemblyName))
            {
                return _assemblies[assemblyName];
            }

            Assembly assembly = null;
            try
            {
                assembly = Assembly.ReflectionOnlyLoad(assemblyName);
            }
            catch (FileNotFoundException)
            {
            }

            if (assembly == null)
            {
                assembly = Assembly.ReflectionOnlyLoadFrom(file);
            }
            return assembly;
        }

        private static string FileToAssemblyName(string file)
        {
            return Path.GetFileNameWithoutExtension(file);
        }
    }
}
