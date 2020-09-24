using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Data;
using TrustMeNews.Models;

namespace TrustMeNews
{
    public class SessionValidator
    {
        private static TrustMeNewsDataContext _context;

        public SessionValidator(TrustMeNewsDataContext context)
        {
            _context = context;
        }

        public static User GetUser(string sessionId)
        {
            User? toReturn = _context.Users
                .FirstOrDefault(u => u.SessionId.Equals(sessionId));
            return toReturn;
        }
    }
}
