using Microsoft.AspNetCore.Mvc;
using MyCv.Model;
namespace MyCv.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var contact = new ContactMe
            {
                Number = 0506472751,
                Email = "gultacbaxsizade@gmail.com",
                Address = "Lankaran,Germetuk H.Aslanov street"
            };
            return View(contact);
        }
    }
}
