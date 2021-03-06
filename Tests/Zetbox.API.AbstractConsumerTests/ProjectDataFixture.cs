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

namespace Zetbox.API.AbstractConsumerTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Zetbox.API;
    using Zetbox.App.Base;
    using Zetbox.App.Projekte;

    using NUnit.Framework;

    using Autofac;

    /// <summary>
    /// This fixture creates a set of Kunden, Projekte, Mitarbeiter and Tasks for testing.
    /// </summary>
    public abstract class ProjectDataFixture : AbstractTestFixture
    {
        /// <summary>
        /// Creates a few new test objects
        /// </summary>
        /// <param name="ctx">this context is used to create the objects</param>
        public static void CreateTestData(IZetboxContext ctx)
        {
            var kunde = ctx.Create<Kunde>();
            kunde.EMails.Add("office@example.com");
            kunde.EMails.Add("privat@example.com");
            kunde.Kundenname = "com Kunde";
            kunde.PLZ = "1111";

            kunde = ctx.Create<Kunde>();
            kunde.EMails.Add("office@example.net");
            kunde.Kundenname = "net Kunde";
            kunde.PLZ = "2222";

            kunde = ctx.Create<Kunde>();
            kunde.Kundenname = "empty Kunde";
            kunde.PLZ = "3333";

            kunde = ctx.Create<Kunde>();
            kunde.EMails.Add("office@example.org");
            kunde.EMails.Add("privat@example.org");
            kunde.EMails.Add("muh@example.org");
            kunde.EMails.Add("blah@example.org");
            kunde.Kundenname = "org Kunde";
            kunde.PLZ = "4444";

            var prj = ctx.Create<Projekt>();
            prj.Name = "Zetbox";

            var task1 = ctx.Create<Task>();
            task1.Name = "task1";
            task1.Projekt = prj;

            var task2 = ctx.Create<Task>();
            task2.Name = "task2";
            task2.Projekt = prj;

            var ma1 = ctx.Create<Mitarbeiter>();
            ma1.Geburtstag = new DateTime(1960, 01, 02);
            ma1.Name = "Mitarbeiter Alpha";
            ma1.SVNr = "123456789";
            ma1.TelefonNummer = "+43664123456789";

            var ma2 = ctx.Create<Mitarbeiter>();
            ma2.Geburtstag = new DateTime(1970, 12, 30);
            ma2.Name = "Mitarbeiter Beta";
            ma2.SVNr = "987654321";
            ma2.TelefonNummer = "+43664987654321";

            // Make nHibernate happy
            ctx.SubmitChanges();
            
            ma2.Projekte.Add(prj);
            ma1.Projekte.Add(prj);

        }

        /// <summary>
        /// Deletes all remaining test objects.
        /// </summary>
        /// <param name="ctx">this context is used to delete the objects</param>
        public static void DeleteData(IZetboxContext ctx)
        {
            ctx.GetQuery<Kunde>().ForEach(obj => ctx.Delete(obj));
            ctx.GetQuery<Auftrag>().ForEach(obj => ctx.Delete(obj));
            ctx.GetQuery<Task>().ForEach(obj => ctx.Delete(obj));
            ctx.GetQuery<Projekt>().ForEach(obj => { ctx.Delete(obj); });
            ctx.GetQuery<Mitarbeiter>().ForEach(obj => { ctx.Delete(obj); });
        }

        /// <summary>
        /// Deletes all existing test data and creates new objects.
        /// </summary>
        public override void SetUp()
        {
            base.SetUp();
            using (var ctx = GetContext())
            {
                DeleteData(ctx);
                CreateTestData(ctx);
                ctx.SubmitChanges();
            }
        }
    }
}
