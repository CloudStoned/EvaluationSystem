using EvaluationSystem.Data;
using EvaluationSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    public class RegisterController : Controller
    {
        private readonly AppDbContext dataDb;
        public RegisterController(AppDbContext dataDb)
        {
            this.dataDb = dataDb;
        }

        public IActionResult RegisterIndex()
        {
            return View();
        }

        public IActionResult RegisterStudent()
        {
            return View();
        }

        public IActionResult RegisterProfessor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterStudent(StudentTableModel students)
        {
            dataDb.Students.Add(students);
            dataDb.SaveChanges();
            return RedirectToAction("RegisterIndex");
        }

        [HttpPost]
        public IActionResult RegisterProfessor(ProfessorTableModel professor)
        {
            dataDb.Professors.Add(professor);
            dataDb.SaveChanges();
            return RedirectToAction("RegisterIndex");
        }
    }
}
