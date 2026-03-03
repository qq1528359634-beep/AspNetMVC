using Microsoft.AspNetCore.Mvc;
using SelfAspNet_MVC.DB;

namespace SelfAspNet_MVC.Controllers
{
    public class HelloWorldController : Controller
    {   
        private readonly MyContext _db;
        public HelloWorldController(MyContext db)
        {
            _db = db;               
        }
        public IActionResult List()
        {
       
            return View(_db.Books);
        }
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
