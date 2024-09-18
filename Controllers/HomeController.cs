using Microsoft.AspNetCore.Mvc;

namespace supermarketsys.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
