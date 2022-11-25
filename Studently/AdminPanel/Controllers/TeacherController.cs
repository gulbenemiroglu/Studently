using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class TeacherController : Controller
    {
        Context contex = new Context();
        ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {


            _teacherService.Add(teacher);
            return View();


        }


        [HttpGet]
        public IActionResult DeleteTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteTeacher(Teacher teacher)
        {
            _teacherService.Delete(teacher);
            return View();
        }
        [HttpGet]
        public IActionResult UpdateTeacher(int id)
        {
            var result = contex.Teachers.FirstOrDefault(x => x.Id == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateTeacher(Teacher teacher)
        {

            _teacherService.Update(teacher);
            return View();
        }


        public IActionResult TeacherList()
        {
            var result = _teacherService.GetAll();
            return View(result);
        }


        public IActionResult TeacherDeleteById(int id)
        {
            var ent = _teacherService.GetId(id);
            _teacherService.Delete(ent);
            return RedirectToAction("List");
        }

    }
}
