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
            var currentUser = dbContext.Users.Include(x => x.Movies).FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (currentUser != null)
            {
                return View(currentUser.Movies.ToList());
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Remove(int id)
        {
            var currentUser = dbContext.Users.Include(x => x.Movies).FirstOrDefault(x => x.UserName == User.Identity.Name);
            currentUser?.Movies?.Remove(currentUser.Movies.FirstOrDefault(x => x.Id == id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}