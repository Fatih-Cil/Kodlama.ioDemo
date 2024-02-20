using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {

        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>()
            {
                new Course() { Id=1, CategoryId=1, InstructorId=1, Title="C#", Explanation="Tüm detayları ile C# öğrenmek için bu kurs tam size göre.", Fee=0, ImgUrl="Curse_image_url_buraya"},
                new Course() { Id=2, CategoryId=2, InstructorId=2, Title="Linux", Explanation="Kurulum, hata yakalama, disk işlemleri, performans kontrollerinde ve daha fazlası bu kursta sizi bekliyor.", Fee=0, ImgUrl="Curse_image_url_buraya"}
            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courses.Remove(entity);
        }

        public List<Course> GetAll()
        {
           return _courses;

        }

        public Course GetById(int id)
        {
           return _courses.Find(x => x.Id == id);
        }

        public void Update(Course entity)
        {
            var updateEntity = _courses.Find(x => x.Id == entity.Id);
            if (updateEntity != null)
            {
                updateEntity.CategoryId = entity.CategoryId;
                updateEntity.InstructorId = entity.InstructorId;
                updateEntity.Title = entity.Title;
                updateEntity.Explanation = entity.Explanation;
                updateEntity.Fee = entity.Fee;
                updateEntity.ImgUrl = entity.ImgUrl;
            }
        }

       
    }
}
