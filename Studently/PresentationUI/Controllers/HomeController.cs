using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ILessonService _lessonService;
        ITeacherService _teacherService;
        IStudentService _studentService;

        public HomeController(ILogger<HomeController> logger, ILessonService lessonService, ITeacherService teacherService, IStudentService studentService)
        {
            _logger = logger;
            _lessonService=lessonService;
            _teacherService=teacherService;
            _studentService=studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var result = _teacherService.GetAll();
            return View(result);
        }

        public IActionResult Courses()
        {
            var result = _lessonService.GetAll();
            return View(result);
        }

        public IActionResult Testimonial()
        {
            var result = _studentService.GetAll();
            return View(result);
        }

        public IActionResult Contact()
        {
            return View();
        }



        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
