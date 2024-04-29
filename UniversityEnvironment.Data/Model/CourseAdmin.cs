using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class CourseAdmin
    {
        public Guid AdminId { get; set; }
        public Guid CourseId { get; set; }
        public Admin? Admin {  get; set; }
        public Course? Course { get; set; }
    }
}
