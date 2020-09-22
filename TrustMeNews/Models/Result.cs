using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace TrustMeNews.Models
{
    public class Result
    {
        //ARTICLE
        [Key]
        public string id { get; set; }
        public string type { get; set; }
        public string sectionId { get; set; }
        public string sectionName { get; set; }
        public DateTime webPublicationDate { get; set; }
        public string webTitle { get; set; }

        public Field fields { get; set; }

        public User User { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Result>(this);
    }

    public class Response
    {
        public List<Result> results { get; set; }
    }

    public class Root
    {
        public Response response { get; set; }
        public Content content { get; set; }
    }

}
