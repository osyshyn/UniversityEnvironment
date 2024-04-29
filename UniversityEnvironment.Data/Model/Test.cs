using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class Test : EnvironmentObject
    {
        private string? _name;
        private string? _description;
        private Course? _course;
        private List<Student>? _students;
        private List<TestMark>? _marks;
        private List<TestStudent>? _testStudents;
        private List<TestQuestion>? _questions;
        public string? Name { get => _name; set => _name = value; }
        public string? Description { get => _description; set => _description = value; }
        public Course? Course { get => _course; set => _course = value; }
        public List<Student>? Students { get => _students; set => _students = value; }
        public List<TestMark>? Marks { get => _marks; set => _marks = value; }
        public List<TestQuestion>? Questions { get => _questions; set => _questions = value; }
        public List<TestStudent>? TestsStudents { get => _testStudents; set => _testStudents = value; }
    }
}
