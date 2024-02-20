using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public bool Add(Category category)
        {


            if (category.Name == "") return false;

            _categoryDal.Add(category);
            return true;

        }

        public bool Delete(Category category)
        {
            var result = GetById(category.Id);
            if (result != null)
            {
                _categoryDal.Delete(category);
                return true;
            }
            return false;

        }

        public List<Category> GetAll()
        {

            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {

            return _categoryDal.GetById(id);

        }

        public bool Update(Category category)
        {
            var result = GetById(category.Id);
            if (result != null)
            {
                _categoryDal.Update(category);
                return true;
            }

            return false;
        }


    }


}
