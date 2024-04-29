using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class QuestionAnswerStudent
    {
        public Guid StudentId { get; set; }
        public Guid QuestionAnswerId { get; set; }
        public Student? Student { get; set; }
        public QuestionAnswer? QuestionAnswer { get; set; }
    }
}
