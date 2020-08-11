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
        public string Status { get { return "dsada"; } }
        
        public string UserTier { get; set; }
        
        public int Total{ get; set; }

        public List<ArticleDTO> results { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Article>(this);
        }
    }
}
