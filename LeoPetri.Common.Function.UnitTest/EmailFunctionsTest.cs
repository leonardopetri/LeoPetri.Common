using Xunit;

namespace LeoPetri.Common.Function.UnitTest
{
    public class EmailFunctionsTest
    {
        [Theory]
        [InlineData("leonardo.petri@gmail.com")]
        [InlineData("leonardopetri@gmail.com")]
        [InlineData("leonardo@com.com")]
        public void EmailIsValidTest(string email)
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
        public void EmailIsNotValidTest(string email)
        {
            var notValid = EmailFunctions.IsValid(email);

            Assert.False(notValid);
        }
    }
}
