using AutoMapper;
using BlogBLL.Interfaces;
using BlogBLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApplication.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        public PostController(IPostService postService, IMapper mapper)
        {
            _postService= postService;
            _mapper= mapper;
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
        public async Task<IActionResult> Create([FromForm] PostModel post)
        {
            if (post.DatePosted.Year < 2021)
                ModelState.AddModelError(nameof(post.DatePosted),"Cannot add post older than 2 years. Minimal year is 2021");

            if (!ModelState.IsValid)
                return View(post);

            await _postService.Add(post);

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
            ViewBag.Posts = _postService.GetAll().Select(x => x.Id);

            if (post.DatePosted.Year < 2021)
                ModelState.AddModelError(nameof(post.DatePosted), "Cannot add post older than 2 years. Minimal year is 2021");

            if (!ModelState.IsValid)
                return View(post);

            post.Id = id;
            _postService.Update(post);

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
