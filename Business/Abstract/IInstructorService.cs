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
        (int statusCode, string message) Add(Instructor instructor);
        (int statusCode, string message) Update(Instructor instructor);
        (int statusCode, string message) Delete(Instructor instructor);
    }
}
