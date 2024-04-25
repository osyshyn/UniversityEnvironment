using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace UniversityEnvironment.View.Utility
{
    public static class MaterialFormSkinChanger
    {
        public static void SetParametersOfForm(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange500, Primary.Orange500, Primary.Orange500, Accent.Orange400, TextShade.WHITE);
        }
    }
}
