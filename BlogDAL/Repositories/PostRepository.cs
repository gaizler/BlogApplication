using BlogDAL.Entities;
using BlogDAL.Helpers;
using BlogDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext _dbContext;
        public PostRepository(BlogDbContext dbContext)
        {
            this._dbContext=dbContext;

            _dbContext.Posts = new List<Post>
            {
                 new Post
                {
                    Id = 1,
                    Author = "Andrii",
                    DatePosted = DateTime.Now.AddDays(-10),
                    Title = "Some title1",
                    Subtitle = "Some subtitle1",
                    Content = LoremIpsum.GetLoremIpsum(900),
                    ImgPath = "https://picsum.photos/1000/800",
                    ImgDescription="Img Description 1"
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
                      }
            };
        }
        public void Add(Post entity)
        {
            _dbContext.Posts.Add(entity);
        }

        public bool Delete(Post entity)
        {
            return _dbContext.Posts.Remove(entity);
        }

        public bool DeleteById(int id)
        {
            var post = _dbContext.Posts.FindAll(x => x.Id == id).First();

            if (post != null)
            {
                return _dbContext.Posts.Remove(post);
            }

            return false;
        }

        public IQueryable<Post> FindAll()
        {
            return _dbContext.Posts.AsQueryable();
        }

        public Post GetById(int id)
        {
            return _dbContext.Posts.Find(x => x.Id == id);
        }

        public void Update(Post entity)
        {
            _dbContext.Update(entity);
        }
    }
}
