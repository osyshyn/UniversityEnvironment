using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UniversityEnvironment.Models;

namespace UniversityEnvironment.Forms
{
    public partial class BaseTestForm : MaterialForm
    {
        protected readonly User _user;
        protected readonly Course _course;
        protected readonly Test _test;
        protected readonly List<QuestionAnswer> _answers;
        protected readonly List<TestQuestion> _questions;
        protected List<List<bool>> _questionsAnswers;

        public BaseTestForm()
        {
            InitializeComponent();
        }
        public BaseTestForm(User user, Course course, Test test)
        {
            Text = course.Name;
            _user = user;
            _course = course;
            _test = test;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
