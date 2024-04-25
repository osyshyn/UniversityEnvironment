using System;
using System.IO;
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
using UniversityEnvironment.Data.Model;
using static UniversityEnvironment.View.Utility.Constants;
using UniversityEnvironment.Data.Repositories;

namespace UniversityEnvironment.View.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrateAccountButton_Click(object sender, EventArgs e)
        {
            if (AdminCheck.Checked)
            {
                if(RepositoryManager.GetRepo<Admin>().GetByFilter(u => u.Username == UsernameTextBox.Text) == null)
                {
                    var user = new Admin
                    {
                        Username = UsernameTextBox.Text,
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        Password = PasswordTextBox.Text,
                        Role = "Admin",
                        Courses = new List<Course>()
                    };
                    RepositoryManager.GetRepo<Admin>()
                        .Create(user);
                    MessageBox.Show("Account created successfully!", "Registration", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
            }
            if (TeacherCheck.Checked)
            {
                string scienceDegree = Microsoft.VisualBasic.Interaction.InputBox("Введіть вашу ступінь:", "Введення тексту", "");
                if (RepositoryManager.GetRepo<Teacher>().GetByFilter(u => u.Username == UsernameTextBox.Text) == null)
                {
                    var user = new Teacher
                    {
                        Username = UsernameTextBox.Text,
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        Password = PasswordTextBox.Text,
                        Role = "Teacher",
                        ScienceDegree = scienceDegree,
                        Courses = new List<Course>()
                    };
                    RepositoryManager.GetRepo<Teacher>()
                        .Create(user);
                    MessageBox.Show("Account created successfully!", "Registration", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
            }
            else
            {
                if (RepositoryManager.GetRepo<Student>().GetByFilter(u => u.Username == UsernameTextBox.Text) == null)
                {
                    var user = new Student
                    {
                        Username = UsernameTextBox.Text,
                        FirstName = FirstNameTextBox.Text,
                        LastName = LastNameTextBox.Text,
                        Password = PasswordTextBox.Text,
                        Role = "Student",
                        Courses = new List<Course>()
                    };
                    RepositoryManager.GetRepo<Student>()
                        .Create(user);
                    MessageBox.Show("Account created successfully!", "Registration", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
            }
        }


        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
