using CafeApplication.Classes.PublicClasses;
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
            blur.SetBlurBack(this);
        }

        BackBlur blur = new BackBlur();

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
