using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class LessonController : Controller
    {
        Context contex = new Context();
        ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        public IActionResult AddLesson()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddLesson(Lesson lesson)
        {
            _lessonService.Add(lesson);
            return View();
        }
        [HttpGet]
        public IActionResult DeleteLesson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteLesson(Lesson lesson)
        {
            _lessonService.Delete(lesson);
            return View();
        }
        [HttpGet]
        public IActionResult UpdateLesson(int id)
        {
            var result = contex.Lessons.FirstOrDefault(x => x.LessonId == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateLesson(Lesson lesson)
        {

            _lessonService.Update(lesson);
            return View();
        }
        public IActionResult ListLesson()
        {
            var result = _lessonService.GetAll();
            return View(result);
        }
        public IActionResult LessonDeleteById(int id)
        {
            var ent = _lessonService.GetId(id);
            _lessonService.Delete(ent);
            return RedirectToAction("ListLesson","Lesson");
        }
    }
}
