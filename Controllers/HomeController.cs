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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}