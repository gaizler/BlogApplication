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

        }
        public void Add(Post entity)
        {
            _dbContext.Posts.Add(entity);
        }

        public void Delete(Post entity)
        {
            _dbContext.Posts.Remove(entity);
        }

        public bool DeleteById(int id)
        {
            var post = _dbContext.Posts.Where(x => x.Id == id).First();

            if (post != null)
            {
               _dbContext.Posts.Remove(post);

                return true;
            }

            return false;
        }

        public IQueryable<Post> FindAll()
        {
            return _dbContext.Posts.AsQueryable();
        }

        public Post GetById(int id)
        {
            return _dbContext.Posts.First(x => x.Id == id);
        }

        public void Update(Post entity)
        {
            var post = _dbContext.Posts.First(x => x.Id==entity.Id);

            post.Title = entity.Title;
            post.DatePosted = entity.DatePosted;
            post.ImgDescription= entity.ImgDescription;
            post.Subtitle= entity.Subtitle;
            post.Content = entity.Content;
            post.ImgPath=entity.ImgPath;
        }
    }
}
