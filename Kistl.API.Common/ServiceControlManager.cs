using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.App.Base;

using Autofac;
using Kistl.API;

namespace Kistl.App.Extensions
{
    public interface IServiceControlManager
    {
        void Start();
        void Stop();

        void Start(ServiceDescriptor descr);
        void Stop(ServiceDescriptor descr);
    }

    public class ServiceControlManager : IServiceControlManager
    {
        private readonly Autofac.ILifetimeScope _container;
        private readonly IFrozenContext _frozenCtx;
        private readonly IDeploymentRestrictor _restrictor;

        public ServiceControlManager(Autofac.ILifetimeScope container, IFrozenContext frozenCtx, IDeploymentRestrictor restrictor)
        {
            if (container == null) throw new ArgumentNullException("container");
            if (frozenCtx == null) throw new ArgumentNullException("frozenCtx");
            if (restrictor == null) throw new ArgumentNullException("restrictor");

            this._container = container;
            this._frozenCtx = frozenCtx;
            this._restrictor = restrictor;
        }

        #region IServiceControlManager Members

        public void Start()
        {
            foreach (var s in GetServiceDescriptors())
            {
                Start(s);
            }
        }

        public void Stop()
        {
            foreach (var s in GetServiceDescriptors())
            {
                Stop(s);
            }
        }

        public void Start(ServiceDescriptor descr)
        {
            if (descr == null) throw new ArgumentNullException("descr");

            var service = GetInstance(descr);
            service.Start();
        }

        public void Stop(ServiceDescriptor descr)
        {
            if (descr == null) throw new ArgumentNullException("descr");

            var service = GetInstance(descr);
            service.Stop();
        }
        #endregion

        private IService GetInstance(ServiceDescriptor descr)
        {
            var type = descr.TypeRef.AsType(true);
            return (IService)_container.Resolve(type);
        }

        private IEnumerable<ServiceDescriptor> GetServiceDescriptors()
        {
            foreach (var s in _frozenCtx.GetQuery<ServiceDescriptor>())
            {
                if (_restrictor.IsAcceptableDeploymentRestriction((int)s.DeploymentRestriction))
                    yield return s;
            }
        }
    }

    public class ServiceControlManagerModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder
                .RegisterType<ServiceControlManager>()
                .As<IServiceControlManager>()
                .SingleInstance();
        }
    }
}