using QvaPay.Sdk.Objects.User;
using System.Text.Json.Serialization;

namespace QvaPay.Sdk.Objects.Authentication
{
    public class UserForAuthenticationResponse
    {
        [JsonPropertyName("accessToken")]
        public string? Token { get; set; }
        [JsonPropertyName("token_type")]
        public string? TokenType { get; set; }
        [JsonPropertyName("me")]
        public UserInfo? Me { get; set; }
    }
}
