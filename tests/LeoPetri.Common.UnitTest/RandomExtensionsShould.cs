using LeoPetri.Common.Functions;
using System;
using Xunit;

namespace LeoPetri.Common.Extensions.UnitTest
{
    public class RandomExtensionsShould
    {
        [Fact]
        public void HaveNextValidCpf()
        {
            Assert.True(CountryIdFunctions.IsCpfValid(new Random().NextCpf()));
        }

        [Fact]
        public void HaveNextValidCnpj()
        {
            Assert.True(CountryIdFunctions.IsCnpjValid(new Random().NextCnpj()));
        }
    }
}
