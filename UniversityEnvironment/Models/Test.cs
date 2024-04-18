using UniversityEnvironment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Models;

namespace UniversityEnvironment.Models
{
    public sealed class Test : EnvironmentObject, IObjectManager<Student>
    {
        private string _name;
        private string _description;
        private List<Student> _students;
        private List<TestQuestion> _questions;
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public List<TestQuestion> Questions { get => _questions; set => _questions = value; }
        public List<Student> Students { get => _students; set => _students = value; }
        public Test(string name = "", string description = "") : base()
        {
            _name = name;
            _description = description;
        }

        public List<Student> AddObject(Student student)
        {
            _students.Add(student);
            return _students;
        }
        public List<Student> RemoveObject(Student student)
        {
            _students.Remove(student);
            return _students;
        }

        public override string GetJson()
        {
            var json = "{ name: " + Name + ", Description: " + Description + ",";
            if (Questions?.Count > 0)
            {
                json = " question: [";
                foreach (var question in Questions)
                {
                    json += question.GetJson() + ",";
                }

                json += "], ";
            }

            if (Students?.Count > 0)
            {
                json = " students: [";

                foreach (var student in Students)
                {
                    json += student.GetJson() + ",";
                }

                json += "], ";
            }
            json += " id: " + Id + "}";

            return json;
        }
    }
}
