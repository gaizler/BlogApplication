using BlogDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Interfaces
{
    public interface IPostRepository:IRepository<Post>
    {
        //можливо в майбутньому знадобляться якісь специфічні операції для роботи з постами
    }
}
