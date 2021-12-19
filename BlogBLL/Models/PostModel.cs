using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        [Display(Name ="Your name:")]
        public string Author { get; set; }

        [Display(Name = "Title of post:")]
        public string Title { get; set; }

        [Display(Name = "Subtitle of post:")]
        public string Subtitle { get; set; }

        [Display(Name = "Text of post:")]
        public string Content { get; set; }

        [Display(Name = "Date posted:")]
        public DateTime DatePosted { get; set; }

        [Display(Name = "Path to image:")]
        public string ImgPath { get; set; }

        [Display(Name = "Image description:")]
        public string ImgDescription { get; set; }

    }
}
