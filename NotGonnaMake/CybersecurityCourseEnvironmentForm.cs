﻿using Microsoft.VisualBasic.ApplicationServices;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.View.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniversityEnvironment.View.Forms
{
    public sealed partial class CybersecurityCourseEnvironmentForm : UniversityEnvironment.View.Forms.CourseEnvironmentForm
    {

        public CybersecurityCourseEnvironmentForm(Models.User user, Course course) : base(user, course)
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
    }
}
