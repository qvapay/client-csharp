using QvaPay.Net.Objects.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace QvaPay.Net.Objects.Authentication
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
