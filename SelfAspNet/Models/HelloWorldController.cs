using Microsoft.AspNetCore.Mvc;

namespace SelfAspNet.Models
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //右键Show add viewm
        public IActionResult Show()
        {
            ViewData["Message"] = "Hello World";
            //razorテンプレートを呼び出す
            return View();
        }
    }
}
