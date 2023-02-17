using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace QvaPay.Net.Objects.Authentication
{
    public class UserForAuthentication
    {
        [JsonPropertyName("email")]
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        [JsonPropertyName("password")]
        [Required]
        public string? Password { get; set; }
    }
}
