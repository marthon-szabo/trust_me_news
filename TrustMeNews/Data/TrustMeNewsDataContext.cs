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
        public DbSet<User> Users { get; set; }

        public DbSet<Comment> MyProperty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Category");
        }
    }
}
