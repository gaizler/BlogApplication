using BlogDAL.Interfaces;
using BlogDAL.Repositories;
using System;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext _dbContext;
        private IPostRepository _postRepository;

        public UnitOfWork(BlogDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IPostRepository PostRepository
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new PostRepository(_dbContext);
                return _postRepository;
            }
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
