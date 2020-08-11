using System;
using System.Collections.Generic;
using System.Text.Json;

namespace TrustMeNews.Models
{
    public class Article
    {
        public string id { get; set; }
        public string type { get; set; }
        public string sectionId { get; set; }
        public string sectionName { get; set; }
        public DateTime webPublicationDate { get; set; }
        public string webTitle { get; set; }

        public Field fields { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Article>(this);
    }

    public class Response
    {
        public List<Article> articles { get; set; }
    }

    public class Root
    {
        public Response response { get; set; }
    }
}
