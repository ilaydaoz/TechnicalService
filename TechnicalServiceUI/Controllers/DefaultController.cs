using Microsoft.AspNetCore.Mvc;

namespace TechnicalServiceUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
