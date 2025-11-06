using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CafeApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetPanelBackColor(); //----- sets mainpanel background
            blur.SetBlurBack(this); //-----> sets a blurry background
            fontSet.SetFont(this); //----> sets font of the form
            SetCurrentTime(); //------> sets current time for mainform labels
        }

        //--------------- importing classes and needed files ----------------- 
        GetTime gt = new GetTime();
        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();
        CustomMessage msg = new CustomMessage();

        public void SetPanelBackColor()
        {
            MainPanel.BackColor = Color.FromArgb(30, 0, 0, 1);
            UserPanel.BackColor = Color.FromArgb(30,0,0,1);
        }
        public void ExpandMainPanel()
        {
            if (MainPanel.Width < 700)
            {
                MainPanel.Size = new Size(742, 729);
            } else
            {
                MainPanel.Size = new Size(368, 729);
            }
        }
        



        //---------------------- Timing classes and Events ---------------
        public void SetCurrentTime()
        {
            lblCurrentTime.Text = gt.GetTimeNow();
            lblDate.Text = $"{gt.GetYear()}/{gt.GetMonth()}/{gt.GetDay()}";
            lblDayTitle.Text = gt.GetDayTitle();
        }

        private void TimerTimeUpdate_Tick(object sender, EventArgs e)
        {
            SetCurrentTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExpandMainPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msg.BtnOK.Text = "باشه";
            msg.NewMessage("سلام", "این یک تست برای مسج باکس شده است", "YC", "success" ,"small");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //msg.BtnOK.Text = "بله";
            //msg.NewMessage("خروج؟", "آیا واقعا میخواهید از برنامه خارج شوید؟", "YN", "info", "small", YesClick: () => this.Hide() ,NoClick: ()=> e.Cancel = true);
        }
    }
}

