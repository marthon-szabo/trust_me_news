using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    public class Genre
    {
        public string id { get; set; }
        public string webTitle { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Genre>(this);

    }

    public class GenreResponse
    {
        public List<Genre> results { get; set; }
    }

    public class GenreRoot
    {
        public GenreResponse response { get; set; }
    }
}
