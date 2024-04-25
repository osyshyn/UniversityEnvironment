using UniversityEnvironment.Data.Model;
using UniversityEnvironment.View.Utility;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft;
using System.Windows.Forms;
using Newtonsoft.Json;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.View.Repository;
using static UniversityEnvironment.View.Utility.FormHelper;
using Microsoft.VisualBasic.ApplicationServices;


namespace UniversityEnvironment.View.Forms
{
    public sealed partial class Test2OOPCourseForm : UniversityEnvironment.View.Forms.BaseTestForm
    {
        public Test2OOPCourseForm()
        {
            InitializeComponent();
        }
        public Test2OOPCourseForm(Models.User user, Course course, Test test) : base(user, course, test)
        {
            InitializeComponent();
            if (user.Role != "Teacher")
            {
                Question1Table.Visible = false;
                Question2Table.Visible = false;
                Question3Table.Visible = false;
            }
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            List<bool> question1 = new List<bool> { Q1Answer1.Checked, Q1Answer2.Checked, Q1Answer3.Checked };
            List<bool> question2 = new List<bool> { Q2Answer1.Checked, Q2Answer2.Checked, Q2Answer3.Checked };
            List<bool> question3 = new List<bool> { Q3Answer1.Checked, Q3Answer2.Checked, Q3Answer3.Checked };
            _questionsAnswers = new List<List<bool>> { question1, question2, question3 };
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadAndWriteOperations(_user, _course, _test, _questionsAnswers, SendTestAnswers);
            Close();
        }

        private void Q1Box_CheckedChanged(object sender, EventArgs e)
        {
            List<bool> question1 = new List<bool> { Q1Answer1.Checked, Q1Answer2.Checked, Q1Answer3.Checked };
            for (int i = 0; i < question1.Count; i++)
            {
                if (question1[i])
                {
                    Question1Table.Rows.Clear();
                    foreach (var student in _test.Questions[0].Answers[i].Students)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Question1Table);
                        row.Cells[0].Value = student.Username;
                        Question1Table.Rows.Add(row);
                    }
                    break;
                }
            }
        }

        private void Q2Box_CheckedChanged(object sender, EventArgs e)
        {
            List<bool> question2 = new List<bool> { Q2Answer1.Checked, Q2Answer2.Checked, Q2Answer3.Checked };
            for (int i = 0; i < question2.Count; i++)
            {
                if (question2[i])
                {
                    Question2Table.Rows.Clear();
                    foreach (var student in _test.Questions[0].Answers[i].Students)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Question1Table);
                        row.Cells[0].Value = student.Username;
                        Question2Table.Rows.Add(row);
                    }
                    break;
                }
            }
        }

        private void Q3Box_CheckedChanged(object sender, EventArgs e)
        {
            List<bool> question3 = new List<bool> { Q3Answer1.Checked, Q3Answer2.Checked, Q3Answer3.Checked };
            for (int i = 0; i < question3.Count; i++)
            {
                if (question3[i])
                {
                    Question3Table.Rows.Clear();
                    foreach (var student in _test.Questions[0].Answers[i].Students)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Question1Table);
                        row.Cells[0].Value = student.Username;
                        Question3Table.Rows.Add(row);
                    }
                    break;
                }
            }
        }
    }
}
