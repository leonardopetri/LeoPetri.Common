using System.ComponentModel;
using Xunit;

namespace LeoPetri.Common.Extensions.UnitTest
{
    public class EnumExtensionsShould
    {
        public enum TestEnum
        {
            [DefaultValue("Enum1Default")]
            [Description("Enum1Description")]
            Enum1,
            [DefaultValue("Enum2Default")]
            [Description("Enum2Description")]
            Enum2,
            Enum3
        }

        [Theory]
        [InlineData(TestEnum.Enum1, "Enum1Default")]
        [InlineData(TestEnum.Enum2, "Enum2Default")]
        [InlineData(TestEnum.Enum3, "Enum3")]
        public void GetDafaultValue(TestEnum testEnum, string dafaultValueExpected)
        {
            Assert.Equal(dafaultValueExpected, testEnum.GetDefaultValue());
        }

        [Theory]
        [InlineData(TestEnum.Enum1, "Enum1Description")]
        [InlineData(TestEnum.Enum2, "Enum2Description")]
        [InlineData(TestEnum.Enum3, "Enum3")]
        public void GetDescription(TestEnum testEnum, string descriptionExpected)
        {
            Assert.Equal(descriptionExpected, testEnum.GetDescription());
        }
    }
}
