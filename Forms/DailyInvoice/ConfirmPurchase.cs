using CafeApplication.Classes.PublicClasses;
using Calendar;
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
            PrepareForInvoice();
        }

        //-------------- import classes ----------------- 
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        NumberSeperate seperate = new NumberSeperate();
        GetTime gt = new GetTime();

        public void PrepareForInvoice()
        {
            lbl_InvoiceTime.Text = gt.GetTimeWithoutSeconds();
            txt_InvoiceDate.Text = ($"{gt.GetYear()}{gt.GetMonth()}{gt.GetDay()}");
        }

        public void SetPrices()
        {
            //txt_TotalPrice =
        }

        private void ConfirmPurchase_Load(object sender, EventArgs e)
        {

        }

        private void txt_totalInvoice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Timer_CheckTime_Tick(object sender, EventArgs e)
        {
            lbl_InvoiceTime.Text = gt.GetTimeWithoutSeconds();
        }
    }
}
