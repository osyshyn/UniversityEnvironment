using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class TestMark : EnvironmentObject
    {
        private Test? _test;
        private int _mark = 0;
        private Guid _studentId;
        public Test? Test { get => _test; set => _test = value; }
        public int Mark
        {
            get => _mark;

            set
            {

                if (value < 2 && value != 0 || value > 5 && value != 0)
                {
                    throw new ArgumentException("Неприпустима оцінка. Оцінка повинна бути 2, 3, 4 або 5.");
                }
                _mark = value;
            }
        }
        public Guid StudentId { get => _studentId; set => _studentId = value; }
    }
}
