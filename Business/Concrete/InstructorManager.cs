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
        public bool Add(Instructor instructor)
        {
            if (instructor.Name == "") return false;

            _instractorDal.Add(instructor);
            return true;
        }

        public bool Delete(Instructor instructor)
        {
            var result = GetById(instructor.Id);
            if (result != null)
            {
                _instractorDal.Delete(instructor);
                return true;
            }

            return false;
        }

        public List<Instructor> GetAll()
        {
            return _instractorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instractorDal.GetById(id);
        }

        public bool Update(Instructor instructor)
        {
            var result = GetById(instructor.Id);
            if (result != null)
            {
                _instractorDal.Update(instructor);
                return true;
            }

            return false;
        }
    }
}
