using BlogBLL.Interfaces;
using BlogBLL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApplication.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService= postService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetById(id);
            return View(post);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] PostModel post)
        {
            post.Id = _postService.GetAll().Last().Id + 1;
            _postService.Add(post);

            return RedirectToRoute(new {controller="Home", action="Index"});
        }

        public IActionResult Update()
        {
            ViewBag.Posts = _postService.GetAll().Select(x=>x.Id);
            return View();
        }


        [HttpPost]
        public IActionResult Update([FromForm] PostModel post, [FromForm]int id)
        {
            post.Id = id;
            _postService.Update(post);

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
