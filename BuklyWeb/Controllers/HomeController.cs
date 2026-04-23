using BuklyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BuklyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       }
}
