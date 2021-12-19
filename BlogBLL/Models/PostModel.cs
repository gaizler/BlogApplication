using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    public class PostModel
    {
        public int Id { get; set; } 
        public string Author { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public string ImgPath { get; set; }
        public string ImgDescription { get; set; }
    }
}
