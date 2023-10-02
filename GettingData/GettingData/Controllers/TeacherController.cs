using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GettingData.Controllers
{
	public class TeacherController : Controller
	{
		List<Branch> branches = new List<Branch>()
		{
			new Branch(){ID=1, BranchName="Fizik"},
			new Branch(){ID=2, BranchName="Matematik"},
			new Branch(){ID=3, BranchName ="Kimya" },
		};
		public IActionResult AddTeacher()
		{
			ViewBag.Branches = branches;
			return View();
		}
		[HttpPost]
		public IActionResult AddTeacher(Teacher taecher)
		{
			ViewBag.Branches = branches;
			return View();
		}

		public IActionResult AddTeacherUsingTuple()
		{
			(List<Branch>, Teacher)Tuple = (branches, new Teacher());
			return View(Tuple);
		}
		[HttpPost]
		public IActionResult AddTeacherUsingTuple([Bind(Prefix = "Item2")] Teacher teacher)
		{

			return RedirectToAction("AddTeacherUsingTuple");
		}


	}
}
