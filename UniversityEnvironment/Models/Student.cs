using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniversityEnvironment.Models
{
    public sealed class Student : User, IStudentFeatures
    {
        private int _mark;

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
        public Student(string username = "", string firstName = "", string lastName = "") : base(username, firstName, lastName)
        {
            Mark = 0;
        }

        public override string GetJson()
        {
            return "{name: " + Username + ", mark: " + Mark + "}";
        }

        public void ShowProfile(string username = "")
        {

        }
        public void SendMessage()
        {

        }
        public void UnsignFromCourse()
        {

        }
    }
}
