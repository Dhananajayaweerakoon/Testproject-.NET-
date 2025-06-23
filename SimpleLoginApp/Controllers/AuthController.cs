using Microsoft.AspNetCore.Mvc;
using SimpleLoginApp.Models;

namespace SimpleLoginApp.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid login";
            return View();
        }
    }
}
