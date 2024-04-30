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

        private T SetRole<T>() where T : User
        {
            var role = typeof(T).Name;
            var user = RepositoryManager.GetRepo<T>()
                    .FindByFilter(u => u.Username == UsernameTextBox.Text && u.Password == PasswordTextBox.Text);

            user.Role = role;
            return user;
        }

        private void ShowNextForm(MaterialForm current, MaterialForm next) where TNext : MaterialForm
        {
            current.Hide();
            next.FormClosed += (s, arg) => current.Show();
            next.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user;
            if (Admin.Checked)
                user = SetRole<Admin>();
            else if (TeacherCheck.Checked)
                user = SetRole<Teacher>();
            else
                user = SetRole<Student>();

            if (user.Role != null)
            {
                ShowNextForm(this, new EnvironmentForm(user));
               
                return;
            }
            MessageBox.Show("Wrong username or password...", "Login", MessageBoxButtons.OK);
        }
    }
}
