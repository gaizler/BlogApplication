﻿using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
