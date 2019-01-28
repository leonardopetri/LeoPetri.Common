using System;
using System.Globalization;
using Xunit;

namespace LeoPetri.Common.Extensions.UnitTest
{
    public class DateExtensionsShould
    {
        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 3)]
        [InlineData("2019-01-17", "2019-01-14", -3)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 10:18:32", 3)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:18:32", 3)]
        public void DateDiffByDaysTest(string fromDate, string toDate, int diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<int>(DateInterval.Day, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }

        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 72)]
        [InlineData("2019-01-17", "2019-01-14", -72)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 10:18:32", 72)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:18:32", 71)]
        public void DateDiffByHoursTest(string fromDate, string toDate, int diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<int>(DateInterval.Hour, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }


        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 4320)]
        [InlineData("2019-01-17", "2019-01-14", -4320)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 10:18:32", 4320)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:18:32", 4260)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:32", 4259)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:31", 4259)]
        public void DateDiffByMinutesTest(string fromDate, string toDate, int diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<int>(DateInterval.Minute, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }

        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 259200)]
        [InlineData("2019-01-17", "2019-01-14", -259200)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 10:18:32", 259200)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:18:32", 255600)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:32", 255540)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:31", 255539)]
        public void DateDiffBySecondsTest(string fromDate, string toDate, int diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<int>(DateInterval.Second, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }

        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 259200000)]
        [InlineData("2019-01-17", "2019-01-14", -259200000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 10:18:32", 259200000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:18:32", 255600000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:32", 255540000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:31", 255539000)]
        public void DateDiffByMilliSecondsTest(string fromDate, string toDate, int diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<int>(DateInterval.Millisecond, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }

        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 2592000000000)]
        [InlineData("2019-01-17", "2019-01-14", -2592000000000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 10:18:32", 2592000000000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:18:32", 2556000000000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:32", 2555400000000)]
        [InlineData("17/01/2019 10:18:32", "20/01/2019 09:17:31", 2555390000000)]
        public void DateDiffByTicksTest(string fromDate, string toDate, double diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<double>(DateInterval.Tick, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }
        
        [Theory]
        [InlineData("2019-01-17", "2019-01-20", 0)]
        [InlineData("2019-01-17", "2019-01-14", 0)]
        [InlineData("2019-01-17", "2018-12-14", -1)]
        [InlineData("2019-01-17", "2018-12-20", 0)]
        [InlineData("2019-01-17", "2019-02-20", 1)]
        [InlineData("17/01/2019 10:18:32", "17/02/2019 10:18:31", 0)]
        [InlineData("17/01/2019 10:18:32", "17/02/2019 10:17:32", 0)]
        [InlineData("17/01/2019 10:18:32", "17/02/2019 10:18:32", 1)]
        [InlineData("17/01/2019 10:18:32", "17/02/2019 11:18:32", 1)]
        [InlineData("17/01/2019 10:18:32", "17/02/2019 10:19:32", 1)]
        [InlineData("17/01/2019 10:18:32", "20/03/2019 09:17:31", 2)]
        public void DateDiffByMonthsTest(string fromDate, string toDate, double diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<double>(DateInterval.Month, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }

        [Theory]
        [InlineData("2019-01-17", "2020-01-20", 1)]
        [InlineData("2019-01-17", "2020-01-14", 0)]
        [InlineData("2019-01-17", "2018-01-14", -1)]
        [InlineData("2019-01-17", "2018-01-20", 0)]
        [InlineData("2019-01-17", "2019-02-20", 0)]
        [InlineData("17/01/2019 10:18:32", "17/01/2020 10:18:31", 0)]
        [InlineData("17/01/2019 10:18:32", "17/01/2020 10:17:32", 0)]
        [InlineData("17/01/2019 10:18:32", "17/01/2020 10:18:32", 1)]
        [InlineData("17/01/2019 10:18:32", "17/01/2020 11:18:32", 1)]
        [InlineData("17/01/2019 10:18:32", "17/01/2020 10:19:32", 1)]
        [InlineData("17/01/2019 10:18:32", "20/01/2021 09:17:31", 2)]
        public void DateDiffByYearsTest(string fromDate, string toDate, double diff)
        {
            Assert.Equal(diff, DateTime.Parse(fromDate, new CultureInfo("pt-BR")).DateDiff<int>(DateInterval.Year, DateTime.Parse(toDate, new CultureInfo("pt-BR"))));
        }
    }
}
