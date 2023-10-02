using IocContainer.Services;
using IocContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IocContainer.Controllers
{
	public class HomeController : Controller
	{
		//ConsoleLogger _log;
		ILog _log;

		public HomeController(ILog log)
		{
			_log = log;
		}

		public string Index([FromServices] ILog log) 
		{
			log.Info("Action bazlı talep yapılmıştır.");
			return "Service Running";
		}
	}
}
