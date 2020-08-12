﻿using System;
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
        private string genre;

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

        public void GetGenre(string sectionId)
        {
            genre = sectionId;
        }

    }
}
