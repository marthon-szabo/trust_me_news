using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrustMeNews.Models
{

    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        
        public string Content { get; set; }
    }
}