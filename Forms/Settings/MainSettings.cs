using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CafeApplication.Forms.Settings
{
    public partial class MainSettings : Form
    {
        public MainSettings()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            txt_Search.Padding = new System.Windows.Forms.Padding(10 ,10 , 10 , 10 );
            SetTabPanelStyle();
        }

        public void SetButtonSize()
        {
            foreach (TabPage tab in Tab_settings.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    if (ctrl is RadButton btn)
                    {
                        btn.Width = tab.Width - 15;
                    }
                }
            }
        }

        public void SetTabPanelStyle()
        {

            Tab_settings.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

        }



        //--------------- import forms and classes ----
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();



        //------------- usermanagement button events ----------------
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            addUser add = new addUser();
            add.ShowDialog();
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            EditUser edit = new EditUser();
            edit.BtnVisible = true;
            edit.ShowDialog();
        }

        private void btn_userInfo_Click(object sender, EventArgs e)
        {
            ViewUserDetails details = new ViewUserDetails();
            details.ShowDialog();
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            RemoveUser remove = new RemoveUser();
            remove.ShowDialog();
        }

        private void btn_RoleManage_Click(object sender, EventArgs e)
        {

        }



        private void MainSettings_SizeChanged(object sender, EventArgs e)
        {
            SetButtonSize();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            SetButtonSize();
        }

        private void MainSettings_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
