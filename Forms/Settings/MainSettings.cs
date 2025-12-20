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

        public void SetTabPanelStyle()
        {
            Tab_settings.Appearance = TabAppearance.FlatButtons;
            Tab_settings.ItemSize = new Size(0, 1);
            Tab_settings.SizeMode = TabSizeMode.Fixed;
            Tab_settings.Padding = new Point(0, 0);
            Tab_settings.Multiline = true;
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
    }
}
