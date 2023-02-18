using System.Text.Json.Serialization;

namespace QvaPay.Sdk
{
    public class SingleError
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
