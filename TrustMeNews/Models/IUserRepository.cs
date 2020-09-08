using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustMeNews.Models
{
    interface IUserRepository
    {
        User CreateUser(int id, string userName, char password, string email);
        User GetEmployee(int id);
        IEnumerable<User> GetAllUsers();
        User UpdateUser(int id);
        User DeleteUser(int id);
    }
}
