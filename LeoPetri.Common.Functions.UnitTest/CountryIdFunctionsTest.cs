using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
{
    public class CountryIdFunctionsTest
    {
        [Theory]
        [InlineData("018.603.096-74")]
        [InlineData("018.603.09674")]
        [InlineData("018.603096-74")]
        [InlineData("018.60309674")]
        [InlineData("01860309674")]
        [InlineData("198.263.953-90")]
        [InlineData("455.395.847-32")]
        [InlineData("671.285.638-81")]
        public void IsCpfValidTest(string cpf)
        {
            Assert.True(CountryIdFunctions.IsCpfValid(cpf));
        }

        [Theory]
        [InlineData("018.603.093-74")]
        [InlineData("01860309374")]
        [InlineData("198.263.53-90")]
        [InlineData("455.396.847-32")]
        [InlineData("671.285.638-1")]
        public void IsCpfInvalidTest(string cpf)
        {
            Assert.False(CountryIdFunctions.IsCpfValid(cpf));
        }

        [Theory]
        [InlineData("52.958.478/0001-22")]
        [InlineData("52.958.478/000122")]
        [InlineData("52.958.4780001-22")]
        [InlineData("52.958478/0001-22")]
        [InlineData("52.958478/000122")]
        [InlineData("52.9584780001-22")]
        [InlineData("52.958.478000122")]
        [InlineData("52.958478000122")]
        [InlineData("52958478000122")]
        [InlineData("529584780001-22")]
        [InlineData("52958478/000122")]
        [InlineData("67.488.702/0001-37")]
        [InlineData("93.641.881/0001-00")]
        [InlineData("05.968.349/0001-35")]
        public void IsCnpjValidTest(string cnpj)
        {
            Assert.True(CountryIdFunctions.IsCnpjValid(cnpj));
        }

        [Theory]
        [InlineData("52.958.472/0001-22")]
        [InlineData("52958472/000122")]
        [InlineData("67.488.502/0001-37")]
        [InlineData("93.641.881/0001-0")]
        [InlineData("05.968.349/0001-65")]
        public void IsCnpjInvalidTest(string cnpj)
        {
            Assert.False(CountryIdFunctions.IsCnpjValid(cnpj));
        }
    }
}
