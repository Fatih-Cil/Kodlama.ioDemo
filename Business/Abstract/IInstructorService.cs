using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        bool Add(Instructor instructor);
        bool Update(Instructor instructor);
        bool Delete(Instructor instructor);
    }
}
