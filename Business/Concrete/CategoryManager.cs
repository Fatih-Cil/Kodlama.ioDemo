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


        public (int statusCode,string message) Add(Category category)
        {


            if (category.Name == "") return (400,"Kategori adı boş olamaz");

            if (_categoryDal.FindByName(category.Name)) return (400, "Bu isimde bir kategori mevcut.");
          
                _categoryDal.Add(category);
            return (201,"Kategori Eklendi");

        }

        public (int statusCode, string message) Delete(Category category)
        {
            var result = GetById(category.Id);
            if (result != null)
            {
                _categoryDal.Delete(category);
                return (204,"Kategori Silindi");
            }
            return (404, "Bu id'ye ait bir kategori bulunamadı.");

        }

        public List<Category> GetAll()
        {

            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {

            return _categoryDal.GetById(id);

        }

        public (int statusCode, string message) Update(Category category)
        {
            if (category.Name == "") return (400, "Kategori adı boş olamaz");
            var result = GetById(category.Id);
            if (result != null)
            {
                _categoryDal.Update(category);
                return (200,"Güncelleme yapıldı.");
            }

            return (404,"Bu id'ye ait bir kategori bulunamadı.");
        }


    }


}
