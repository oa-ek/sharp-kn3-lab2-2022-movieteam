using Microsoft.AspNetCore.Mvc;
using MoviesCore;
using MoviesUI.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MoviesUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly MoviesDbContext dbContext;
        public HomeController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
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