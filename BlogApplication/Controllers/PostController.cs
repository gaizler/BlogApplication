using BlogBLL.Interfaces;
using BlogBLL.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
