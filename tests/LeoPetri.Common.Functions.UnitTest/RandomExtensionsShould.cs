using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
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
