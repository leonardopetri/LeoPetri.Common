using System;
using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
{
    public class HasherFunctionsShould
    {
        [Theory]
        [InlineData("Passwaord")]
        [InlineData("~3Q7_M!Wb3r3]Vv{")]
        [InlineData("8N[?{aS9Hy't+5gx")]
        [InlineData("h8!2GJ!6`DBX?k5g")]
        public void BeValid(string password)
        {
            var hash = HasherFunctions.GetHash(password);
            Assert.True(HasherFunctions.IsMatch(hash, password));

            var guid = Guid.NewGuid();
            hash = HasherFunctions.GetHash(password, guid);
            Assert.True(HasherFunctions.IsMatch(hash, password, guid));
        }

        [Theory]
        [InlineData("Passwaord")]
        [InlineData("~3Q7_M!Wb3r3]Vv{")]
        [InlineData("8N[?{aS9Hy't+5gx")]
        [InlineData("h8!2GJ!6`DBX?k5g")]
        public void BeInvalid(string password)
        {
            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();
            var hash = HasherFunctions.GetHash(password, guid1);
            Assert.False(HasherFunctions.IsMatch(hash, password, guid2));
        }
    }
}
