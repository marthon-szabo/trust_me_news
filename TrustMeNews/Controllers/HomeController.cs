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
        private readonly IEnumerable<Result> _results;

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
        


        public IActionResult Result()
        {

            return View(_results);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        ////[HttpGet]
        ////public IActionResult SearchResults(string content)
        ////{
        ////    string apiEndpoint = $"https://content.guardianapis.com/search?q={content}&{NewsApiService.API_KEY}";
        ////    IEnumerable<Result> results = newsApiService.SendRequest(apiEndpoint).Result;
        ////    List<string> titles = new List<string>();
        ////    foreach (Result item in results)
        ////    {
        ////        titles.Add(item.webTitle);
        ////    }
        ////    ViewData["Results"] = titles;

        ////    return View();
        ////}


    }
}
