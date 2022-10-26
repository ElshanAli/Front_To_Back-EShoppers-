using Microsoft.AspNetCore.Mvc;

namespace FrontBackEShopers.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
