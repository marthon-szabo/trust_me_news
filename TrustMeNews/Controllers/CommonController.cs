using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrustMeNews.Data;
using TrustMeNews.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace TrustMeNews.Controllers
{
    public class CommonController : Controller
    {
        private readonly TrustMeNewsDataContext _context;

        public CommonController(TrustMeNewsDataContext context)
        {
            _context = context;
        }

        [System.Web.Mvc.ChildActionOnly]
        public async Task<PartialViewResult> Layout()
        {
            string? sessionId = HttpContext.Session.GetString("sessionId");

            if (sessionId != null)
            {

                User user = await _context.Users
                    .FirstOrDefaultAsync(u => u.SessionId.Equals(sessionId));
                return PartialView(user);
            }

            return PartialView(new User { UserName = "ALMA" });
        }

    }
}
