using Microsoft.AspNetCore.Mvc;
using MVC_WebAppLevel1.Models;

namespace MVC_WebAppLevel1.Controllers
{
    public class StudentController : Controller
    {
        Students students = new();

        public IActionResult Index()
        {
            return View("Index", students.GetAllStudents());
        }

        public IActionResult Details(int id)
        {
            Student? student = students.GetStudent(id);//Current

            ViewBag.Next = students.GetNext(id);//Next
            ViewBag.Previous = students.GetPrevious(id);//Previous

            return View("Details", student);
        }
    }
}
