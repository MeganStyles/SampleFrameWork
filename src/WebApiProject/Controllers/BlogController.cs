using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TestWebFramework2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebFramework2.Controllers
{
    [Route("api/[controller]")]
   public class BlogController : Controller
    {
      // GET api/blog
      [HttpGet]
      public IEnumerable<string> Get() {
         return new string[] { "value1", "value2" };
      }

      // GET api/blog/5
      [HttpGet("{id}")]
      public string Get( int id ) {
         return "value";
      }

      // POST api/blog
      [HttpPost]
      public void Post( [FromBody]Blog value ) {
         var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
         optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestWebFramework;Trusted_Connection=True;ConnectRetryCount=0");
         BloggingContext db = new BloggingContext( optionsBuilder.Options );
         db.Blogs.Add(value);
         db.SaveChanges();
      }

      // PUT api/blog/5
      [HttpPut("{id}")]
      public void Put( int id, [FromBody]Blog value ) {
      }

      // DELETE api/blog/5
      [HttpDelete("{id}")]
      public void Delete( int id ) {
      }
   }
}
