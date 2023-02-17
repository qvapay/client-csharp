using QvaPay.Net.Clients;
using QvaPay.Net.Clients.Concrete;

namespace QvaPay.Net.Tests
{
    [TestClass]
    public class AuthTests
    {
        [TestMethod]
        public void LoginTest()
        {
            var authClient = new AuthHttpApiClient(QvaPayEnvironment.OPEN_PROD);

            var authTest = authClient.Login("soporte@bitremesas.com", "!DMrk37&7CNd");

            authTest.Wait();

            var result = authTest.Result;

            Assert.IsTrue(authTest.Result.IsSuccessful);
        }
    }
}