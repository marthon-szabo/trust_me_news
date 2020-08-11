using System.Text.Json.Serialization;
using System.Text.Json;


namespace TrustMeNews.Models
{
    public class Field
    {
        public string headline { get; set; }
        public string standfirst { get; set; }
        //author
        public string byline { get; set; }
        public string main { get; set; }
        public string bodyText { get; set; }

        //picture
        public string thumbnail { get; set; }
        public string trailText { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Field>(this);
    }
}
