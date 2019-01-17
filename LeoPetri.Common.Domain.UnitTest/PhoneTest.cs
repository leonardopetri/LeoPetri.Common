using Xunit;

namespace LeoPetri.Common.Domain.UnitTest
{
    public class PhoneTest
    {
        [Theory]
        [InlineData(11234512342)]
        [InlineData(1123452342)]
        public void CreatePhoneOnlyNumberLongTest(ulong number)
        {
            var phone = new Phone(number);

            Assert.Equal(ushort.Parse(number.ToString().Substring(0, 2)), phone.Ddd);
            Assert.Equal(ulong.Parse(number.ToString().Substring(2)), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData("11234512342")]
        [InlineData("1123452342")]
        public void CreatePhoneOnlyNumberStringTest(string number)
        {
            var phone = new Phone(number);

            Assert.Equal(ushort.Parse(number.Substring(0, 2)), phone.Ddd);
            Assert.Equal(ulong.Parse(number.Substring(2)), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData("11", "234512342")]
        [InlineData("11", "23452342")]
        public void CreatePhoneDDDStringAndNumberStringTest(string ddd, string number)
        {
            var phone = new Phone(ddd, number);

            Assert.Equal(ushort.Parse(ddd), phone.Ddd);
            Assert.Equal(ulong.Parse(number), phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData(11, 234512342)]
        [InlineData(11, 23452342)]
        public void CreatePhoneDDDShortAndNumberLongTest(ushort ddd, ulong number)
        {
            var phone = new Phone(ddd, number);

            Assert.Equal(ddd, phone.Ddd);
            Assert.Equal(number, phone.Number);
            Assert.Equal(55, phone.Ddi);
        }

        [Theory]
        [InlineData(1, 11, 234512342)]
        [InlineData(1, 11, 23452342)]
        public void CreatePhoneDDIShortDDDShortAndNumberLongTest(ushort ddi, ushort ddd, ulong number)
        {
            var phone = new Phone(ddi, ddd, number);

            Assert.Equal(ddd, phone.Ddd);
            Assert.Equal(number, phone.Number);
            Assert.Equal(ddi, phone.Ddi);
        }

        [Theory]
        [InlineData("1", "11", "234512342")]
        [InlineData("1", "11", "23452342")]
        public void CreatePhoneDDIStringDDDStringAndNumberStringTest(string ddi, string ddd, string number)
        {
            var phone = new Phone(ddi, ddd, number);

            Assert.Equal(ushort.Parse(ddd), phone.Ddd);
            Assert.Equal(ulong.Parse(number), phone.Number);
            Assert.Equal(ushort.Parse(ddi), phone.Ddi);
        }

        [Theory]
        [InlineData(11, 234512342, "11234512342")]
        [InlineData(11, 23452342, "1123452342")]
        public void ToStringTest(ushort ddd, ulong number, string value)
        {
            var phone = new Phone(ddd, number);

            Assert.Equal(value, phone.ToString());
        }

        [Theory]
        [InlineData(1, 11, 234512342, "111234512342")]
        [InlineData(55, 11, 23452342, "551123452342")]
        [InlineData(320, 11, 23452342, "3201123452342")]
        public void ToStringWithDdiTest(ushort ddi, ushort ddd, ulong number, string value)
        {
            var phone = new Phone(ddi, ddd, number);

            Assert.Equal(value, phone.ToStringWithDdi());
        }
    }
}
