using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class QuestionAnswer : EnvironmentObject
    {
        private TestQuestion? _question;
        private List<Student>? _students;
        public TestQuestion? Question { get => _question; set => _question = value; }
        public List<Student>? Students { get => _students; set => _students = value; }
    }
}
