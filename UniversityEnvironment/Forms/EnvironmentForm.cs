using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using UniversityEnvironment.Models;
using Newtonsoft;
using System.Xml.Linq;
using UniversityEnvironment.Utility;
using Newtonsoft.Json;
using System.Collections.Generic;
using static UniversityEnvironment.Utility.Predicates;
using static UniversityEnvironment.Utility.Constants;
using UniversityEnvironment.Repository;

namespace UniversityEnvironment.Forms

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
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(AvailableCoursesTable, 1, _user, UpdateTableWithAvailableCourses);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadAndWriteOperationsWithTable<User>(AvailableCoursesTable, 0, _user, SignUserOnCourse);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
        }

        private void UnsignButton_Click(object sender, EventArgs e)
        {
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadAndWriteOperationsWithTable<User>(AvailableCoursesTable, 0, _user, UnsignUserFromCourse);
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<User>(ActualCoursesTable, 1, _user, UpdateTableWithActualCourses);
        }

        private void ActualCoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = ActualCoursesTable.Rows[e.RowIndex];
                string selectedCourse = selectedRow.Cells["ActualGridColumnCourseName"].Value.ToString();
                if (RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Name == selectedCourse) != null)
                {
                    var course = RepositoryManager.GetRepo<Course>(CoursesDBPath).GetObjectByFilter(c => c.Name == selectedCourse);
                    Hide();
                    Form formInstance = FormCreater.CreateForm(course.Name + "CourseEnvironmentForm", _user, course);
                    formInstance.FormClosed += (s, arg) =>
                    {
                        Show();
                    };
                    formInstance.Show();
                }

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignButton_Click_1(object sender, EventArgs e)
        {

        }

        private void UnsignButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
