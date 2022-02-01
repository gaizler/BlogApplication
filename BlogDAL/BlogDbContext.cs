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
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> Posts { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 1,
                Author = "Andrii",
                DatePosted = DateTime.Now.AddDays(-10),
                Title = "Some title1",
                Subtitle = "Some subtitle1",
                Content = LoremIpsum.GetLoremIpsum(900),
                ImgPath = "https://picsum.photos/1000/800",
                ImgDescription = "Img Description 1"
            },
                new Post
                {
                    Id = 2,
                    Author = "Andrii",
                    DatePosted = DateTime.Now.AddDays(-20),
                    Title = "Some title2",
                    Subtitle = "Some subtitle2",
                    Content = LoremIpsum.GetLoremIpsum(700),
                    ImgPath = "https://picsum.photos/1000/800",
                    ImgDescription = "Img Description 2"
                },
                  new Post
                  {
                      Id = 3,
                      Author = "Andrii",
                      DatePosted = DateTime.Now.AddDays(-1),
                      Title = "Some title3",
                      Subtitle = "Some subtitle3",
                      Content = LoremIpsum.GetLoremIpsum(800),
                      ImgPath = "https://picsum.photos/1000/800",
                      ImgDescription = "Img Description 3"
                  },
                   new Post
                   {
                       Id = 4,
                       Author = "Andrii",
                       DatePosted = DateTime.Now.AddDays(-1),
                       Title = "Some title4",
                       Subtitle = "Some subtitle4",
                       Content = LoremIpsum.GetLoremIpsum(1000),
                       ImgPath = "https://picsum.photos/1000/800",
                       ImgDescription = "Img Description 4"
                   },
                    new Post
                    {
                        Id = 5,
                        Author = "Andrii",
                        DatePosted = DateTime.Now.AddDays(-10),
                        Title = "Some title5",
                        Subtitle = "Some subtitle5",
                        Content = LoremIpsum.GetLoremIpsum(900),
                        ImgPath = "https://picsum.photos/1000/800",
                        ImgDescription = "Img Description 5"
                    },
                     new Post
                     {
                         Id = 6,
                         Author = "Andrii",
                         DatePosted = DateTime.Now.AddDays(-10),
                         Title = "Some title6",
                         Subtitle = "Some subtitle6",
                         Content = LoremIpsum.GetLoremIpsum(999),
                         ImgPath = "https://picsum.photos/1000/800",
                         ImgDescription = "Img Description 6"
                     },
                      new Post
                      {
                          Id = 7,
                          Author = "Andrii",
                          DatePosted = DateTime.Now.AddDays(-100),
                          Title = "Some title7",
                          Subtitle = "Some subtitle7",
                          Content = LoremIpsum.GetLoremIpsum(800),
                          ImgPath = "https://picsum.photos/1000/800",
                          ImgDescription = "Img Description 7"
                      });
        }
      
    }
}
