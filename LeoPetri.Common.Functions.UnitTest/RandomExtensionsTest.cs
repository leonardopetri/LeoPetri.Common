using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
{
    public class RandomExtensionsTest
    {
        [Fact]
        public void NextCpfTest()
        {
            Assert.True(CountryIdFunctions.IsCpfValid(new Random().NextCpf()));
        }

        [Fact]
        public void NextCnpjTest()
        {
            Assert.True(CountryIdFunctions.IsCnpjValid(new Random().NextCnpj()));
        }
    }
}
