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
        public string? ScienceDegree { get => _scienceDegree; set => _scienceDegree = value; }
    }
}
