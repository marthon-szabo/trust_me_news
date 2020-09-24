using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrustMeNews.Models
{

    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        
        public string Content { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public User User { get; set; }
    }
}