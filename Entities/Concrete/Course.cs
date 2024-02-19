using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public decimal Fee { get; set; }
        public string ImgUrl { get; set; }


        public virtual Category Category { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
