using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using UniversityEnvironment.Data.Model;
using System.Xml.Linq;
using UniversityEnvironment.View.Utility;
using System.Collections.Generic;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repository;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.ViewGridHelper;

namespace UniversityEnvironment.View.Forms

{
    public partial class EnvironmentForm : MaterialForm
    {
        private readonly User _user;

        public EnvironmentForm(User user)
        {
            InitializeComponent();
            _user = user;
            PersonName.Text = user.FirstName + " " + user.LastName;
            PersonRole.Text = user.Role;
            UpdateTableWithAvailableCourses(AvailableCoursesTable, RepositoryManager.GetRepo<Course>().GetAll().ToList());
            UpdateTableWithActualCourses(ActualCoursesTable, user);
        }
        
        private void SignButton_Click(object sender, EventArgs e)
        {
            SignUserOnCourse(AvailableCoursesTable, _user);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            UnsignUserFromCourse(AvailableCoursesTable, _user);   
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = ActualCoursesTable.Rows[e.RowIndex];
                string? selectedCourse = selectedRow.Cells["ActualGridColumnCourseName"].Value.ToString();
                if (RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Name == selectedCourse) != null)
                {
                    Course? course = RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Name == selectedCourse);
                    Hide();
                    Form formInstance = FormCreater.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
                    formInstance.FormClosed += (s, arg) =>
                    {
                        Show();
                    };
                    formInstance.Show();
                }

            }*/
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
