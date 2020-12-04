using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    public class Content
    {
        public string id { get; set; }
        public string type { get; set; }
        public string sectionId { get; set; }
        public string sectionName { get; set; }
        public DateTime webPublicationDate { get; set; }
        public string webTitle { get; set; }

        public Field fields { get; set; }
    }

    public class ContentResponse
    {
        public string status { get; set; }
        public string userTier { get; set; }
        public int total { get; set; }
        public Content content { get; set; }
    }

    public class ContentRoot
    {
        public ContentResponse response { get; set; }
    }
}
