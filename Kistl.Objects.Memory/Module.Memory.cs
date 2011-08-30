// <autogenerated/>

namespace Kistl.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Autofac;
	using Kistl.API;
    using Kistl.App.Extensions;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    public class MemoryModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder
                .Register<MemoryImplementationTypeChecker>(
                    c => new MemoryImplementationTypeChecker(
                        c.Resolve<Func<IEnumerable<IImplementationTypeChecker>>>()))
                .As<IMemoryImplementationTypeChecker>()
                .As<IImplementationTypeChecker>()
                .InstancePerDependency();
                
            builder
                .Register<MemoryActionsManager>(
                    c => new MemoryActionsManager(
                        c.Resolve<ILifetimeScope>(),
                        c.Resolve<IDeploymentRestrictor>()))
                .As<IMemoryActionsManager>()
                .InstancePerLifetimeScope();
        }
    }


    internal sealed class MemoryImplementationTypeChecker
        : Kistl.API.BaseImplementationTypeChecker, IMemoryImplementationTypeChecker
    {
        public MemoryImplementationTypeChecker(Func<IEnumerable<IImplementationTypeChecker>> implTypeCheckersFactory)
            : base(implTypeCheckersFactory)
        {
        }

        protected override System.Reflection.Assembly GetAssembly()
        {
            return typeof(MemoryImplementationTypeChecker).Assembly;
        }
    }

    // marker class to provide stable and correct assembly reference
    internal sealed class MemoryActionsManager
        : BaseCustomActionsManager, IMemoryActionsManager
    {
        public MemoryActionsManager(ILifetimeScope container, IDeploymentRestrictor restrictor)
            : base(container, restrictor, "MemoryImpl")
        {
        }
    }
}
