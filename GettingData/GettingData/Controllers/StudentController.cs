using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
	public class StudentController : Controller
	{
		List<Student> students = new List<Student>()
		{
			new Student(){FirstName="Onur", LastName="ALACA"},
			new Student(){FirstName="Nejdet", LastName="SEFA"},
			new Student(){FirstName="Muhammed Ali", LastName="KEMER"},
			new Student(){FirstName="Emin", LastName="GÜNAY"},
		};

		public IActionResult GetStudentList()
		{
			return View(students);
		}

		[HttpPost]
		public IActionResult AddStudent(Student student)
		{
			students.Add(student);
			return View("GetStudentsList", students);
		}
	}
}
