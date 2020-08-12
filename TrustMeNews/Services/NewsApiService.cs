using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TrustMeNews.Models;

namespace TrustMeNews.Services
{
    public class NewsApiService : INewsApi
    {
        public const string API_KEY = "api-key=d0bd9a0e-8101-4525-8604-4ad01023d10c";
        public string _api = "api";

        public string Api { get { return _api; } }

        public async Task<IEnumerable<Result>> SendRequest(string path)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(path);
            Root root = null;
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(path).Result;

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                root = await httpResponseMessage.Content.ReadAsAsync<Root>();
            }

            httpClient.Dispose();

            return root.response.results;
        }
        public async Task<IEnumerable<Genre>> SendGenreRequest(string path)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(path);
            GenreRoot root = null;
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(path).Result;

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                root = await httpResponseMessage.Content.ReadAsAsync<GenreRoot>();
            }

            httpClient.Dispose();

            return root.response.results;
        }
    }
}
