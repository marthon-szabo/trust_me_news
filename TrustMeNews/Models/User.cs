using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrustMeNews.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }

        public List<Result> Articles { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
