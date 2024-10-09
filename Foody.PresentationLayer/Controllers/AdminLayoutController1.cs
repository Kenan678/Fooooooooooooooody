using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
