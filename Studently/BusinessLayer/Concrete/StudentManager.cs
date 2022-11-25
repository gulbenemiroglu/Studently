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
    public class StudentManager : IStudentService
    {
        IStudent _studentDal;
        public StudentManager(IStudent studentDal)
        {
            _studentDal=studentDal;
        }
        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student GetId(int studentId)
        {
            return _studentDal.GetId(studentId);

        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
