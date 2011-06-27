namespace Kistl.App.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;

    [Implementor]
    public static class CommonCalendarRuleActions
    {
        [Invocation]
        public static void ToString(CommonCalendarRule obj, MethodReturnEventArgs<System.String> e)
        {
            e.Result = e.Result + "; every day";
        }

        [Invocation]
        public static void AppliesTo(CommonCalendarRule obj, MethodReturnEventArgs<System.Boolean> e, System.DateTime date)
        {
            // Always true if valid
            e.Result = obj.CheckValidDate(date);
        }
    }
}