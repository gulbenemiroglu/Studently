using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherService
    {
        void Add(Teacher teacher);
        void Delete(Teacher teacher);
        void Update(Teacher teacher);
        List<Teacher> GetAll();
        Teacher GetId(int teacherId);
    }
}
