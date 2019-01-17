using System;
using Xunit;

namespace LeoPetri.Common.Domain.UnitTest
{
    public class EmailTest
    {
        [Fact]
        public void EmailCreateTest()
        {
            var email = new Email("leonardopetri@gmail.com");

            Assert.Equal("leonardopetri@gmail.com", email.Address);
            Assert.Equal("gmail.com", email.Domain);
            Assert.Equal("leonardopetri", email.LocalPart);
        }

        [Fact]
        public void EmailCreateErrorTest()
        {
            var exception = Assert.Throws<FormatException>(() => new Email("leonardopetrigmail.com"));

            Assert.Equal("Not a valid email address.", exception.Message);
        }
    }
}
