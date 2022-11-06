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
        public ActionResult Details(int id = 0)
        {
            Student student = dbContext.Students.Include(x => x.Courses).FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        public ActionResult Edit(int id = 0)
        {
            Student student = dbContext.Students.Include(x => x.Courses).FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            ViewBag.Courses = dbContext.Courses.ToList();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student, int[] selectedCourses)
        {
            Student newStudent = dbContext.Students.Include(x => x.Courses).FirstOrDefault(x => x.Id == student.Id);
            newStudent.Name = student.Name;
            newStudent.Surname = student.Surname;

            newStudent.Courses.Clear();
            if (selectedCourses != null)
            {
                //получаем выбранные курсы
                foreach (var c in dbContext.Courses.Where(co => selectedCourses.Contains(co.Id)))
                {
                    newStudent.Courses.Add(c);
                }
            }

            dbContext.Entry(newStudent).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
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