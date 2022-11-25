using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LessonManager:ILessonService
    {
        ILesson _lessonDal;
        public LessonManager(ILesson lessonDal)
        {
            _lessonDal = lessonDal;
        }
        public void Add(Lesson lesson)
        {
            _lessonDal.Add(lesson);

        }

        public void Delete(Lesson lesson)
        {
            _lessonDal.Delete(lesson);
        }

        public List<Lesson> GetAll()
        {
            return _lessonDal.GetAll();
        }

        public Lesson GetId(int lessonId)
        {
            return _lessonDal.GetId(lessonId);
        }

        public void Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
        }
    }
}
