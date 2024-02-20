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

        public (int statusCode, string message) Add(Course course)
        {
            if (course.Title == "" || course.Explanation=="" ) return (400,"Kurs adı, açıklama ve boş geçilemez.");
            if (course.InstructorId! > 0 || course.CategoryId! > 0) return (400, "Kategori ve eğitmen boş geçilemez");
            _courseDal.Add(course);
            return (201,"Kurs eklendi");

        }

        public (int statusCode, string message) Delete(Course course)
        {
            var result = GetById(course.Id);
            if (result != null)
            {
                _courseDal.Delete(course);
                return (204, "Kurs Silindi");
            }
            return (404, "Bu id'ye ait bir kurs bulunamadı.");
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public (int statusCode, string message) Update(Course course)
        {
            var result = GetById(course.Id);
            if (result != null)
            {
                _courseDal.Update(course);
                return (200, "Güncelleme yapıldı.");
            }

            return (404, "Bu id'ye ait bir kurs bulunamadı.");
        }
    }
}
