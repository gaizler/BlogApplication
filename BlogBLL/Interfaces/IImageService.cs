using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Interfaces
{
    public interface IImageService
    {
        Task<string> Upload(string fileName, Stream file);
    }
}
