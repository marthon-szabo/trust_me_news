using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Models;

namespace TrustMeNews.Data
{
    public class TrustMeNewsDataContext : DbContext
    {
        public TrustMeNewsDataContext(DbContextOptions<TrustMeNewsDataContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Result> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(user => user.Articles)
                .WithOne(article => article.User);

            modelBuilder.Entity<User>()
                .HasMany(user => user.Comments)
                .WithOne(comment => comment.User);
           
        }
    }
}