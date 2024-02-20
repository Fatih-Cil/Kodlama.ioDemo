using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
            
        }

        public bool Add(Course course)
        {
            if (course.InstructorId!>0 || course.CategoryId!>0 || course.Title == "" || course.Explanation=="" || course.Fee==null || course.ImgUrl=="") return false;

            _courseDal.Add(course);
            return true;

        }

        public bool Delete(Course course)
        {
            var result = GetById(course.Id);
            if (result != null)
            {
                _courseDal.Delete(course);
                return true;
            }
            return false;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public bool Update(Course course)
        {
            var result = GetById(course.Id);
            if (result != null)
            {
                _courseDal.Update(course);
                return true;
            }

            return false;
        }
    }
}
