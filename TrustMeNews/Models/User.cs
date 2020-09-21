using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public char Password { get; set; }

        [Required]
        [RegularExpression(@"[:alpha:]@{1}[:alpha:][:punct:]")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public override string ToString()
        {
            return $"User ID: {UserId}, Username: {UserName}, password: {Password}, email: {Email}";
        }
    }


}
