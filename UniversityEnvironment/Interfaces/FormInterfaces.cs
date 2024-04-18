using MaterialSkin.Controls;
using UniversityEnvironment.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnvironment.Forms;

namespace UniversityEnvironment.Interfaces
{
    interface IApplicationState
    {
        void ShowUIElements();
    }

    public class ProfileFormState : IApplicationState
    {
        private readonly ProfileForm _form;

        public ProfileFormState(ProfileForm form)
        {
            _form = form;
        }

        public void ShowUIElements()
        {
            _form.Show();
        }
    }
    public class TestFormState : IApplicationState
    {
        private readonly ProfileForm _form;

        public TestFormState(ProfileForm form)
        {
            _form = form;
        }

        public void ShowUIElements()
        {
            _form.Show();
        }
    }
}
