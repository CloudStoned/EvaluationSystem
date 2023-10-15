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
            return View();
        }
        [HttpPost]
        public IActionResult Evaluate(int professorId, StudentAnswersTable answers)
        {
            bool studentExists = dataDb.Students.Any(s => s.studentNumber == answers.studentFK);

            if (!studentExists)
            {
                TempData["error"] = "You are not registered as a Student. Please register first.";
                return RedirectToAction("Evaluate");
            }

            answers.professorFK = professorId;
            dataDb.Answers.Add(answers);
            dataDb.SaveChanges();

            TempData["success"] = "Evaluation submitted successfully.";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}