using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeoPetri.Common.Domain.UnitTest
{
    public class AddressTest
    {
        [Fact]
        public void AddressCreateTest()
        {
            var address = new Address()
            {
                Street = "rua aimberê",
                District = "vila CuruÇA",
                State = new State() { Name = "são PAULO", Abbreviation = "sP" },
                City = "Santo André",
                Complement = "apto. 72",
                Country = "Brasil",
                Number = 1010,
                ZipCode = "9080320"
            };

            Assert.Equal("Rua Aimberê, 1010, Apto. 72, Vila Curuça, Santo André - SP, 09080-320", address.ToString());
        }
    }
}
