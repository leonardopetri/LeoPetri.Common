using System;
using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
{
    public class HasherTest
    {
        [Theory]
        [InlineData("Passwaord")]
        [InlineData("~3Q7_M!Wb3r3]Vv{")]
        [InlineData("8N[?{aS9Hy't+5gx")]
        [InlineData("h8!2GJ!6`DBX?k5g")]
        public void HasherValidTest(string password)
        {
            var hash = Hasher.GetHash(password);
            Assert.True(Hasher.IsMatch(hash, password));

            var guid = Guid.NewGuid();
            hash = Hasher.GetHash(password, guid);
            Assert.True(Hasher.IsMatch(hash, password, guid));
        }

        [Theory]
        [InlineData("Passwaord")]
        [InlineData("~3Q7_M!Wb3r3]Vv{")]
        [InlineData("8N[?{aS9Hy't+5gx")]
        [InlineData("h8!2GJ!6`DBX?k5g")]
        public void HasherInvalidTest(string password)
        {
            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();
            var hash = Hasher.GetHash(password, guid1);
            Assert.False(Hasher.IsMatch(hash, password, guid2));
        }
    }
}
