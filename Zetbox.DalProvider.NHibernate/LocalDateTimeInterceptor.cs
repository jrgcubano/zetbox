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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Type;

namespace Zetbox.DalProvider.NHibernate
{
    /// <summary>
    /// Convert all DateTimes from/to the database into local time.
    /// </summary>
    /// <remarks>Based on Dan Morphi's http://www.milkcarton.com/blog/2007/01/19/NHibernate+DateTime+And+UTC.aspx </remarks>
    public class LocalDateTimeInterceptor : EmptyInterceptor
    {
        public override bool OnLoad(object entity, object id, object[] state, string[] propertyNames, IType[] types)
        {
            ConvertDateToLocal(state, types);
            return true;
        }

        public override bool OnSave(object entity, object id, object[] state, string[] propertyNames, IType[] types)
        {
            ConvertDateToLocal(state, types);
            return true;
        }

        public override bool OnFlushDirty(object entity, object id, object[] currentState, object[] previousState, string[] propertyNames, IType[] types)
        {
            ConvertDateToLocal(currentState, types);
            return true;
        }

        private void ConvertDateToLocal(object[] state, IType[] types)
        {
            int index = 0;
            foreach (IType type in types)
            {
                if(state[index] == null) continue;
                if ((type.ReturnedClass == typeof(DateTime)))
                {
                    DateTime cur = (DateTime)state[index];
                    switch (cur.Kind)
                    {
                        case DateTimeKind.Local:
                            break;
                        case DateTimeKind.Utc:
                            state[index] = cur.ToLocalTime();
                            break;
                        case DateTimeKind.Unspecified:
                            state[index] = DateTime.SpecifyKind(cur, DateTimeKind.Local);
                            break;
                    }
                }
                else if ((type.ReturnedClass == typeof(DateTime?)))
                {
                    DateTime? cur = (DateTime?)state[index];
                    if (cur != null)
                    {
                        switch (cur.Value.Kind)
                        {
                            case DateTimeKind.Local:
                                break;
                            case DateTimeKind.Utc:
                                state[index] = cur.Value.ToLocalTime();
                                break;
                            case DateTimeKind.Unspecified:
                                state[index] = DateTime.SpecifyKind(cur.Value, DateTimeKind.Local);
                                break;
                        }
                    }
                }

                ++index;
            }
        }
    }
}
