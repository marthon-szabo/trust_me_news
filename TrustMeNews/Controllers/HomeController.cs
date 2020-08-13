using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrustMeNews.Models;
using TrustMeNews.Services;

namespace TrustMeNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsApi newsApiService;
        private List<Result> _results = new List<Result>();

        public HomeController(ILogger<HomeController> logger, INewsApi newsApi)
        {
            _logger = logger;
            newsApiService = newsApi;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        


        public IActionResult Result(string content)
        {
            string apiEndpoint = $"https://content.guardianapis.com/search?q={content}&{NewsApiService.API_KEY}";
            IEnumerable<Result> results = newsApiService.SendRequest(apiEndpoint).Result;
            return View(results);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[Route("/Home")]
        //[HttpGet]
        //public void SearchResults(string content)
        //{
        //    string apiEndpoint = $"https://content.guardianapis.com/search?q={content}&{NewsApiService.API_KEY}";
        //    IEnumerable<Result> results = newsApiService.SendRequest(apiEndpoint).Result;


        //    Result(results);
        //}


    }
}
