using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyCv.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FullName = "Gultac Baxsizade";
            return View();
        }
    }
}

