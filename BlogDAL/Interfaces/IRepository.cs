using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity:BaseEntity
    {
        IQueryable<TEntity> FindAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteById(int id);
    }
}
