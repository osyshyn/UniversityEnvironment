using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public sealed class TestQuestion : EnvironmentObject
    {
        private Test? _test;
        private List<QuestionAnswer>? _answers;
        public Test? Test { get => _test; set => _test = value; }
        public List<QuestionAnswer>? Answers { get => _answers; set => _answers = value; }
    }
}
