using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingData.Conrollers
{
	public class CustomerController : Controller
	{
		List<Customer> customers = new List<Customer>()
		{
			new Customer(){FirstName="Hasan", LastName="ATAL"},
			new Customer(){FirstName="Hüseyin", LastName="ŞANVERDİ"},
			new Customer(){FirstName="Fatih Osman", LastName="ATAÇ"}
		};
		public IActionResult UseViewModel()
		{
			Product product = new Product();
			product.ProductName = "Buzdolabı";
			product.CategoryName = "Beyaz eşya";
			product.UnitPrice = 11;

			string date = DateTime.Now.ToString();

			CustomerAndProductVM CustomerandProduct = new CustomerAndProductVM();
			CustomerandProduct.product = product;
			CustomerandProduct.date = date;
			CustomerandProduct.customers = customers;	 

			return View(CustomerandProduct);
		}

		public IActionResult UseTuple()
		{
			Product product = new Product();
			product.ProductName = "Telefon";
			product.CategoryName = "Elektronik";
			product.UnitPrice = 13;

			string date = DateTime.Now.ToString();

			(List<Customer>, string, Product) CustomerAndProduct1 = (customers,date,product);//sırası önemli
			return View(CustomerAndProduct1);
		}






	}
}
