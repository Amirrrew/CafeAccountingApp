using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Forms.PublicForms
{
    public partial class CustomMessage : Form
    {
        public CustomMessage()
        {
            InitializeComponent();
            SetBlurBack();
        }


        //----------------- blur ------------
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


        public void SetMessageText(string title ,string text ,string buttons , string icon)
        {
            lblTitle.Text = title;
            lbltext.Text = text;
            switch (buttons)
            {
                case "Y":
                    OnlyOkay(); break;
                case "YN":
                    YesNo(); break;
                case "YNC":
                    YesNoCancel(); break;
                case "YC":
                    YesCancel(); break;
                default:
                    BtnOK.Visible = false;
                    btnCancel.Visible = false;
                    btnNo.Visible = false;
                    break;

            }

            //switch (icon)
            //{
            //    case "error":
            //        iconBox.Load(Application.StartupPath + @"Assets/Icons/MsgIcons/fatalerror-Icon.png");
            //        break;
            //    case "warning":
            //        iconBox.Load(Application.StartupPath + @"Assets/Icons/MsgIcons/error-Icon.png");
            //        break;
            //}

        }


        public void OnlyOkay()
        {
            BtnOK.Visible = true;
            btnCancel.Visible = false;
            btnNo.Visible = false;
        }

        public void YesNo()
        {
            BtnOK.Visible = true;
            btnCancel.Visible = false;
            btnNo.Visible = true;
        }

        public void YesNoCancel()
        {
            BtnOK.Visible = true;
            btnCancel.Visible = true;
            btnNo.Visible = true;
        }

        public void YesCancel()
        {
            BtnOK.Visible = true;
            btnCancel.Visible = true;
            btnNo.Visible = false;
        }
    }
}
