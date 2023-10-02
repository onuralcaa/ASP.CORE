using Microsoft.AspNetCore.Mvc;

namespace DBfirst.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
