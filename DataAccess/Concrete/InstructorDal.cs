using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {

        List<Instructor> _instructors;

        public InstructorDal()
        {
            if (_instructors == null)
            {
                _instructors = new List<Instructor>()
            {
                    new Instructor() { Id=1, Name="Fatih",Surname="Çil",Career="Burası kendimi anlattığım bölüm",ImgUrl="imageurladresi"},
                    new Instructor() { Id=2, Name="AlexDe",Surname="Souza",Career="Ebedi Fenerbahçe kaptanı",ImgUrl="image_url_adresi"},
                };
            }

        }

        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructors.Remove(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.Find(x => x.Id == id);
        }

        public void Update(Instructor entity)
        {
            var updateEntity = _instructors.Find(x => x.Id == entity.Id);
            if (updateEntity != null)
            {
                updateEntity.Name = entity.Name;
                updateEntity.Surname= entity.Surname;
                updateEntity.Career= entity.Career;
                updateEntity.ImgUrl = entity.ImgUrl;
            }
        }
    }
}
