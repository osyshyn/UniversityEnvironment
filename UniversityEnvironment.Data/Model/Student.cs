using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class Student : User
    {
        private List<Test>? _tests;
        private List<QuestionAnswer>? _questionAnswers;
        public List<Test>? Tests { get => _tests; set => _tests = value; }
        public List<QuestionAnswer>? QuestionAnswers { get => _questionAnswers; set => _questionAnswers = value; }
    }
}
