using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Mvc.GenericControllers.Controllers
{
    public class HomeController : Controller
    {
        private readonly IActionDescriptorCollectionProvider _actions;

        public HomeController(IActionDescriptorCollectionProvider actions)
        {
            _actions = actions;
        }

        public IActionResult Index()
        {
            // Returns a JSON dump of all the actions.
            var actions = _actions.ActionDescriptors.Items.Select(a =>
            {
                return new
                {
                    DisplayName = a.DisplayName,
                    RouteValues = a.RouteValues,
                };
            });
            return Ok(actions.ToArray());
        }
    }
}
