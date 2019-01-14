using System.Text.RegularExpressions;
using Xunit;

namespace LeoPetri.Common.Function.UnitTest
{
    public class StringExtensionsTest
    {
        [Fact]
        public void NumbersOnlyTest()
        {
            var str = @"Leonardo (011)96565-9927/\_/\_38!$#*%�$()S  \|*-+.";
            str = str.NumbersOnly();

            Assert.False(Regex.Match(str, @"[^0-9]").Success);
        }

        [Fact]
        public void TextOnlyTest()
        {
            var str = @"Leonardo (011)96565-9927/\_/\_38!$#*%�$()S  \|*-+.";
            str = str.TextOnly();

            Assert.False(Regex.Match(str, @"[^a-zA-Z\s]").Success);
        }

        [Fact]
        public void NoSpecialCharTest()
        {
            var str = @"Leonardo (011)96565-9927/\_/\_38!$#*%�$()S  \|*-+.";
            str = str.NoSpecialChar();

            Assert.False(Regex.Match(str, @"[^a-zA-Z0-9\s]").Success);
        }

        [Fact]
        public void FirstWordTest()
        {
            var str = @"Leonardo Petri Silva";
            str = str.FirstWord();

            Assert.Equal("Leonardo", str);
        }

        [Fact]
        public void UpperFirstLetterTest()
        {
            var str = @"leonardo petri silva";
            str = str.ToUpperFirstLetter();

            Assert.Equal("Leonardo Petri Silva", str);
        }

        [Fact]
        public void UpperNameFirstLetterTest()
        {
            var str = @"leonardo de petri da silva";
            str = str.ToUpperFirstLetterName();

            Assert.Equal("Leonardo de Petri da Silva", str);
        }

        [Theory]
        [InlineData("sim")]
        [InlineData("s")]
        [InlineData("yes")]
        [InlineData("y")]
        [InlineData("true")]
        [InlineData("verdadeiro")]
        [InlineData("v")]
        [InlineData("1")]
        public void ToBooleanTrueTest(string str)
        {
            var boolean = str.ToBoolean();

            Assert.True(boolean);
        }

        [Theory]
        [InlineData("nao")]
        [InlineData("n�o")]
        [InlineData("no")]
        [InlineData("false")]
        [InlineData("n")]
        [InlineData("falso")]
        [InlineData("f")]
        [InlineData("0")]
        public void ToBooleanFalseTest(string str)
        {
            var boolean = str.ToBoolean();

            Assert.False(boolean);
        }
    }
}
