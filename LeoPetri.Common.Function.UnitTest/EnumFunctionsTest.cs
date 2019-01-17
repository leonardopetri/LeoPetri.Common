using System;
using System.ComponentModel;
using Xunit;

namespace LeoPetri.Common.Function.UnitTest
{
    public class EnumFunctionsTest
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
        [InlineData("Enum1Default", TestEnum.Enum1)]
        [InlineData("Enum2Default", TestEnum.Enum2)]
        [InlineData("Enum3", TestEnum.Enum3)]
        public void ToEnumFromDafaultValueTest(string dafaultValue, TestEnum testEnumExpected)
        {
            Assert.Equal(testEnumExpected, EnumFunctions.ToEnumFromDefaulValue<TestEnum>(dafaultValue));
        }

        [Theory]
        [InlineData("Enum1Description", TestEnum.Enum1)]
        [InlineData("Enum2Description", TestEnum.Enum2)]
        [InlineData("Enum3", TestEnum.Enum3)]
        public void ToEnumFromDescriptionTest(string description, TestEnum testEnumExpected)
        {
            Assert.Equal(testEnumExpected, EnumFunctions.ToEnumFromDescription<TestEnum>(description));
        }

        [Theory]
        [InlineData("Enum4Default")]
        [InlineData("Enum5Default")]
        [InlineData("Enum")]
        public void ToEnumFromDafaultValueErrorTest(string dafaultValue)
        {
            var exception = Assert.Throws<ArgumentException>(() => EnumFunctions.ToEnumFromDefaulValue<TestEnum>(dafaultValue));
            Assert.Equal("Default value does not match any enum value.", exception.Message);
        }

        [Theory]
        [InlineData("Enum6Description")]
        [InlineData("Enum5Description")]
        [InlineData("Enum")]
        public void ToEnumFromDescriptionErrorTest(string description)
        {
            var exception = Assert.Throws<ArgumentException>(() => EnumFunctions.ToEnumFromDescription<TestEnum>(description));
            Assert.Equal("Description does not match any enum value.", exception.Message);
        }
    }
}
