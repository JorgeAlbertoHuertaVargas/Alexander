

using ENTIDADES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PresentacionWeb.Models
{
    public class CourseViewModels
    {
        public Course Courses { get; set; }
        public List<Course> DegreeList { get; set; }
    }
}
