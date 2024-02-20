using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class CourseDetail
    {
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public decimal Fee { get; set; }
    }
}
