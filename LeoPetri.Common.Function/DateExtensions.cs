using System;
using System.Globalization;

namespace LeoPetri.Common.Function
{
    public static class DateExtensions
    {
        public static T DateDiff<T>(this DateTime fromDate, DateIntervals interval, DateTime toDate) where T: struct
        {
            double difference;
            switch (interval)
            {
                case DateIntervals.Day:
                    difference = DateDiffDay(fromDate, toDate);
                    break;
                case DateIntervals.Month:
                    difference = DateDiffMonth(fromDate, toDate);
                    break;
                case DateIntervals.Year:
                    difference = DateDiffYear(fromDate, toDate);
                    break;
                case DateIntervals.Hour:
                    difference = DateDiffHour(fromDate, toDate);
                    break;
                case DateIntervals.Minute:
                    difference = DateDiffMinute(fromDate, toDate);
                    break;
                case DateIntervals.Second:
                    difference = DateDiffSecond(fromDate, toDate);
                    break;
                case DateIntervals.Millisecond:
                    difference = DateDiffMillisecond(fromDate, toDate);
                    break;
                case DateIntervals.Tick:
                    difference = DateDiffTick(fromDate, toDate);
                    break;
                default:
                    difference = DateDiffTick(fromDate, toDate);
                    break;
            }

            return (T)Convert.ChangeType(difference, typeof(T));
        }

        private static double DateDiffTick(DateTime fromDate, DateTime toDate)
        {
            return (toDate.Ticks - fromDate.Ticks);
        }

        private static double DateDiffMillisecond(DateTime fromDate, DateTime toDate)
        {
            return (toDate - fromDate).TotalMilliseconds;
        }

        private static double DateDiffSecond(DateTime fromDate, DateTime toDate)
        {
            return (toDate - fromDate).TotalSeconds;
        }

        private static double DateDiffMinute(DateTime fromDate, DateTime toDate)
        {
            return (toDate - fromDate).TotalMinutes;
        }

        private static double DateDiffHour(DateTime fromDate, DateTime toDate)
        {
            return (toDate - fromDate).TotalHours;
        }

        private static double DateDiffYear(DateTime fromDate, DateTime toDate)
        {
            if (toDate.Year.Equals(fromDate.Year) && toDate.Month.Equals(fromDate.Month))
            {
                return 0;
            }

            var calendar = new GregorianCalendar();

            int compareDay = toDate.Day;
            int compareDaysPerMonth = calendar.GetDaysInMonth(fromDate.Year, fromDate.Month);
            if (compareDay > compareDaysPerMonth)
            {
                compareDay = compareDaysPerMonth;
            }

            DateTime compareDate = new DateTime(fromDate.Year, toDate.Month, compareDay,
                toDate.Hour, toDate.Minute, toDate.Second, toDate.Millisecond);

            if (toDate > fromDate)
            {
                if (compareDate < fromDate)
                {
                    compareDate = compareDate.AddYears(1);
                }
            }
            else
            {
                if (compareDate > fromDate)
                {
                    compareDate = compareDate.AddYears(-1);
                }
            }

            return toDate.Year - calendar.GetYear(compareDate);
        }

        private static double DateDiffMonth(DateTime fromDate, DateTime toDate)
        {
            if (toDate.Date.Equals(fromDate.Date))
            {
                return 0;
            }

            var calendar = new GregorianCalendar();

            int compareDay = toDate.Day;
            int compareDaysPerMonth = calendar.GetDaysInMonth(fromDate.Year, fromDate.Month);
            if (compareDay > compareDaysPerMonth)
            {
                compareDay = compareDaysPerMonth;
            }

            DateTime compareDate = new DateTime(fromDate.Year, fromDate.Month, compareDay,
                toDate.Hour, toDate.Minute, toDate.Second, toDate.Millisecond);

            if (toDate > fromDate)
            {
                if (compareDate < fromDate)
                {
                    compareDate = compareDate.AddMonths(1);
                }
            }
            else
            {
                if (compareDate > fromDate)
                {
                    compareDate = compareDate.AddMonths(-1);
                }
            }
            return
            ((toDate.Year * 12) + toDate.Month) -
            ((calendar.GetYear(compareDate) * 12) + calendar.GetMonth(compareDate));
        }

        private static double DateDiffDay(DateTime fromDate, DateTime toDate)
        {
            return (toDate - fromDate).TotalDays;
        }
    }
}
