using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
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
        CustomMessage msg = new CustomMessage();
        GetTime gt = new GetTime();
        CafeApplication.Forms.DailyFactor.DailyInvoice invoice = new CafeApplication.Forms.DailyFactor.DailyInvoice();

        public void PrepareForInvoice()
        {
            lbl_InvoiceTime.Text = gt.GetTimeWithoutSeconds();
            txt_InvoiceDate.Text = ($"{gt.GetYear()}{gt.GetMonth()}{gt.GetDay()}");
            SetFinalPrice();
        }

        public void SetFinalPrice()
        {
            txt_TotalPrice.Text = invoice.lbl_total.Text;
            txt_finalPrice.Text = (int.Parse(txt_TotalPrice.Text) - int.Parse(txt_Discount.Text)).ToString();
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

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Discount.Text != string.Empty)
            {
                string num = (Int64.Parse(txt_TotalPrice.Text) - Int64.Parse(txt_Discount.Text)).ToString();
                if (int.Parse(num) > 0)
                {
                    txt_finalPrice.Text = num;

                }
                else
                {
                    txt_Discount.ResetText();
                    txt_finalPrice.Text = "0";
                    msg.NewMessage("خطا", "مبلغ تخفیف نمیتواند بیشتر از قیمت تمام شده باشد.", "Y", "info", null);
                }
            }

        }

        private void txt_Discount_Click(object sender, EventArgs e)
        {
            txt_Discount.SelectAll();
        }
    }
}
