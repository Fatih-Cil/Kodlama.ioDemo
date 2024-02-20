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
        (int statusCode, string message) Add(Course course);
        (int statusCode, string message) Update(Course course);
        (int statusCode, string message) Delete(Course course);
    }
}
