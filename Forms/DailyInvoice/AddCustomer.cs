using CafeApplication.Classes.PublicClasses;
using CafeApplication.Data.DataSet.DsCafeTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Calendar;

namespace CafeApplication.Forms.DailyInvoice
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            


        }

        private void Load_data()
        {
            int i;
            try
            {
                this.customersBindingSource.AddNew();
                i = this.customersTableAdapter.Max_Id().GetValueOrDefault();
                i = i + 1;
                txt_CustomerID.Text = (customersTableAdapter.Max_Id().GetValueOrDefault() + 1).ToString();
            }
            catch
            {

            }
            txt_CustomerName.Focus();
            txt_Date.Text = get_date.generateFullDate();
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            Load_data();
        }


        //--------------------- import classes ---------------
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        //---
        CafeApplication.Forms.PublicForms.CustomMessage  customMessage = new PublicForms.CustomMessage();
        GetTime get_date = new GetTime();
        //--------------------- import classes ---------------

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);
        }

        private void txt_CustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Int32 i;
            try
            {
                if (txt_CustomerID.Text != string.Empty && txt_CustomerName.Text != string.Empty && txt_CustomerPhone.Text != string.Empty)
                {
                    this.customersBindingSource.EndEdit();
                    i = this.customersTableAdapter.Update(this.dsCafe.Customers);
                    if (i > 0)
                    {
                        //MessageBox.Show("کاربر گرامی اطلاعات با موفقیت ذخیره شد");
                        customMessage.NewMessage("Success", "کاربر گرامی اطلاعات با موفقیت ذخیره شد", "Y", "success", null);
                        txt_CustomerName.Text = string.Empty;
                        txt_CustomerPhone.Text = string.Empty;
                        txt_CustomerAddress.Text = string.Empty;
                        Load_data();
                    }
                    //------------
                    else
                    {
                        customMessage.NewMessage("Error", "متاسفانه ما نتوانستیم اطلاعات را  با موفقیت ذخیره کنیم", "Y", "error", null);
                    }
                }
                else
                {
                    customMessage.NewMessage("warning", "نام و نام خوانوادگی و شماره تلفن باید نوشته شود!", "Y", "error", null);
                }
                
            }
            catch
            {
                customMessage.NewMessage("Error", "در ذخیره سازی اطلاعات مشکلی پیش آمده\n دوباره تلاش کنید و در صورت لزوم با پشتیبانی تماس بگیرید", "Y", "error", null);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                //---------------------
                this.customersBindingSource.CancelEdit();
                this.dsCafe.Customers.RejectChanges();
                txt_CustomerName.Text = string.Empty;
                txt_CustomerPhone.Text = string.Empty;
                txt_CustomerAddress.Text = string.Empty;
            }
            catch 
            {
                customMessage.NewMessage("Error", "متاسفانه ما نتوانستیم اطلاعات را  با موفقیت ذخیره کنیم", "Y", "error", null);
            }
        }


    }
}
