using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("~/Views/Auth/Register.cshtml");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("~/Views/Auth/Login.cshtml");
        }
    }
}