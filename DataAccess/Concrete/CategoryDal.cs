using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public CategoryDal()
        {
            if (_categories == null)
            {
                _categories = new List<Category>()
            {
                    new Category() { Id=1, Name="Programlama"},
                    new Category() { Id=2, Name="O.S."}
                };
            }
        }

        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categories.Remove(entity);
        }

        public Category GetById(int id)
        {
            //Bulamama durumuna karşı geriye null değer döndürmesi için Find kullandım.
            return _categories.Find(x => x.Id == id);
        }

        public bool FindByName(string name)
        {
         var result= _categories.Find(x => x.Name.ToLower() == name.ToLower());
            if (result != null) return true; 
            return false;  
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category entity)
        {
            var updateEntity = _categories.Find(x => x.Id == entity.Id);
            if (updateEntity != null)
            {
                updateEntity.Name = entity.Name;
            }

        }
    }
}
