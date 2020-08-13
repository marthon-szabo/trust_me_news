using Microsoft.AspNetCore.Mvc;
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
        private IEnumerable<Result> _results;

        public SearchBarController(INewsApi newsApiService)
        {
            this.newsApiService = newsApiService;
        }

        public IActionResult SearchResults()
        {

            return View();
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
