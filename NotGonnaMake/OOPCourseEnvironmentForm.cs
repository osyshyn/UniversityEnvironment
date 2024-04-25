using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using UniversityEnvironment.View.Forms;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.View.Utility;

namespace UniversityEnvironment.View.Forms
{
    public sealed partial class OOPCourseEnvironmentForm : UniversityEnvironment.View.Forms.CourseEnvironmentForm
    {
        public OOPCourseEnvironmentForm(Models.User user, Course course) : base(user, course)
        {

            InitializeComponent();
        }

        private void Exam1Button_Click(object sender, EventArgs e)
        {
            Hide();

            Form formInstance = FormCreater.CreateTestForm("Test1" + _course.Name + "CourseForm", _user, _course, _course.Tests[0]);
            formInstance.FormClosed += (s, arg) =>
            {
                Show();
            };
            formInstance.Show();
        }

        private void Exam2Button_Click(object sender, EventArgs e)
        {
            Hide();

            Form formInstance = FormCreater.CreateTestForm("Test2" + _course.Name + "CourseForm", _user, _course, _course.Tests[1]);
            formInstance.FormClosed += (s, arg) =>
            {
                Show();
            };
            formInstance.Show();
        }
    }
}
