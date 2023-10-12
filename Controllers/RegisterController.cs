using EvaluationSystem.Data;
using EvaluationSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    public class RegisterController : Controller
    {
        private readonly AppDbContext dataDb;

        public RegisterController(AppDbContext data)
        {
            dataDb = data;
        }

        public IActionResult RegisterIndex()
        {
            return View();
        }

        public IActionResult RegisterStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterStudent(StudentTableModel student)
        {
            dataDb.Students.Add(student); 
            dataDb.SaveChanges();
            return RedirectToAction("RegisterIndex");
        }

        public IActionResult RegisterProfessor()
        {
            return View();
        }
    }
}
