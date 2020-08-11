using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;


namespace TrustMeNews.Models
{
    public class Article
    {
        public string headline { get; set; }
        public string standfirst { get; set; }

        [JsonPropertyName("byline")]
        public string Author { get; set; }

        public string main { get; set; }
        public string body { get; set; }
        public string thumbnail { get; set; }


        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Article>(this);
        }
    }
}
