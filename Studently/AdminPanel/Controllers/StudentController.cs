using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class StudentController : Controller
    {
        Context contex = new Context();
        IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {


            _studentService.Add(student);
            return View();


        }


        [HttpGet]
        public IActionResult DeleteStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteStudent(Student student)
        {
            _studentService.Delete(student);
            return View();
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var result = contex.Students.FirstOrDefault(x => x.StudentId == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {

            _studentService.Update(student);
            return View();
        }

       
        public IActionResult StudentList()
        {
            var result = _studentService.GetAll();
            return View(result);
        }


        public IActionResult StudentDeleteById(int id)
        {
            var ent = _studentService.GetId(id);
            _studentService.Delete(ent);
            return RedirectToAction("StudentList","Student");
        }
 
    }
}
