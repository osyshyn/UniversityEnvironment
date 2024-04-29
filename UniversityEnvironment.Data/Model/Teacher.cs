using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class Teacher : User
    {
        private string? _scienceDegree;
        private List<CourseTeacher>? _coursesTeachers;
        public string? ScienceDegree { get => _scienceDegree; set => _scienceDegree = value; }
        public List<CourseTeacher>? CoursesTeachers { get => _coursesTeachers; set => _coursesTeachers = value; }
    }
}
