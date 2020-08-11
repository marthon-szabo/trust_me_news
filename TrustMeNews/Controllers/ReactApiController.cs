using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrustMeNews.Models;
using TrustMeNews.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrustMeNews.Controllers
{

    [Route("reactApi")]
    [ApiController]
    public class ReactApiController : ControllerBase
    {
        INewsApi newsApiService;

        public ReactApiController(INewsApi newsApiService)
        {
            this.newsApiService = newsApiService;
        }



        // GET: api/<ReactApiController>
        [HttpGet]
        public Task<IEnumerable<Result>> Get()
        {
            return newsApiService.SendRequest("https://content.guardianapis.com/search?api-key=d0bd9a0e-8101-4525-8604-4ad01023d10c&order-by=newest&show-fields=all&page-size=6");
        }

        // GET api/<ReactApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReactApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReactApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReactApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
