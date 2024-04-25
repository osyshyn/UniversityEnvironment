using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class Course : EnvironmentObject
    {
        private string? _name;
        private string? _facultyName;
        private List<Test>? _tests;
        private List<Admin>? _admins;
        private List<Teacher>? _teachers;
        private List<Student>? _students = new List<Student>();

        public string? Name { get => _name; set => _name = value; }
        public string? FacultyName { get => _facultyName; set => _facultyName = value; }
        public List<Test>? Tests { get => _tests; set => _tests = value; }
        public List<Admin>? Admins { get => _admins; set => _admins = value; }
        public List<Teacher>? Teachers { get => _teachers; set => _teachers = value; }
        public List<Student>? Students { get => _students; set => _students = value; }
    }
}
