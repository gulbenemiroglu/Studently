using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILessonService
    {
        void Add(Lesson lesson);
        void Delete(Lesson lesson);
        void Update(Lesson lesson);
        List<Lesson> GetAll();
        Lesson GetId(int lessonId);
    }
}
