using BlogBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostModel> GetAll();

        PostModel GetById(int id);

        void Add(PostModel model);

        void Update(PostModel model);

        bool DeleteById(int modelId);
    }
}
