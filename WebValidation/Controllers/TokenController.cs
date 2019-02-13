using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebValidation.Data;

namespace WebValidation.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private ApplicationDbContext context;

        public TokenController(ApplicationDbContext context)
        {
            this.context = context;

        }

        // GET: api/Token
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return context.Users.Select(u => u.UserName).ToArray();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Token/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Token
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Token/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
