using Microsoft.AspNetCore.Mvc;

namespace EvaluationSystem.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult RegisterIndex()
        {
            return View();
        }
    }
}
