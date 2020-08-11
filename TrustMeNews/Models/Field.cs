﻿using System.Text.Json.Serialization;
using System.Text.Json;


namespace TrustMeNews.Models
{
    public class Field
    {
        public string headline { get; set; }
        public string standfirst { get; set; }

        [JsonPropertyName("byline")]
        public string Author { get; set; }

        public string main { get; set; }
        public string body { get; set; }
        public string thumbnail { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Field>(this);
    }
}
