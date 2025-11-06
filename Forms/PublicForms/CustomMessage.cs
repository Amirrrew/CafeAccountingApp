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
using System.Windows.Interop;
using Telerik.WinControls.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CafeApplication.Forms.PublicForms
{
    public partial class CustomMessage : Form
    {
        public CustomMessage()
        {
            InitializeComponent();
            blur.SetBlurBack(this);//sets a blurry background
            fontSet.SetFont(this);// set message default font
            this.Size = new Size(384, 229);
            lbltext.Size = new Size(345, 78);
        }

        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();

        public void NewMessage(string title ,string text ,string buttons , string icon ,string size ,Action YesClick = null ,Action NoClick = null ,Action CancelClick = null)
        {
            lblTitle.Text = title;
            this.Text = title;
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
                    YesCancel(); btnCancel.Left = 120; break;
                default:
                    BtnOK.Visible = true;
                    btnCancel.Visible = false;
                    btnNo.Visible = false;
                    break;

            }

            switch (size)
            {
                case "big":
                    this.Size = new Size(384, 493); lbltext.Size = new Size(345, 342); break;
                case "med":
                    this.Size = new Size(384, 311); lbltext.Size = new Size(345, 156); break;
                default:
                    this.Size = new Size(384, 229);
                    lbltext.Size = new Size(345, 78);
                    break;

            }


            BtnOK.Click += (s, e) => { YesClick?.Invoke(); this.Close(); }; //set yes button click event
            btnNo.Click += (s, e) => { NoClick?.Invoke(); this.Close(); }; //set no button click event
            btnCancel.Click += (s, e) => { CancelClick?.Invoke(); this.Close(); }; //set cancel button click event


            //---- icon paths ---------
            switch (icon)
            {
                case "error":
                    iconBox.Load(Application.StartupPath + @"/Assets/Icons/MsgIcons/fatalerror-Icon.png");
                    break;
                case "warning":
                    iconBox.Load(Application.StartupPath + @"/Assets/Icons/MsgIcons/error-Icon.png");
                    break;
                case "info":
                    iconBox.Load(Application.StartupPath + @"/Assets/Icons/MsgIcons/info-Icon.png");
                    break;
                case "success":
                    iconBox.Load(Application.StartupPath + @"/Assets/Icons/MsgIcons/success-Icon.png");
                    break;
                default:
                    iconBox.Load(Application.StartupPath + @"/Assets/Icons/MsgIcons/message-Icon.png");
                    break;
            }

            this.ShowDialog();

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
