using UniversityEnvironment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnvironment.Forms;
using UniversityEnvironment.Models;

namespace UniversityEnvironment.Utility
{
    public class FormCreater
    {
        public static Form CreateForm(string formName, User user, Course course)
        {
            Type formType = Type.GetType("UniversityEnvironment.Forms." + formName);

            if (formType != null && formType.IsSubclassOf(typeof(Form)))
            {
                Form formInstance = (Form)Activator.CreateInstance(formType, user, course);
                return formInstance;
            }
            else
            {
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }
        public static Form CreateTestForm(string formName, User user, Course course, Test test)
        {
            Type formType = Type.GetType("UniversityEnvironment.Forms." + formName);

            if (formType != null && formType.IsSubclassOf(typeof(Form)))
            {
                Form formInstance = (Form)Activator.CreateInstance(formType, user, course, test);
                return formInstance;
            }
            else
            {
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }
    }
}
