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

namespace CafeApplication.Forms.DailyInvoice
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            customersBindingSource.AddNew();
            txt_CustomerID.Text = (customersTableAdapter.SetLastCustomerID().GetValueOrDefault() + 1).ToString();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }


        //--------------------- import classes ---------------
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        //---
        CafeApplication.Forms.PublicForms.CustomMessage  customMessage = new PublicForms.CustomMessage();
        //--------------------- import classes ---------------

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);
        }

        private void LoadData()
        {
            txt_CustomerName.ResetText();
            txt_CustomerPhone.ResetText();
            txt_CustomerAddress.ResetText();
            customersBindingSource.AddNew();
            txt_CustomerID.Text = (customersTableAdapter.SetLastCustomerID().GetValueOrDefault() +1).ToString();
            txt_CustomerName.Focus();
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
                        int lastID = int.Parse(txt_CustomerID.Text) + 1;
                        //MessageBox.Show("کاربر گرامی اطلاعات با موفقیت ذخیره شد");
                        customMessage.NewMessage("موفقیت", "مشتری جدید با موفقیت ثبت شد.", "Y", "success", null);
                        txt_CustomerID.Text = lastID.ToString();
                        customersBindingSource.AddNew();
                    }
                    //------------
                    else
                    {
                        customMessage.NewMessage("خطا", "متاسفانه ما نتوانستیم اطلاعات را  با موفقیت ذخیره کنیم", "Y", "error", null);
                    }
                }
                else
                {
                    customMessage.NewMessage("فیلد های ضروری", "نام و نام خوانوادگی و شماره تلفن باید نوشته شود!", "Y", "info", null);
                }
                
            }
            catch
            {
                customMessage.NewMessage("خطا", "در ذخیره سازی اطلاعات مشکلی پیش آمده\n دوباره تلاش کنید و در صورت لزوم با پشتیبانی تماس بگیرید", "Y", "error", null);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                //---------------------
                this.customersBindingSource.CancelEdit();
                this.dsCafe.Customers.RejectChanges();
                
            }
            catch 
            {
                customMessage.NewMessage("خطا", "روند ذخیره اطلاعات با خطا موجه شد!", "Y", "warning", null);
            }
        }


    }
}
