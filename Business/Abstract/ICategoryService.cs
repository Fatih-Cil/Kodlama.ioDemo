using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {

        List<Category> GetAll();
        Category GetById(int id);   
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(Category category);
    }
}
