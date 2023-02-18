using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QvaPay.Sdk.Objects.Authentication
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
