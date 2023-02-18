using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace QvaPay.Net
{
    public class SingleError
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
