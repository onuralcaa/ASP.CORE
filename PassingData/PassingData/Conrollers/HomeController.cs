using Microsoft.AspNetCore.Mvc;

namespace PassingData.Conrollers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Uygulama çalışıyor.";
        }
    }
}
