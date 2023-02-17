using QvaPay.Net.Objects.Authentication;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QvaPay.Net.Clients.Concrete
{
    public class AuthHttpApiClient : HttpApiClient
    {
        public AuthHttpApiClient(IEndpointData endpointData)
            : base(endpointData) { }

        protected override RestRequest TransformHeaders(RestRequest request)
        {
            return request;
        }

        RestRequest LoginRequest(string email, string password)
        {
            var userForAuthentication = new UserForAuthentication
            {
                Email = email,
                Password = password
            };

            return new RestRequest(resource: $"/auth/login", method: Method.Post)
                .AddBody(JsonSerializer.Serialize(userForAuthentication), "application/json");
        }

        public async Task<RestResponse<UserForAuthenticationResponse>> Login(string email, string password)
        {
            return await ExecuteAsync<UserForAuthenticationResponse>(LoginRequest(email: email, password: password));
        }
    }
}
