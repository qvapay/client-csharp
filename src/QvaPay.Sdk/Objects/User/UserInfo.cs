using System;
using System.Text.Json.Serialization;

namespace QvaPay.Sdk.Objects.User
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
        [JsonPropertyName("profile_photo_path")]
        public string? ProfilePhotoPath { get; set; }
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }
        [JsonPropertyName("complete_name")]
        public string? FullName { get; set; }
        [JsonPropertyName("name_verified")]
        public string? NameVerified { get; set; }
        [JsonPropertyName("profile_photo_url")]
        public string? ProfilePhotoUrl { get; set; }
        [JsonPropertyName("average_rating")]
        public decimal AverageRating { get; set; }
    }
}
