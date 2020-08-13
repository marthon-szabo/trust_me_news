using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Models;
using TrustMeNews.Services;

namespace TrustMeNews.Controllers
{
    [Route("/search")]
    [ApiController]
    public class SearchBarController : Controller
    {
        INewsApi newsApiService;
        private readonly ILogger<SearchBarController> _logger;

        public SearchBarController(INewsApi newsApiService, ILogger<SearchBarController> logger)
        {
            this.newsApiService = newsApiService;
            this._logger = logger;
        }

        public IActionResult SearchResults()
        {
            //List<string> titles = new List<string>();
            //foreach (Result item in results)
            //{
            //    titles.Add(item.webTitle);
            //}
            //ViewData["Results"] = titles;

            return View();
        }


        //[HttpGet]
        //public IActionResult SearchResults(string content)
        //{
        //    string apiEndpoint = $"https://content.guardianapis.com/search?q={content}&{NewsApiService.API_KEY}";
        //    IEnumerable<Result> results = newsApiService.SendRequest(apiEndpoint).Result;
        //    List<string> titles = new List<string>();
        //    foreach (Result item in results)
        //    {
        //        titles.Add(item.webTitle);
        //    }
        //    ViewData["Results"] = titles;

        //    return View();
        //}
    }
}
