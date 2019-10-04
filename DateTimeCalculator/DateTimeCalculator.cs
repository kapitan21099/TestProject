using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCalculator
{
    class DateTimeCalc
    {
        public static DateTime PlusDay(DateTime data, int k)
        {
            int dayInMonth = DateTime.DaysInMonth(data.Year, data.Month);
            int summDays = data.Day + dayInMonth;//сумма дней в данном месяце
            int upMonth = data.Month;
            int upYear = data.Year;
            if ((k + data.Day) > dayInMonth)
            {
                do
                {
                    if ((k + data.Day) > summDays)
                    {
                        summDays += DateTime.DaysInMonth(data.Year, data.Month + 1);
                    }
                    upMonth++;
                }
                while (k > summDays);
                if (upMonth > (12 - data.Month))
                {
                    upYear += upMonth / 12;
                }
            }
            else
            {
                return new DateTime(data.Year, data.Month, data.Day + k);
            }
            int f = summDays % k;
            int g = upMonth % 12;
            return new DateTime(upYear, g, f);
        }
        public static DateTime PlusYear(DateTime data, int k)
        {
            return new DateTime(data.Year + k, data.Month, data.Day);
        }
        public static DateTime PlusMonth(DateTime data, int k)
        {
            int dayInMonth = DateTime.DaysInMonth(data.Year, data.Month);

            return new DateTime(data.Year, data.Month + (k % dayInMonth), data.Day);
        }
        public static DateTime PlusHour(DateTime data, int k)
        {
            return new DateTime(data.Year, data.Month, data.Day, data.Hour + k, data.Minute, data.Second);

        }

    }
}
