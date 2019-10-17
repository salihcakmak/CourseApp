using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //localhost:5000/Course
    public class CourseController:Controller
    {
        
        //Action method
        //localhost:5000/Course/Index => course/ındex.cshtml
        public IActionResult Index(){

            return View();

        }

        //localhost:5000/Course/Apply => course/apply.cshtml
        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }

        //localhost:5000/Course/Apply method:POST
        //Name=value&Mail=value&Phone=value&confirm=value
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            //Model Binding
            //database kayıt.
            if(ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks",student);
            }
            else
            {
                return View(student);
            }
            
        }
        //localhost:5000/Course/Details => course/details.cshtml
        public IActionResult Details(){
            /*
            Name = "Mvc Core Kursu"
            description = "iyi bir kurs"
            isPublished = true
             */
             var course=new Course();
             course.Name="Mvc Core Kursu";
             course.description="iyi bir kurs";
             course.isPublished=true;
            return View(course);
        }

        //localhost:5000/Course/List => course/list.cshtml
         public IActionResult List(){

            var studens=Repository.Students.Where(i=> i.Confirm==true);
            return View(studens);
        }
    }
}