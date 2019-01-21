using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
{
    public class EmailFunctionsShould
    {
        [Theory]
        [InlineData("leonardo.petri@gmail.com")]
        [InlineData("leonardopetri@gmail.com")]
        [InlineData("leonardo@com.com")]
        public void BeValid(string email)
        {
            var valid = EmailFunctions.IsValid(email);

            Assert.True(valid);
        }

        [Theory]
        [InlineData("")]
        [InlineData("leonardo")]
        [InlineData("@com")]
        [InlineData("leonardo@com")]
        [InlineData("leonardo@.com")]
        [InlineData("leonardo@com.")]
        public void BeInvalid(string email)
        {
            var notValid = EmailFunctions.IsValid(email);

            Assert.False(notValid);
        }
    }
}
