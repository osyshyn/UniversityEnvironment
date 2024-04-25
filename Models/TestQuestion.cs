using UniversityEnvironment.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.View.Models
{
    public sealed class TestQuestion : EnvironmentObject
    {
        private List<QuestionAnswer> _answers;
        public List<QuestionAnswer> Answers { get => _answers; set => _answers = value; }
        public TestQuestion() : base()
        {
        }
        public override string GetJson()
        {
            var json = "{";
            if (Answers?.Count > 0)
            {
                json = " Answers: [";
                foreach (var Answers in Answers)
                {
                    json += Answers.GetJson() + ",";
                }

                json += "], ";
            }
            json += " id: " + Id + "}";

            return json;
        }
    }
}
