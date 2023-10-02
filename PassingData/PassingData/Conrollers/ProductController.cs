using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Conrollers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "Onur ALACA";
            return View(userName as object);
        }

        public IActionResult urunGoster()
        {
            Product product = new Product();
            product.ProductName = "Televizyon";
            product.UnitPrice = 5;

            return View(product);
        }

        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ProductName = "Bilgisayar", CategoryName="Elektronik", UnitPrice=86},
                new Product(){ProductName = "Telefon", CategoryName="Elektronik", UnitPrice=56},
                new Product(){ProductName = "Buzdolabı", CategoryName="Beyaz Eşya", UnitPrice=46},
                new Product(){ProductName = "Mutfak robotu", CategoryName="Mutfak eşyası", UnitPrice=23},
                new Product(){ProductName = "Tablo", CategoryName="Kozmetik ve süs eşyası", UnitPrice=31}
            };
            return View(products);

        }


    }
}
