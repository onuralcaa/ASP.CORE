using AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller //Controller dan miras alındı.
    {
        public string Index()//aksiyonun başladığı yer
        {
            return "Program çalışıyor.";
        }

        public string Test()//aksiyonun başladığı yer 2
        {
            return "İhsan ERDEM";
        }

        public IActionResult Selamla()
        {
            ViewResult result =  View();
            return result;
        }
    
    }
}
