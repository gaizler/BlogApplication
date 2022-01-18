using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        [Required, MinLength(5)]
        [Display(Name ="Your name:")]
        public string Author { get; set; }

        [Required, MinLength(7)]
        [Display(Name = "Title of post:")]
        public string Title { get; set; }

        [Required, MinLength(7)]
        [Display(Name = "Subtitle of post:")]
        public string Subtitle { get; set; }

        [Required, MinLength(20)]
        [Display(Name = "Text of post:")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Date posted:")]
        public DateTime DatePosted { get; set; }

        [Display(Name = "Path to image:")]
        public string ImgPath { get; set; }

        [Display(Name = "Image description:")]
        public string ImgDescription { get; set; }

    }
}
