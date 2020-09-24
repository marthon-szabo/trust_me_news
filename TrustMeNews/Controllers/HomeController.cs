using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SQLitePCL;
using TrustMeNews.Data;
using TrustMeNews.Models;
using TrustMeNews.Services;

namespace TrustMeNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TrustMeNewsDataContext _context;
        INewsApi newsApiService;

        public HomeController(ILogger<HomeController> logger, INewsApi newsApiService, TrustMeNewsDataContext context)
        {
            _logger = logger;
            _context = context;
            this.newsApiService = newsApiService;
        }

        
        public async Task<IActionResult> Index(string? user)
        {
            string? sessionId = HttpContext.Session.GetString("sessionId");
            if (sessionId != null)
            {
                User current_user = await _context.Users
                    .FirstOrDefaultAsync(u => u.SessionId.Equals(sessionId));
                
                ViewData["sessionId"] = sessionId;
                ViewData["username"] = current_user.UserName;
            }

            newsApiService = new NewsApiService();
            string apiKey = "https://content.guardianapis.com/search?api-key=d0bd9a0e-8101-4525-8604-4ad01023d10c&order-by=newest&show-fields=all&page-size=6";
            var model = newsApiService.SendRequest(apiKey).GetAwaiter().GetResult();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult User()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
