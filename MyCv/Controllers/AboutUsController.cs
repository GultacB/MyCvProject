using Microsoft.AspNetCore.Mvc;
using MyCv.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyCv.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["tittle"] = "AboutUs page!!";
            return View();
        }
    }
}

﻿