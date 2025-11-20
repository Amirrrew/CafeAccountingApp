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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            btn.SetBtnColor(this);
        }
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        BtnDefaultStyle btn = new BtnDefaultStyle();
        CafeApplication.Forms.PublicForms.CustomMessage customMessage = new PublicForms.CustomMessage();
    }
}
