using RestSharp;
using System;
using System.Threading.Tasks;

namespace QvaPay.Sdk.Clients
{
    public abstract class HttpApiClient
    {
        private readonly RestClient _restClient;

        public HttpApiClient(IEndpointData endpointData)
        {
            var options = new RestClientOptions
            {
                RemoteCertificateValidationCallback = default,
                BaseUrl = new Uri(endpointData.BaseUrl)
            };
            _restClient = new RestClient(options);
        }

        protected async Task<T> ExecuteAsync<T>(RestRequest request) where T : new()
        {
            request = TransformHeaders(request);
            var response = await _restClient.ExecuteAsync<T>(request);
            response.ProcessRestResponse();
            return response.Data;
        }

        protected async Task ExecuteAsync(RestRequest request)
        {
            request = TransformHeaders(request);
            var response = await _restClient.ExecuteAsync(request);
            response.ProcessRestResponse();
        }

        protected abstract RestRequest TransformHeaders(RestRequest request);
    }
}
