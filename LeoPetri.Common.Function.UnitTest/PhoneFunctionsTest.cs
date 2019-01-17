using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeoPetri.Common.Function.UnitTest
{
    public class PhoneFunctionsTest
    {
        [Theory]
        [InlineData(1119282871, "(11) 1928-2871")]
        [InlineData(11192822871, "(11) 19282-2871")]
        public void ToBrazilianFormatLongTest(ulong number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToBrazilianFormat(number);

            Assert.Equal(formatedNumber, formated);
        }

        [Theory]
        [InlineData("1119282871", "(11) 1928-2871")]
        [InlineData("11192822871", "(11) 19282-2871")]
        public void ToBrazilianFormatStringTest(string number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToBrazilianFormat(number);

            Assert.Equal(formatedNumber, formated);
        }

        [Theory]
        [InlineData(551119282871, "+55 (11) 1928-2871")]
        [InlineData(5511192822871, "+55 (11) 19282-2871")]
        public void ToBrazilianFormatWithDDILongTest(ulong number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToBrazilianFormatWithDdi(number);

            Assert.Equal(formatedNumber, formated);
        }

        [Theory]
        [InlineData("551119282871", "+55 (11) 1928-2871")]
        [InlineData("5511192822871", "+55 (11) 19282-2871")]
        [InlineData("005511192822871", "+55 (11) 19282-2871")]
        public void ToBrazilianFormatWithDDIStringTest(string number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToBrazilianFormatWithDdi(number);

            Assert.Equal(formatedNumber, formated);
        }
        
        [Theory]
        [InlineData(1119282871, "(111) 928-2871")]
        [InlineData(1119222871, "(111) 922-2871")]
        public void ToNorthAmericanFormatLongTest(ulong number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToNorthAmericanFormat(number);

            Assert.Equal(formatedNumber, formated);
        }

        [Theory]
        [InlineData("1119282871", "(111) 928-2871")]
        [InlineData("1119222871", "(111) 922-2871")]
        public void ToNorthAmericanFormatStringTest(string number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToNorthAmericanFormat(number);

            Assert.Equal(formatedNumber, formated);
        }

        [Theory]
        [InlineData(11119282871, "+1 (111) 928-2871")]
        [InlineData(11119222871, "+1 (111) 922-2871")]
        public void ToNorthAmericanFormatWithDDILongTest(ulong number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToNorthAmericanFormatWithDdi(number);

            Assert.Equal(formatedNumber, formated);
        }

        [Theory]
        [InlineData("11119282871", "+1 (111) 928-2871")]
        [InlineData("11119222871", "+1 (111) 922-2871")]
        [InlineData("0011119222871", "+1 (111) 922-2871")]
        public void ToNorthAmericanFormatWithDDIStringTest(string number, string formatedNumber)
        {
            var formated = PhoneFunctions.ToNorthAmericanFormatWithDdi(number);

            Assert.Equal(formatedNumber, formated);
        }
    }
}
