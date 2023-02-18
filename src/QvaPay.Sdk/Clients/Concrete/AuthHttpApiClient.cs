using System;
using QvaPay.Sdk.Objects.Authentication;
using RestSharp;
using System.Text.Json;
using System.Threading.Tasks;

namespace QvaPay.Sdk.Clients.Concrete
{
    public class AuthHttpApiClient : HttpApiClient
    {
        private const string LOGIN_ENDPOINT = "/auth/login";
        private const string LOGOUT_ENDPOINT = "/auth/logout";
        public AuthHttpApiClient(IEndpointData endpointData)
            : base(endpointData) { }

        protected override RestRequest TransformHeaders(RestRequest request)
        {
            return request;
        }

        #region Login
        RestRequest LoginRequest(string email, string password)
        {
            var userForAuthentication = new UserForAuthentication
            {
                Email = email,
                Password = password
            };

            this.ValidateModel(userForAuthentication);

            return new RestRequest(resource: LOGIN_ENDPOINT, method: Method.Post)
                .AddBody(JsonSerializer.Serialize(userForAuthentication), "application/json");
        }

        public async Task<UserForAuthenticationResponse> LoginAsync(string email, string password)
        {
            return await ExecuteAsync<UserForAuthenticationResponse>(LoginRequest(email: email, password: password));
        }
        #endregion

        #region Logout
        RestRequest LogoutRequest(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentException(nameof(token));

            return new RestRequest(resource: LOGOUT_ENDPOINT, method: Method.Get)
                .AddHeader("Authorization", $"Bearer {token}");
        }
        
        public async Task<UserLogoutResponse> LogoutAsync(string token)
        {
            return await ExecuteAsync<UserLogoutResponse>(LogoutRequest(token: token));
        }
        #endregion
    }
}
