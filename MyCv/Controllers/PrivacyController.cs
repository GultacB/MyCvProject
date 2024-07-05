using Microsoft.AspNetCore.Mvc;
using MyCv.Models;

namespace MyCv.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            ViewData["tittle"] = "Privacy page!!";
            return View();
        }
    }
}
