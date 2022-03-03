using Microsoft.AspNetCore.Mvc;

namespace PlatziASPdotNetCore.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
