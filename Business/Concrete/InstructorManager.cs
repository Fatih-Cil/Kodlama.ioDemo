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
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
