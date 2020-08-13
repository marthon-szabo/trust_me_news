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
    [Route("/section")]
    [ApiController]
    public class GenresApiController : ControllerBase
    {
        INewsApi newsApiService;

        public GenresApiController(INewsApi newsApiService)
        {
            this.newsApiService = newsApiService;
        }

        [HttpGet]
        public async Task<IEnumerable<Result>> GetArticlesBySection(string genreId)
        {
            string apiKeyBySection = "https://content.guardianapis.com/search?api-key=d0bd9a0e-8101-4525-8604-4ad01023d10c&order-by=newest&show-fields=all&page-size=6&section=" + $"{genreId}";
            Debug.WriteLine("GENRE: " + apiKeyBySection);
            return await newsApiService.SendRequest(apiKeyBySection);
        }
    }
}
