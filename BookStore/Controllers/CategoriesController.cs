﻿using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index( )
        {
            return View();
        }
    }
}
