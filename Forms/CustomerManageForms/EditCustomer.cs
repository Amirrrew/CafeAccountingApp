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
using System.Windows.Interop;

namespace CafeApplication.Forms.CustomerManageForms
{
    public partial class EditCustomer : Form
    {
        public EditCustomer(string id,string name,string phone,string address,string cr_date)
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            txt_CustomerID.Text = id;
            txt_CustomerName.Text = name;
            txt_CustomerPhone.Text = phone;
            txt_CustomerAddress.Text = address;
            txt_Date.Text = cr_date;
            customersTableAdapter.FillBy_customer_id(dsCafe.Customers, int.Parse(id));

        }
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        CafeApplication.Forms.PublicForms.CustomMessage msg = new PublicForms.CustomMessage();
        

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.customersDataGridView.Rows.Count == 0)
                {
                    msg.NewMessage("هشدار", "اطلاعاتی برای ویرایش وجود ندارد", "Y", "warning", null);
                    return;
                }
                //---------
                //---------
                Int32 i;
                /////////////////////////////
                this.customersBindingSource.EndEdit();
                i = this.customersTableAdapter.Update(this.dsCafe.Customers);
                if (i > 0)
                {
                    //msg.NewMessage("هشدار", "اطلاعات با موفقیت به روزرسانی شد", "Y", "success", null);
                    this.DialogResult = DialogResult.Yes;
                }
                //------------
                else
                {
                    //msg.NewMessage("خطا", "در به روزرسانی مشکلی پیش آمد \n دوباره تلاش کنید", "Y", "success", null);
                    this.DialogResult = DialogResult.No;
                }
                this.Close();
                
            }
            catch 
            {
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
