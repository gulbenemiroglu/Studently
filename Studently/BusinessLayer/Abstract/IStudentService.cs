using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        void Add(Student student);
        void Delete(Student student);
        void Update(Student student);
        List<Student> GetAll();
        Student GetId(int studentId);
    }
}
