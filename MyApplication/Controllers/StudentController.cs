using MyApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly MVCDbContext _dbContext;

        public StudentController(MVCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public StudentController()
        {
            _dbContext = new MVCDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        [OutputCache(Duration = 100)]
        [HttpGet]
        public ViewResult Index()
        {
            List<Student> students = new List<Student>();


            try
            {
                students = _dbContext.Students.OrderBy(std => std.Id).ToList();
            }
            catch
            {
                Console.WriteLine("Error DB!");
            }
            return View(students);
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult EditStudent(int id)
        {
            var studentResult = _dbContext.Students.FirstOrDefault(std => std.Id.Equals(id));

            if (studentResult == null) return RedirectToAction("Index");

            return View(studentResult);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit(Student student)
        {
            var studentResult = _dbContext.Students.FirstOrDefault(std => std.Id.Equals(student.Id));

            if (studentResult == null) return RedirectToAction("Index");

            studentResult.Email = student.Email.ToLower().Trim();
            studentResult.Name = student.Name;
            studentResult.Age = student.Age;

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("Remove")]
        public ActionResult Remove(int id)
        {
            var studentResult = _dbContext.Students.FirstOrDefault(std => std.Id.Equals(id));

            if (studentResult != null)
            {
                _dbContext.Students.Remove(studentResult);
                _dbContext.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Register")]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Register")]
        public ActionResult Register(Student student)
        {
            student.Email = student.Email.ToLower().Trim();

            _dbContext.Students.Add(student);

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}