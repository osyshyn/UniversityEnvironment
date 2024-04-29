using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class Admin : User
    {
        private List<CourseAdmin>? _coursesAdmins;
        public List<CourseAdmin>? CoursesAdmins { get => _coursesAdmins; set => _coursesAdmins = value; } 
    }
}
