using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrustMeNews.Models;
using TrustMeNews.Services;

namespace TrustMeNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        INewsApi newsApiService;

        public HomeController(ILogger<HomeController> logger, INewsApi newsApiService)
        {
            _logger = logger;
            this.newsApiService = newsApiService;
        }

        public IActionResult Index()
        {
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
