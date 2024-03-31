using Microsoft.AspNetCore.Mvc;

namespace SoftuniProject_Contromano.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
