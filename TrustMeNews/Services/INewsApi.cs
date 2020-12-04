using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrustMeNews.Models;

namespace TrustMeNews.Services
{
    public interface INewsApi
    {
        public async Task<IEnumerable<Result>> SendRequest(string endPoint)
        {
            return null;
        }
        public async Task<Content> SendArticleRequest(string endPoint)
        {
            return null;
        }
    }
}