using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Data;

namespace TrustMeNews.Models
{
    public class UserRepository : IRepository<User>
    {
        private readonly TrustMeNewsDataContext dbContext;

        public UserRepository(TrustMeNewsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User Create(User model)
        {
            dbContext.Users.Add(model);
            dbContext.SaveChanges();
            return model;
        }

        public User Delete(int id)
        {
            User toRemove = dbContext.Users.Find(id);

            if (toRemove != null)
            {
                dbContext.Remove(toRemove);
                dbContext.SaveChanges();
            }

            return toRemove;
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Users;
        }

        public User Get(int id)
        {
            return dbContext.Users.Find(id);
        }

        public User Update(User userChanges)
        {
            var user = dbContext.Users.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return userChanges;
        }
    }
}
