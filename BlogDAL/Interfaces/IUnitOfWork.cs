using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Interfaces
{
    public interface IUnitOfWork
    {
        IPostRepository PostRepository { get; }
        int Save();
    }
}
