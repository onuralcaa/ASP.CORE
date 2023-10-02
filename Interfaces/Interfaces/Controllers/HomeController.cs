using Interfaces.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interfaces.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			MsSqlOperation mssql = new MsSqlOperation();
			mssql.Connection();

			ISqlOperation sql= new MsSqlOperation();
			sql.Connection();

			ISqlOperation mysql= new MySqlOperation();
			mysql.Connection();


			return View();
		}
	}
}
