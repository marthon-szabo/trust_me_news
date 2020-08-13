using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrustMeNews.Models;
using TrustMeNews.Services;

namespace TrustMeNews.Controllers
{
    [Route("/article")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        INewsApi newsApiService;

        public ArticlesController(INewsApi newsApiService)
        {
            this.newsApiService = newsApiService;
        }

        [HttpGet]
        public async Task<IEnumerable<Result>> GetArticlesBySection(string article)
        {
            string articleApiKey = $"https://content.guardianapis.com/{article}&{NewsApiService.API_KEY}&show-fields=all";
            return await newsApiService.SendRequest(articleApiKey);
        }

    }
}
