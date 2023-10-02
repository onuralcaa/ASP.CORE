using DBfirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBfirst.Controllers
{
	public class CategoryController : Controller
	{
		NorthwindContext _db;
		public CategoryController(NorthwindContext db)
		{
			_db = db;

		}
		public IActionResult List()
		{
			List<Category> categories = _db.Categories.ToList();
			return View(categories);
		}
	}
}
