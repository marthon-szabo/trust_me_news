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
        [JsonPropertyName("id")]
        public string Id { get { return "dsada"; } }
        
        [JsonPropertyName("sectionId")]
        public string Genre { get; set; }
        
        [JsonPropertyName("webApplicationName")]
        public DateTime PublicationTime { get; set; }

        [JsonPropertyName("webTitle")]
        public string Title { get; set; }

        [JsonPropertyName("fields.standfirst")]
        public string  Headline { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Article>(this);
        }
    }
}
