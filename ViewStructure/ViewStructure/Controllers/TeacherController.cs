using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
	public class TeacherController : Controller
	{
		List<Teacher> teachers = new List<Teacher>()
		{
			new Teacher(){ID=1, Name="Osman", Gender="man"},
			new Teacher(){ID=2, Name="Elif", Gender="woman"},
			new Teacher(){ID=3, Name="Yavuz", Gender="man"},
			new Teacher(){ID=4, Name="Çiçek", Gender="woman"}
		};




		public IActionResult GetTeacherList()
		{
			return View(teachers);
		}
		public IActionResult DeleteTeacher(int id)
		{
			Teacher teacher = teachers.Find(n => n.ID == id);
			return View(teacher);
		}
	}
}
