using Microsoft.AspNetCore.Mvc;

namespace BuklyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
