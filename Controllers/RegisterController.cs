using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    public class RegisterController : Controller
    {
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
    }
}
