using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebFramework2.Models;

namespace TestWebFramework2
{
   public class BloggingContext : DbContext
   {
      public BloggingContext( DbContextOptions<BloggingContext> options )
          : base(options) { }

      public DbSet<Blog> Blogs { get; set; }
      public DbSet<Post> Posts { get; set; }
   }

}
