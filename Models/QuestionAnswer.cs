using UniversityEnvironment.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model;

namespace UniversityEnvironment.View.Models
{
    public sealed class QuestionAnswer : EnvironmentObject
    {
        private List<Student> _students;
        public List<Student> Students { get => _students; set => _students = value; }
        public QuestionAnswer() : base()
        { }
        public override string GetJson()
        {
            var json = "{";
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

    public static class MyDeserialize<T> where T : EnvironmentObject
    {
        public static string Deserialize(T obj)
        {
            return obj.GetJson();
        }
    }
}
