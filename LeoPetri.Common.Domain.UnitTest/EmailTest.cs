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

            Assert.Equal("Not a valid email address format.", exception.Message);
        }

        [Theory]
        [InlineData("leonardo.petri@gmail.com")]
        [InlineData("leonardopetri@gmail.com")]
        [InlineData("leonardo@com.com")]
        public void EmailIsValidTest(string email)
        {
            var valid = Email.IsValid(email);

            Assert.True(valid);
        }

        [Theory]
        [InlineData("")]
        [InlineData("leonardo")]
        [InlineData("@com")]
        [InlineData("leonardo@com")]
        [InlineData("leonardo@.com")]
        [InlineData("leonardo@com.")]
        public void EmailIsNotValidTest(string email)
        {
            var notValid = Email.IsValid(email);

            Assert.False(notValid);
        }
    }
}
