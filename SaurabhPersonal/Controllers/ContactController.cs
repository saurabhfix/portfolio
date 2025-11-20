using Microsoft.AspNetCore.Mvc;

namespace SaurabhPersonal.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
