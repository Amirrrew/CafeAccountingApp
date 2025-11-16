using CafeApplication.Classes.PublicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Forms.CustomerManageForms
{
    public partial class CustomerManage : Form
    {
        public CustomerManage()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            btn.SetBtnColor(this);
        }

        //----------- importing classes ----------
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        BtnDefaultStyle btn = new BtnDefaultStyle();
    }
}
