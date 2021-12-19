using BlogDAL.Entities;
using BlogDAL.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext()
        {
          
        }

        public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options)
        {}

        public List<Post> Posts { get; set; } 

      
    }
}
