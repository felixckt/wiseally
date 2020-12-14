using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime;

namespace TimeSheet.Util
{
    public static class Util
    {
        

        public static int GetWeekOfDate(DateTime paraDate)
        {

            DateTime year1stDate = new DateTime(paraDate.Year, 1, 1);
            DayOfWeek dayweekofyyyy0101 = year1stDate.DayOfWeek;
            int diff = dayweekofyyyy0101 - DayOfWeek.Monday;
            DateTime year1stWeek = year1stDate.AddDays(-diff);
            int dayofyear = (paraDate - year1stWeek).Days;
            int weeks = Convert.ToInt32(dayofyear / 7) + 1;
            return weeks;

        }
        public static int GetWeekOfDate()
        {
            DateTime year1stDate = new DateTime( DateTime.Today.Year, 1, 1);
            DayOfWeek dayweekofyyyy0101 = year1stDate.DayOfWeek;
            int diff = dayweekofyyyy0101 - DayOfWeek.Monday;
            DateTime year1stWeek = year1stDate.AddDays(-diff);
            int dayofyear = (DateTime.Today - year1stWeek).Days;
            int weeks = Convert.ToInt32(dayofyear / 7) + 1;

            return weeks;

        }

        



    }
}
