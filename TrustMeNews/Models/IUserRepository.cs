using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    interface IUserRepository
    {
        User CreateUser(User user);
        User GetEmployee(int id);
        IEnumerable<User> GetAllUsers();
        User UpdateUser(User userChanges);
        User DeleteUser(int id);
    }
}
