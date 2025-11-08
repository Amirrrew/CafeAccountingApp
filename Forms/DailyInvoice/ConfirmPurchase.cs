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

namespace CafeApplication.Forms.DailyInvoice
{
    public partial class ConfirmPurchase : Form
    {
        public ConfirmPurchase()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
        }

        //-------------- import classes ----------------- 
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        NumberSeperate seperate = new NumberSeperate();

        private void ConfirmPurchase_Load(object sender, EventArgs e)
        {

        }

        private void txt_totalInvoice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
