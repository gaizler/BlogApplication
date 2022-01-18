using BlogApplication.Models;
using BlogBLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostService _postService;

        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var allPosts = _postService.GetAll().ToList();
            if(ViewBag.PostsCount==null)
                ViewBag.PostsCount = 5;

            allPosts = allPosts.OrderByDescending(x => x.DatePosted).ToList();
            return View(allPosts);
        }

        public IActionResult OlderPosts(int currentCount)
        {
            var allPosts = _postService.GetAll().ToList();
            if ((allPosts.Count - currentCount) >= 5)
                currentCount += 5;
            else
                currentCount += (allPosts.Count - currentCount);

            ViewBag.PostsCount = currentCount;
            return View("Index",allPosts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
