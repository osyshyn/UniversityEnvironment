using UniversityEnvironment.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UniversityEnvironment.View.Models
{
    public class Teacher : User, ITeacherFeatures
    {
        private string _scienceDegree;
        public string ScienceDegree { get => _scienceDegree; set => _scienceDegree = value; }
        public Teacher(string username = "", string firstName = "", string lastName = "", string scienceDegree = "") : base(username, firstName, lastName)
        {
            _scienceDegree = scienceDegree;
        }
        public void ShowProfile(string username = "")
        {

        }
        public void SendMessage()
        {

        }
    }
}
