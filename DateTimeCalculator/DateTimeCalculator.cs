using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCalculator
{
    class DateTimeCalc
    {
        public static int Dil(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }
        public static DateTime PlusDay(DateTime data, int k)
        {

            new DateTime(data.Year, data.Month, data.Day + k);

            return new DateTime(data.Year, data.Month, data.Day + k);
        }
        public static DateTime PlusYear(DateTime data, int k)
        {
            return new DateTime(data.Year + k, data.Month, data.Day);
        }
        public static DateTime PlusMonth(DateTime data, int k)
        {
            int dayInMonth=DateTime.DaysInMonth(data.Year, data.Month);
            bool dayInYuear = DateTime.IsLeapYear(data.Year);

            return new DateTime(data.Year, data.Month + k, data.Day);
        }
        public static DateTime PlusHour(DateTime data, int k)
        {
            return new DateTime(data.Year, data.Month, data.Day, data.Hour + k, data.Minute, data.Second);

        }
        
    }
}
