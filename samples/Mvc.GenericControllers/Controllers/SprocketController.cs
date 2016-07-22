
using Microsoft.AspNetCore.Mvc;

namespace Mvc.GenericControllers.Controllers
{
    public class SprocketController : Controller
    {
        public IActionResult Index()
        {
            return Content($"Hello from {GetType().FullName}.");
        }
    }
}
