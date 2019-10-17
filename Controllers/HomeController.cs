using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //localhost:5000/Home
    public class HomeController:Controller
    {
        //localhost:5000/Home/Index => home/index.cshtml
        public IActionResult Index(){

            int saat=DateTime.Now.Hour;
            ViewBag.Greetings=saat>12 ? "İyi Günler" : "Günaydın";
            ViewBag.Name="Salih";

            return View();
        }
/* 
        //localhost:5000/Home/Details => home/myview.cshtml
        public IActionResult Details(){

            return View("MyView");
        }
*/
        //localhost:5000/Home/About => home/about.cshtml
        public IActionResult About(){

            return View();
        }
    }
}