namespace QvaPay.Sdk.Clients
{
    public interface IEndpointData
    {
        string BaseUrl { get; set; }
    }

    public class OpenEndpoints : IEndpointData
    {
        public string BaseUrl { get; set; }

        public OpenEndpoints(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
    }

    public class AppEndpoints : IEndpointData
    {
        public string BaseUrl { get; set; }
        public string Id { get; set; }
        public string Secret { get; set; }

        public AppEndpoints(string baseUrl, string id, string secret)
        {
            BaseUrl = baseUrl;
            Id = id;
            Secret = secret;
        }
    }

    public class UserEndpoints : IEndpointData
    {
        public string BaseUrl { get; set; }
        public string Token { get; set; }

        public UserEndpoints(string baseUrl, string token)
        {
            BaseUrl = baseUrl;
            Token = token;
        }
    }
}
