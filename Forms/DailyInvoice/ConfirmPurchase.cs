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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        Int64 txt_TotalPrice_value, txt_finalPrice_value;//مقدار تکست باکس رو نگه میداره که توی سیو دیتا و  فرمت ها به مشکل نخوریم
        string txt_Discount_value, txt_Discount_format;
        Number_decimal_format decimal_Format = new Number_decimal_format();

        //------------------------------------------------

        public void PrepareForInvoice()
        {
            lbl_InvoiceTime.Text = gt.GetTimeWithoutSeconds();
            txt_InvoiceDate.Text = gt.generateFullDate();
        }

        public void SetFinalPrice()
        {
            txt_TotalPrice.Text = invoice.lbl_total.Text;
            txt_finalPrice.Text = (int.Parse(txt_TotalPrice.Text) - int.Parse(txt_Discount.Text)).ToString();
        }
        private void load_class()
        {
            string total, finalPrice;
            //----
            txt_TotalPrice_value = int.Parse(txt_TotalPrice.Text);
            total = decimal_Format.decimal_format(txt_TotalPrice.Text);
            txt_TotalPrice.Text = total;
            //------------------------
            //txt_finalPrice_value = int.Parse(txt_finalPrice.Text);
            //finalPrice = decimal_Format.decimal_format(txt_finalPrice.Text);
            //txt_finalPrice.Text = finalPrice;
        }
        private void ConfirmPurchase_Load(object sender, EventArgs e)
        {
            load_class();
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
            try
            {
                if (txt_Discount.Text != string.Empty)
                {
                    txt_Discount_value = txt_Discount.Text;
                    txt_Discount_format = decimal_Format.decimal_format(txt_Discount_value);
                    
                    Int64 num = (txt_TotalPrice_value - Int64.Parse(txt_Discount.Text));
                    if (num >= 0)
                    {
                        txt_finalPrice_value = num;
                        string finalPrice = decimal_Format.decimal_format(num.ToString());
                        txt_finalPrice.Text = finalPrice;
                        //-----------------
                    }
                    else
                    {
                        txt_Discount.Text = "0";
                        txt_finalPrice.Text = "----------------";
                        msg.NewMessage("خطا", "مبلغ تخفیف نمیتواند بیشتر از قیمت تمام شده باشد.", "Y", "info", null);
                        txt_Discount.Focus();
                    }
                }
            }
            catch
            {
                msg.NewMessage("خطا", "مشکلی پیش آمد \n دوباره تلاش کنید", "Y", "error", null);

            }


        }

        private void txt_TotalPrice_TextChanged(object sender, EventArgs e)
        {
            string a = decimal_Format.decimal_format(txt_TotalPrice.Text);
            txt_TotalPrice.Text = a;
        }

        private void txt_finalPrice_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Discount_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Discount_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_Discount, txt_Discount_format);
        }

        private void txt_Discount_Click(object sender, EventArgs e)
        {
            txt_Discount.SelectAll();
        }
    }
}
