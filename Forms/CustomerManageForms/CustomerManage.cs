using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.DailyInvoice;
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
        CafeApplication.Forms.PublicForms.CustomMessage customMessage = new PublicForms.CustomMessage();

        private void CustomerManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsCafe.Customers);

        }

        private void txt_SearchBox_Click(object sender, EventArgs e)
        {
            txt_SearchBox.SelectAll();
        }


        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.ShowDialog();

        }
        private  DialogResult msg_Question()
        {
            //برای این که دیالوگ ریزالت فرم رو بگیریم م ستغیم داخل شرط ایف نمیشد پس براش کلس نوشتیم
            customMessage.NewMessage("هشدار", "آیا از حذف اطلاعات انتخاب شده مطمعن هستید ؟", "YN", "warning", null);
            return customMessage.DialogResult;
        }
        private void btn_delete_coustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbl_customers.Rows.Count == 0)
                {
                    customMessage.NewMessage("هشدار", "اطلاعاتی برای حذف وجود ندارد", "Y", "warning",null);
                    return;
                }
                //---------------

                //---------------

                if (msg_Question() == DialogResult.OK)
                {
                    this.customersBindingSource.RemoveCurrent();
                    this.customersBindingSource.EndEdit();
                    this.customersTableAdapter.Update(this.dsCafe.Customers);
                }
                
            }
            catch 
            {
                customMessage.NewMessage("خطا", "در ذخیره سازی اطلاعات مشکلی پیش آمده\n دوباره تلاش کنید و در صورت لزوم با پشتیبانی تماس بگیرید", "Y", "error", null);
                return;
            }
        }
    }
}
