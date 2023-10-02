using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Conrollers
{
    public class UserController : Controller
    {
		List<User> users = new List<User>()
			{
				new User(){FirstName ="Mehmet", LastName="KOCAKAFA"},
				new User(){FirstName ="Eyüp", LastName="KOCAKELLE"},
				new User(){FirstName ="Muhammed", LastName="KOCAAYAK"},
				new User(){FirstName ="Rahime", LastName="İNCİ"}
			};

		public IActionResult UseViewBag()
        {
            ViewBag.userName = "Osman";

            User user = new User();
            user.FirstName = "Gülseren";
            user.LastName = "ALACA";
            ViewBag.User = user;

           
            ViewBag.users = users;

            return View();
        }

        public IActionResult UseViewData()
        {
            ViewData["UserName"] = "Abdullah";

            User user = new User();
            user.FirstName = "Miraç";
            user.LastName = "İNCİ";
            ViewData["user"] = user;
            ViewData["users"] = users;
            return View();
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "Gülçin";
            return RedirectToAction("TempDataTest");
        }

        public IActionResult TempDataTest()
        {
            TempData.Keep("name");//tek kullanımlık özelliğini uzatıyor.
            string userName = TempData["name"].ToString();
            return View();
        }





    }
}
