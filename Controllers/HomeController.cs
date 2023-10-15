using EvaluationSystem.Data;
using EvaluationSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EvaluationSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dataDb;
        private readonly ILogger<HomeController> _logger;

        public HomeController(AppDbContext data,ILogger<HomeController> logger)
        {
             dataDb = data;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<ProfessorTableModel> professors = dataDb.Professors;
            return View(professors);
        }

        public IActionResult Evaluate(int professorId)
        {
            // Use the professorId to fetch the professor's information from your database
            ProfessorTableModel professor = dataDb.Professors.FirstOrDefault(p => p.professorId == professorId);

            if (professor == null)
            {
                // Handle the case where the professor does not exist
                // You can choose to return a 404 not found view or a custom error view
                return NotFound();
            }

            // Pass the professor's information to the view
            return View();
        }

        [HttpPost]
        public IActionResult Evaluate(StudentAnswersTable answers, int professorId, int studentNumber)
        {

            bool studentExists = dataDb.Students.Any(s => s.studentNumber == studentNumber);
            if (studentExists)
            {
                answers.professorId = professorId; // Add professor ID to the answers object
                dataDb.Answers.Add(answers);
                dataDb.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // Student does not exist, redirect or show an error message
                return RedirectToAction("Index");
            }

        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}