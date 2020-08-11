using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    public class Fields
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
            return System.Text.Json.JsonSerializer.Serialize<Fields>(this);
        }

    }

    public class Result
    {
        public string id { get; set; }
        public string type { get; set; }
        public string sectionId { get; set; }
        public string sectionName { get; set; }
        public DateTime webPublicationDate { get; set; }
        public string webTitle { get; set; }

        public Fields fields { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Result>(this);
        }


    }

    public class Response
    {
        
        public List<Result> results { get; set; }
    }

    public class Root
    {
        public Response response { get; set; }
    }
}
