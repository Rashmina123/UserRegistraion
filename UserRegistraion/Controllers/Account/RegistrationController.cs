using Microsoft.AspNetCore.Mvc;
using UserRegistraion.Models;

namespace UserRegistraion.Controllers.Account
{
    public class RegistrationController : Controller
    {
        public IActionResult SignUp()
        {
            ViewBag.GenderList = GetGender();
            return View();
        }
        public List<string> GetGender()
        {
            return new List<string>() { "Male", "Female" };
        }
    }
}
