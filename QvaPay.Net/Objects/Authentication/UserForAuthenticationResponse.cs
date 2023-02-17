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
    }
}
