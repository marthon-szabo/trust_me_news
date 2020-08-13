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
    [Route("/SearchBar")]
    public class SearchBarController : Controller
    {
        INewsApi newsApiService;
        public Task<IEnumerable<Result>> _results;
        public SearchBarController(INewsApi newsApiService)
        {
            this.newsApiService = newsApiService;
        }
        public IActionResult Result()
        {
            return View();
        }

        [HttpGet]
        public async Task<IEnumerable<Result>> SearchResults(string content)
        {
            string apiEndpoint = $"https://content.guardianapis.com/search?q={content}&{NewsApiService.API_KEY}";
            var _results = newsApiService.SendRequest(apiEndpoint);
            return await _results;
        }
    }
}
