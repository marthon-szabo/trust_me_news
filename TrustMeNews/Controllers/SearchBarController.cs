﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Models;
using TrustMeNews.Services;

namespace TrustMeNews.Controllers
{
    [Route("/search")]
    [ApiController]
    public class SearchBarController : ControllerBase
    {
        INewsApi newsApiService;

        public SearchBarController(INewsApi newsApiService)
        {
            this.newsApiService = newsApiService;
        }

        [HttpGet("{content}")]
        public async Task<IEnumerable<Result>> GetResultsByContent(string content)
        {
            string apiEndpoint = $"https://content.guardianapis.com/sections?q={content}/{NewsApiService.API_KEY}";

            return await newsApiService.SendRequest(apiEndpoint);
        }
    }
}