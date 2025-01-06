using Microsoft.AspNetCore.Mvc;

namespace DotnetEdu.MVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
