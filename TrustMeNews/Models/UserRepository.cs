using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Data;

namespace TrustMeNews.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly TrustMeNewsDataContext dbContext;

        public UserRepository(TrustMeNewsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User CreateUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public User DeleteUser(int id)
        {
            User toRemove = dbContext.Users.Find(id);

            if (toRemove != null)
            {
                dbContext.Remove(toRemove);
                dbContext.SaveChanges();
            }

            return toRemove;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return dbContext.Users;
        }

        public User GetEmployee(int id)
        {
            return dbContext.Users.Find(id);
        }

        public User UpdateUser(User userChanges)
        {
            var user = dbContext.Users.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return userChanges;
        }
    }
}
