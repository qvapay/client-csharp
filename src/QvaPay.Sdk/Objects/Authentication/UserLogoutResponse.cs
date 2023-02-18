using System.Net.Http;
using System.Text.Json.Serialization;

namespace QvaPay.Sdk.Objects.Authentication
{
    public class UserLogoutResponse
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}