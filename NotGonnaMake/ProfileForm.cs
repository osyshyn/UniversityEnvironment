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
using UniversityEnvironment.Data.Model;

namespace UniversityEnvironment.View.Forms
{
    public partial class ProfileForm : MaterialForm
    {
        public ProfileForm(Course course, User user)
        {
            this.Text = course.Name;
            InitializeComponent();
        }


    }
}
