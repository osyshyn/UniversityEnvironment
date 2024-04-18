using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.Models;
using UniversityEnvironment.Repository;
using static UniversityEnvironment.Utility.Predicates;
using static UniversityEnvironment.Utility.Constants;

namespace UniversityEnvironment.Forms
{
    public partial class CourseEnvironmentForm : MaterialForm
    {
        protected readonly User _user;
        protected readonly Course _course;

        public CourseEnvironmentForm()
        {
            InitializeComponent();
        }
        public CourseEnvironmentForm(User user, Course course)
        {
            _user = user;
            _course = course;
            this.Text = "Welcome to " + course.Name + " course!";
            InitializeComponent();
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<Course>(TeacherTable, 1, _course, UpdateTeacherTable);
        }

        private void JournalButton_Click(object sender, EventArgs e)
        {
            RepositoryManager.GetRepo<Course>(CoursesDBPath).ReadingOperationsWithTable<Course>(TeacherTable, 1, _course, UpdateTeacherTable);
            Hide();
            JournalForm journalForm = new JournalForm(_user, _course);
            journalForm.FormClosed += (s, arg) =>
            {
                Show();
            };
            journalForm.Show();
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
