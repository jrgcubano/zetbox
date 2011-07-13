
namespace Kistl.API.Server
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using Autofac;

    public sealed class ServerApiModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            base.Load(moduleBuilder);

            moduleBuilder
                .Register<ServerDeploymentRestrictor>(c => new ServerDeploymentRestrictor())
                .As<IDeploymentRestrictor>()
                .SingleInstance();

            moduleBuilder
                .RegisterType<Migration.MigrationTasksBase>()
                .As<Migration.IMigrationTasks>()
                .InstancePerDependency();

            moduleBuilder
                .RegisterType<PerfServerCounter>()
                .AsSelf()
                .OnActivated(args => args.Instance.Initialize(args.Context.Resolve<IFrozenContext>()))
                .SingleInstance();
        }
    }
}
