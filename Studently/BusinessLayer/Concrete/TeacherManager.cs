using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeacherManager: ITeacherService
    {
        ITeacher _teacherDal;

        public TeacherManager(ITeacher teacherDal)
        {
            _teacherDal = teacherDal;
        }
   
        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);

        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public Teacher GetId(int teacherId)
        {
            return _teacherDal.GetId(teacherId);
        }

        public void Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
        }
    }
}
