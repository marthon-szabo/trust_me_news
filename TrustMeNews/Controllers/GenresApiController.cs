using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<Result>> GetArticlesBySection(string section)
        {
            string apiKeyBySection = $"https://content.guardianapis.com/search?{NewsApiService.API_KEY}&order-by=newest&show-fields=all&page-size=8&section={section}";
            return await newsApiService.SendRequest(apiKeyBySection);
        }
    }
}
