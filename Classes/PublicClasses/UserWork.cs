using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace CafeApplication.Classes.PublicClasses
{
    internal class UserWork
    {
        public void ShowHidePass(TextBox txt, RadButton btn)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
                btn.Image = Image.FromFile(Application.StartupPath + @"/Assets/Icons/Mainmenu/userMenu/closeEye-Icon.png");
                btn.Text = "مخفی کردن رمز";
            }
            else
            {
                txt.PasswordChar = '*';
                btn.Image = Image.FromFile(Application.StartupPath + @"/Assets/Icons/Mainmenu/userMenu/eye-Icon.png");
                btn.Text = "نمایش رمز";
            }
        }

        public void SetCmbRole(ComboBox cmb ,TextBox txt)
        {

            switch (txt.Text)
            {
                case "مدیر":
                    cmb.SelectedIndex = 0;
                    break;
                case "حسابدار":
                    cmb.SelectedIndex = 1;
                    break;
                case "فروشنده":
                    cmb.SelectedIndex = 2;
                    break;
                case "انباردار":
                    cmb.SelectedIndex = 3;
                    break;
                default:
                    cmb.SelectedIndex = 0;
                    break;
            }
        }
    }
}
