using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetBlurBack();
            SetFont();
            this.DoubleBuffered = true;
        }

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


        //----------------------------- Main panel opening animation -------------------------- 

        private Timer anim;
        private int targetWidth = 710;
        private int targetHeight = 731;



        private int targetWidthClose = 368;
        private int targetHeightClose = 731;



        private void MainPanelOpen()
        {
            anim = new Timer();
            anim.Interval = 10;
            anim.Tick += AnimatePanel;
            anim.Start();
        }




        private void MainPanelClose()
        {
            anim = new Timer();
            anim.Interval = 10;
            anim.Tick += AnimatePanelClose;
            anim.Start();
        }






        private void AnimatePanel(object sender, EventArgs e)
        {

            int diffW = targetWidth - MainPanel.Width;
            int diffH = targetHeight - MainPanel.Height;

            if (Math.Abs(diffW) < 2 && Math.Abs(diffH) < 2)
            {
                MainPanel.Width = targetWidth;
                MainPanel.Height = targetHeight;
                anim.Stop();
                return;
            }

            int stepW = (int)(diffW * 0.2);
            int stepH = (int)(diffH * 0.2);

            MainPanel.Left -= stepW;
            MainPanel.Width += stepW;

            MainPanel.Height += stepH;
        }






        private void AnimatePanelClose(object sender, EventArgs e)
        {

            int diffW = targetWidthClose - MainPanel.Width;
            int diffH = targetHeightClose - MainPanel.Height;

            if (Math.Abs(diffW) < 2 && Math.Abs(diffH) < 2)
            {
                MainPanel.Width = targetWidthClose;
                MainPanel.Height = targetHeightClose;
                anim.Stop();
                return;
            }

            int stepW = (int)(diffW * 0.2);
            int stepH = (int)(diffH * 0.2);

            MainPanel.Left -= stepW;
            MainPanel.Width += stepW;

            MainPanel.Height += stepH;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (MainPanel.Width < 600) {
                MainPanelOpen();
            } else
            {
                MainPanelClose();
            }
        }


        //----------------------------- Main panel opening animation - END --------------------------// 


        //--------------------------------- MainPanelBorderColor --------------------------

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(20, 219, 219, 219);
            int borderSize = 2; 

            Control c = sender as Control;
            using (Pen p = new Pen(borderColor, borderSize))
            {
                Rectangle rect = new Rectangle(0, 0, c.Width - 1, c.Height - 1);
                e.Graphics.DrawRectangle(p, rect);
            }
        }

        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(20, 219, 219, 219);
            int borderSize = 2;

            Control c = sender as Control;
            using (Pen p = new Pen(borderColor, borderSize))
            {
                Rectangle rect = new Rectangle(0, 0, c.Width - 1, c.Height - 1);
                e.Graphics.DrawRectangle(p, rect);
            }
        }

        //--------------------------------- MainPanelBorderColor - END --------------------------
    }
}

