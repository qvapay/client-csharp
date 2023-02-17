using RestSharp;
using System;
using System.Threading.Tasks;

namespace QvaPay.Net.Clients
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

        protected async Task<RestResponse<T>> ExecuteAsync<T>(RestRequest request) where T : new()
        {
            request = TransformHeaders(request);
            var response = await _restClient.ExecuteAsync<T>(request);

            return response;
        }

        protected async Task<RestResponse> ExecuteAsync(RestRequest request)
        {
            request = TransformHeaders(request);
            var response = await _restClient.ExecuteAsync(request);

            return response;
        }

        protected abstract RestRequest TransformHeaders(RestRequest request);
    }
}
