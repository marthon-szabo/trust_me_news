using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TrustMeNews.Models;

namespace TrustMeNews.Services
{
    public class NewsApiService
    {
        public async Task<IEnumerable<Result>> SendRequest(string path)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(path);
            Root article = null;
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(path).Result;

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                article = await httpResponseMessage.Content.ReadAsAsync<Root>();
            }

            httpClient.Dispose();

            return article.response.results;
        }
    }
}
