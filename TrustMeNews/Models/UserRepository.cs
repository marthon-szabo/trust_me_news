using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(int id, string userName, char password, string email)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
