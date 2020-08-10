using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TrustMeNews.Models;

namespace TrustMeNews.Services
{
    public class NewsApiService
    {

        public Article SendRequest(string path)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(path);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage(HttpMethod.Get, path);
            var response = client.SendAsync(request).Result;
            var content = response.Content.ReadAsStringAsync().Result;

            Debug.WriteLine(JsonConvert.DeserializeObject<Article>(content).ToString());

            return JsonConvert.DeserializeObject<Article>(content);

        }
        //HttpWebRequest httpClient = WebRequest.CreateHttp(path);
        //httpClient.ContentType = "application/json";
        //httpClient.Accept = "*/*";
        //httpClient.Method = "GET";

        //HttpWebResponse httpResponse = (HttpWebResponse)httpClient.GetResponse();

        //string streamReader = new StreamReader(httpResponse.GetResponseStream()).ReadToEnd();

        //Article article = JsonConvert.DeserializeObject<Article>(streamReader);

        //return article;
    }
}
