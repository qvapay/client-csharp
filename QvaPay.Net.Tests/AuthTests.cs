using QvaPay.Net.Clients;
using QvaPay.Net.Clients.Concrete;
using QvaPay.Net.Exceptions;

namespace QvaPay.Net.Tests
{
    [TestClass]
    public class AuthTests
    {
        private AuthHttpApiClient Client { get; set; } = new AuthHttpApiClient(QvaPayEnvironment.OPEN_PROD);

        [TestMethod]
        public void LoginTest()
        {
            //Should be tested with valid credentials
            var authTest = Client.Login("validemail@mail.com", "ValidPassword");

            authTest.Wait();

            var result = authTest.Result;

            Assert.IsTrue(true);
        }

        [TestMethod]
        public async Task PasswordEmptyValidation()
        {
            //Will trigger error validating password 
            await Assert.ThrowsExceptionAsync<ValidationErrorException>(() => Client.Login("validemail@mail.com", ""));
        }

        [TestMethod]
        public async Task InvalidEmailValidation()
        {
            //Will trigger error validating email address
            await Assert.ThrowsExceptionAsync<ValidationErrorException>(() => Client.Login("validemail.mail.com", "ValidPassword"));
        }

        [TestMethod]
        public async Task LoginInvalidCredentials()
        {
            //Testing with wrong credentials
            await Assert.ThrowsExceptionAsync<HttpApiException<SingleError>>(() => Client.Login("validmail@gmail.com", "InvalidPassword"));
        }
    }
}