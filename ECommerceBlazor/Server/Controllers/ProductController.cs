using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceBlazor.Server.Data;
using ECommerceBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerceBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly DataContext dataContext;

        public ProductController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return Ok(await dataContext.Products.ToListAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

