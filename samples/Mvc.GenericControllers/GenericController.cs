using Microsoft.AspNetCore.Mvc;

namespace Mvc.GenericControllers
{
    [GenericControllerNameConvention] // Sets the controller name based on typeof(T).Name
    public class GenericController<T> : Controller
    {
        public IActionResult Index()
        {
            return Content($"Hello from {GetType().FullName}.");
        }
    }
}
