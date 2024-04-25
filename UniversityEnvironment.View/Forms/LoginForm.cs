using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.View.Forms;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.View.Utility;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repositories;


namespace UniversityEnvironment.View.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialFormSkinChanger.SetParametersOfForm(this);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationWindow = new RegistrationForm();
            registrationWindow.FormClosed += (s, arg) =>
            {
                Show();
            };
            registrationWindow.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User actualUser = new User();
            if (AdminCheck.Checked)
            {
                var ourAdmin = RepositoryManager.GetRepo<User>()
                    .GetByFilter(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
                if (ourAdmin != null)
                {
                    actualUser.Id = ourAdmin.Id;
                    actualUser.Username = ourAdmin.Username;
                    actualUser.FirstName = ourAdmin.FirstName;
                    actualUser.LastName = ourAdmin.LastName;
                    actualUser.Password = ourAdmin.Password;
                    actualUser.Courses = ourAdmin.Courses;
                    actualUser.Role = "Admin";
                }
            }
            else if (TeacherCheck.Checked)
            {
                var ourTeacher = RepositoryManager.GetRepo<Teacher>()
                    .GetByFilter(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
                if (ourTeacher != null)
                {
                    actualUser.Id = ourTeacher.Id;
                    actualUser.Username = ourTeacher.Username;
                    actualUser.FirstName = ourTeacher.FirstName;
                    actualUser.LastName = ourTeacher.LastName;
                    actualUser.Password = ourTeacher.Password;
                    actualUser.Courses = ourTeacher.Courses;
                    actualUser.Role = "Teacher";
                }
            }
            else
            {
                var ourStudent = RepositoryManager.GetRepo<Student>()
                    .GetByFilter(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);
                if (ourStudent != null)
                {
                    actualUser.Id = ourStudent.Id;
                    actualUser.Username = ourStudent.Username;
                    actualUser.FirstName = ourStudent.FirstName;
                    actualUser.LastName = ourStudent.LastName;
                    actualUser.Password = ourStudent.Password;
                    actualUser.Courses = ourStudent.Courses;
                    actualUser.Role = "Student";
                }
            }

            if (actualUser.Role != null)
            {
                Hide();
                EnvironmentForm ViewForm = new EnvironmentForm(actualUser);
                ViewForm.FormClosed += (s, arg) =>
                {
                    Show();
                };
                ViewForm.Show();
                return;
            }
            MessageBox.Show("Wrong username or password...", "Login", MessageBoxButtons.OK);
        }
    }
}
