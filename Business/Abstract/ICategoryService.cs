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
        (int statusCode, string message) Add(Category category);
        (int statusCode, string message) Update(Category category);
        (int statusCode, string message) Delete(Category category);
    }
}
