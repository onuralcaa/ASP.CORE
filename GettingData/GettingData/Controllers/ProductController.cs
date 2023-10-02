using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
	public class ProductController : Controller
	{
		List<Product> products = new List<Product>()
		{
			new Product(){ID=1, ProductName="Kalemlik", CategoryName="Okul"},
			new Product(){ID=2, ProductName="çatal", CategoryName="Ev"},
			new Product(){ID=3, ProductName="çekiç", CategoryName="Ev"},
			new Product(){ID=4, ProductName="kılıç", CategoryName="Okul"}
		};	
		public IActionResult GetAllProduct()
		{
			return View(products);
		}

		public IActionResult GetProductById(int id)
		{
			Product product = products.Find(x => x.ID == id);

			if(product == null)
			{
				ViewBag.Error = "Verilen id ile br ürün bulunamadı.";
			}
			return View(product);
		}

		public IActionResult GetProductsByCategoryName(string categoryName)
		{
			List<Product> p = products.FindAll(x => x.CategoryName == categoryName);
			if(p == null)
			{
				ViewData["Error"] = "Girdiğiniz kategoride ürün bulunamadı.";
			}

			return View(p);
		}

		



	}
}
