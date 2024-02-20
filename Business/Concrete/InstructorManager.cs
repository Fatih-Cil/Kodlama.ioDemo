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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instractorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instractorDal = instructorDal;
        }
        public (int statusCode, string message) Add(Instructor instructor)
        {
            if (instructor.Name == "") return  (400, "Eğitmen adı boş olamaz");

            _instractorDal.Add(instructor);
            return (201,"Eğitmen kayıt edildi.");
        }

        public (int statusCode, string message) Delete(Instructor instructor)
        {
            var result = GetById(instructor.Id);
            if (result != null)
            {
                _instractorDal.Delete(instructor);
                return (204, "Eğitmen Silindi");
            }

            return  (404, "Bu id'ye ait bir eğitmen bulunamadı."); ;
        }

        public List<Instructor> GetAll()
        {
            return _instractorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instractorDal.GetById(id);
        }

        public (int statusCode, string message) Update(Instructor instructor)
        {
            var result = GetById(instructor.Id);
            if (result != null)
            {
                _instractorDal.Update(instructor);
                return (200, "Güncelleme yapıldı.");
            }

            return (404, "Bu id'ye ait bir eğitmen bulunamadı.");
        }
    }
}
