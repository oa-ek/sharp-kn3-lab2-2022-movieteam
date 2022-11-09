using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository;

namespace MoviesUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
	{
        private readonly UsersRepository userRepository;
        private readonly MoviesDbContext dbContext;
        public UsersController(UsersRepository userRepository, MoviesDbContext dbContext)
		{
			this.userRepository = userRepository;
            this.dbContext = dbContext;
		}
		public async Task<IActionResult> Index()
		{
			return View(await userRepository.GetAllUsers());
		}
        [HttpGet]
        public async Task<IActionResult> Bookmark()
        {
            User currentUser = dbContext.Users.Include(x=>x.Movies).FirstOrDefault(x => x.UserName == User.Identity.Name);
            
            return View();
        }
    }
}
