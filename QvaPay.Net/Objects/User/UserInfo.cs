using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace QvaPay.Net.Objects.User
{
    /// <summary>
    /// Me Information
    /// </summary>
    public class UserInfo
    {
        [JsonPropertyName("uuid")]
        public Guid UserId { get; set; }
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("lastname")]
        public string? Lastname { get; set; }
        [JsonPropertyName("bio")]
        public string? Bio { get; set; }
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }
        [JsonPropertyName("kyc")]
        public bool KYC { get; set; }
    }
}
