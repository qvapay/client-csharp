namespace QvaPay.Sdk.Clients
{
    public static class QvaPayEnvironment
    {
        private const string PROD_BASE_URL = "https://qvapay.com/api";
        private const string SANDBOX_BASE_URL = "https://sandbox.qvapay.com/api";

        //Production Endpoints
        public static IEndpointData OPEN_PROD => new OpenEndpoints(PROD_BASE_URL);

        //Development Endpoints
        public static IEndpointData OPEN_SANDBOX => new OpenEndpoints(SANDBOX_BASE_URL);
    }
}
