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
            SetBlurBack();
            SetPanelBackColor();
            SetCurrentTime();
            SetFont();
        }

        //--------------- importing classes and needed files ----------------- 
        GetTime gt = new GetTime();

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




        //panel design
        //-------------------------- blur panel code ---------------------------

        public struct AccentPolicy
        {
            public int AccentState;
            public int AccentFlags;
            public int GradiantColor;
            public int AnimationID;
        }

        [StructLayout(LayoutKind.Sequential)]


        public struct WindowCompositionAttributeData
        {
            public int Attribute;
            public IntPtr Data;
            public int SizeofData;
        }

        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public void SetBlurBack()
        {
            this.BackColor = Color.Black;
            this.Load += (s, e) => EnableBlur();
        }

        public void EnableBlur()
        {
            var accent = new AccentPolicy();
            accent.AccentState = 3;
            accent.GradiantColor = (180 << 24) | (0x00 << 16) | (0x00 << 8) | 0x00;
            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            var data = new WindowCompositionAttributeData();
            data.Attribute = 19;
            data.SizeofData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(this.Handle, ref data);
            Marshal.FreeHGlobal(accentPtr);
        }

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

