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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Zetbox.API.Migration
{
    public interface ITypeConverter
    {
        object Convert(object v);
    }

    public class ByteConverter : ITypeConverter
    {
        public object Convert(object v)
        {
            if (v == null || v == DBNull.Value)
                return DBNull.Value;
            return System.Convert.ToByte(v, CultureInfo.GetCultureInfo("de-AT"));
        }
    }

    public class Int16Converter : ITypeConverter
    {
        public object Convert(object v)
        {
            if (v == null || v == DBNull.Value)
                return DBNull.Value;
            return System.Convert.ToInt16(v, CultureInfo.GetCultureInfo("de-AT"));
        }
    }

    public class Int32Converter : ITypeConverter
    {
        public object Convert(object v)
        {
            if (v == null || v == DBNull.Value)
                return DBNull.Value;
            return System.Convert.ToInt32(v, CultureInfo.GetCultureInfo("de-AT"));
        }
    }

    public class BoolConverter : ITypeConverter
    {
        public object Convert(object v)
        {
            if (v == null || v == DBNull.Value)
                return DBNull.Value;
            object dest_val;
            // try string convertions
            if (v is string)
            {
                var s = ((string)v).ToLower();
                if (s.Contains("yes"))
                    dest_val = true;
                else if (s.Contains("no"))
                    dest_val = false;
                else if (s.Contains("ja"))
                    dest_val = true;
                else if (s.Contains("nein"))
                    dest_val = false;
                else if (s.Contains("-1"))
                    dest_val = true;
                else if (s.Contains("1"))
                    dest_val = true;
                else if (s.Contains("0"))
                    dest_val = false;
                else
                {
                    dest_val = DBNull.Value;
                    // AddError("Unable to convert '{0}' to a boolean", v);
                }
            }
            else if (v is int)
            {
                var i = (int)v;
                dest_val = i != 0;
            }
            else
            {
                // try other
                dest_val = System.Convert.ToBoolean(v, CultureInfo.GetCultureInfo("de-AT"));
            }

            return dest_val;
        }
    }

    public class DateTimeConverter : ITypeConverter
    {
        private static readonly Regex RegExYear = new Regex("^(\\d{4})$");
        private static readonly Regex RegExYearMonth = new Regex("^(\\d{4})/(\\d{2})$");

        public virtual object Convert(object v)
        {
            if (v == null || v == DBNull.Value)
                return DBNull.Value;

            try
            {
                return System.Convert.ToDateTime(v, CultureInfo.GetCultureInfo("de-AT"));
            }
            catch
            {
                // ignore, continue
            }

            try
            {
                // Try some regex
                if (v is string)
                {
                    var s = (string)v;

                    var m = RegExYearMonth.Match(s);
                    if (m != null && m.Groups.Count == 3)
                    {
                        var month = int.Parse(m.Groups[2].Value);
                        if (0 < month && month < 13)
                        {
                            return new DateTime(
                                int.Parse(m.Groups[1].Value),
                                month,
                                1);
                        }
                    }
                    m = RegExYear.Match(s);
                    if (m != null && m.Groups.Count == 2)
                    {
                        return new DateTime(
                            int.Parse(m.Groups[1].Value),
                            1,
                            1);
                    }
                }
            }
            catch
            {
                // ignore, continue
            }

            return DBNull.Value;
        }
    }

    public class SqlServerDateTimeConverter : DateTimeConverter
    {
        private static readonly DateTime SqlMinValue = new DateTime(1753, 1, 1);
        private static readonly DateTime SqlMaxValue = new DateTime(9999, 12, 31);

        public override object Convert(object v)
        {
            var result = base.Convert(v);
            if (result is DateTime)
            {
                var d = (DateTime)result;
                if (d < SqlMinValue || d > SqlMaxValue)
                    return DBNull.Value;
            }
            return result;
        }
    }
}
