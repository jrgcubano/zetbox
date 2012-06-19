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

namespace Zetbox.DalProvider.NHibernate.Tests
{
    using System;
    using System.Collections.Generic;
    using Autofac;
    using Zetbox.API;
    using Zetbox.API.AbstractConsumerTests;
    using Zetbox.API.Configuration;
    using Zetbox.App.Base;
    using Zetbox.App.Projekte;
    using Zetbox.Server;
    using Npgsql;
    using NUnit.Framework;

    [SetUpFixture]
    public class SetUpFixture
        : AbstractSetUpFixture
    {

        protected override void SetupBuilder(ContainerBuilder builder)
        {
            base.SetupBuilder(builder);
            builder.RegisterModule(new Zetbox.API.ApiModule());
            builder.RegisterModule(new Zetbox.API.Common.ApiCommonModule());
            builder.RegisterModule(new Zetbox.API.Server.ServerApiModule());
            builder.RegisterModule(new Zetbox.Server.ServerModule());
            builder.RegisterModule(new Zetbox.Objects.InterfaceModule());
            builder.RegisterModule(new Zetbox.Objects.NHibernateModule());
            builder.RegisterModule(new Zetbox.Objects.MemoryModule());
            builder.RegisterModule(new Zetbox.DalProvider.NHibernate.NHibernateProvider());
            builder.RegisterModule(new Zetbox.DalProvider.Memory.MemoryProvider());

            // load DB Utility from config
        }

        protected override void SetUp(IContainer container)
        {
            base.SetUp(container);
            ResetDatabase(container);

            PropertyNHibernateImpl.OnToString_Property
                += (obj, args) => { args.Result = String.Format("Prop, [{0}]", obj.Description); };
            MitarbeiterNHibernateImpl.OnToString_Mitarbeiter
                += (obj, args) => { args.Result = String.Format("MA, [{0}]", obj.Name); };
            ProjektNHibernateImpl.OnToString_Projekt
                += (obj, args) => { args.Result = String.Format("Proj, [{0}]", obj.Name); };
        }

        protected override string GetConfigFile()
        {
            return "Zetbox.DalProvider.NHibernate.Tests.xml";
        }

        protected override HostType GetHostType()
        {
            return HostType.Server;
        }

        public override void TearDown()
        {
            base.TearDown();
            // always kill connections to the db
            NpgsqlConnection.ClearAllPools();
        }
    }
}