using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Models;
using System.Diagnostics;

namespace SchoolSystem.Controllers
{
    public class HomeController : Controller
    {

        private readonly SchoolDataBaseContext _context;

        public HomeController(SchoolDataBaseContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HelpInfo()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}