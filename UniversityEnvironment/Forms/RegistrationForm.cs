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
using UniversityEnvironment.Models;
using static UniversityEnvironment.Utility.Constants;
using UniversityEnvironment.Repository;

namespace UniversityEnvironment.Forms
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrateAccountButton_Click(object sender, EventArgs e)
        {
            var role = (TeacherCheck.Checked == true) ? "Teacher" : "Student";
            var user = new User(UsernameTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text, role);
            if (RepositoryManager.GetRepo<User>(UsersDBPath).GetObjectByFilter(u => u.Id == user.Id) == null)
            {
                RepositoryManager.GetRepo<User>(UsersDBPath).AddObject(user);
                MessageBox.Show("Account created successfully!", "Registration", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Account with such name exist...", "Registration", MessageBoxButtons.OK);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
