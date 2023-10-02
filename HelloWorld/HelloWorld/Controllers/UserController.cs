using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser()
        {
            User user = new User();
            user.FirstName = "Onur";
            user.LastName = "ALACA";
            user.Id = "1";
            return View();
        }
    }
}
