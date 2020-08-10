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
        public IEnumerable<Article> SendRequest(string path)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(path);
            IEnumerable<Article> article = null;
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(path).Result;

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Debug.WriteLine("alma: " + httpResponseMessage.Content.ReadAsAsync<IEnumerable<Article>>().Result);
            }

            httpClient.Dispose();

            return article;
        }
    }
}
