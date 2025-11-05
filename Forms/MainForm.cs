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
            SetPanelBackColor();
            blur.SetBlurBack(this);
            SetCurrentTime();
            SetFont();

            this.Opacity = 1;          // باید 1 باشه

        }

        //--------------- importing classes and needed files ----------------- 
        GetTime gt = new GetTime();
        BackBlur blur = new BackBlur();

        //-------------------------- set custom fonts -----------------------------
        PrivateFontCollection pf = new PrivateFontCollection();
        public void SetFont()
        {
            pf.AddFontFile(Application.StartupPath + @"/Assets/Fonts/Rokh-Normal.ttf");

            FontFamily ff = pf.Families[0];
            Font rokh = new Font(ff, 12, FontStyle.Regular);

            this.Font = rokh;
        }

        //-------------------------- set custom fonts - END -----------------------------



        //-------------------------- blur panel code - END ---------------------------
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
            CustomMessage msg = new CustomMessage();
            msg.SetMessageText("سلام" ,"این یک تست برای مسج باکس کاستوم شده است" ,"YNC" , "warning");
            msg.ShowDialog();
        }
    }
}

