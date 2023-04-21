using KiranAssesment.DataContext;
using KiranAssesment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KiranAssesment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CollectionContex _ctx;

        public HomeController(ILogger<HomeController> logger,CollectionContex ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult StudentForm()
        {
            return View();
        }
        [HttpPost]
        public Student StudentForm([FromBody] Student student)
        {
            Console.WriteLine("Inside Student Form");
            Console.WriteLine(student);

            _ctx.InsertStudent(student.Email, student.StudentName, student.DateOfBirth, student.Gender, student.Language);
            return student;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}