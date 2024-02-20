using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        bool Add(Course course);
        bool Update(Course course);
        bool Delete(Course course);
    }
}
