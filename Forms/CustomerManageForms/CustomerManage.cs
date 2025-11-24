using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.DailyInvoice;
using CafeApplication.Forms.PublicForms;
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
            Cmb_SearchFrame.SelectedIndex = 0;
            Cmb_SearchFrame.AutoSize = false;
            Cmb_SearchFrame.Height = 45;
        }

        //----------- importing classes ----------
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        BtnDefaultStyle btn = new BtnDefaultStyle();
        CafeApplication.Forms.PublicForms.CustomMessage msg = new PublicForms.CustomMessage();
        string selectedId ,selectedName, selectedPhone, selectedAddress ,selectedDate ,selectedBalance;


        public void SetSelectedDefault()
        {
            selectedId = tbl_customers.Rows[0].Cells[0].Value.ToString();
            selectedName = tbl_customers.Rows[0].Cells[1].Value.ToString();
            selectedPhone = tbl_customers.Rows[0].Cells[2].Value.ToString();
            selectedAddress = tbl_customers.Rows[0].Cells[3].Value.ToString();
            selectedBalance = tbl_customers.Rows[0].Cells[4].Value.ToString();
            selectedDate = tbl_customers.Rows[0].Cells[5].Value.ToString();
        }
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
            msg.NewMessage("هشدار", "آیا از حذف اطلاعات انتخاب شده مطمعن هستید ؟", "YN", "warning", null);
            return msg.DialogResult;
        }

        private void tbl_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = tbl_customers.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedName = tbl_customers.Rows[e.RowIndex].Cells[1].Value.ToString();
                selectedPhone = tbl_customers.Rows[e.RowIndex].Cells[2].Value.ToString();
                selectedAddress = tbl_customers.Rows[e.RowIndex].Cells[3].Value.ToString();
                selectedBalance = tbl_customers.Rows[e.RowIndex].Cells[4].Value.ToString();
                selectedDate = tbl_customers.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void btn_delete_coustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbl_customers.Rows.Count == 0)
                {
                    msg.NewMessage("حذف", "برای حدف ابتدا ردیفی انتخاب کنید.", "Y", "info",null);
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
                msg.NewMessage("خطا", "در ذخیره سازی اطلاعات مشکلی پیش آمده\n دوباره تلاش کنید و در صورت لزوم با پشتیبانی تماس بگیرید", "Y", "error", null);
                return;
            }
        }

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SearchBox.Text != string.Empty)
                {
                    switch (Cmb_SearchFrame.Text)
                    {
                        case "کد":
                            customersTableAdapter.FillBy_customer_id(dsCafe.Customers, int.Parse(txt_SearchBox.Text));
                            break;
                        case "نام و نام خانوادگی":
                            customersTableAdapter.FillBy_customer_name(dsCafe.Customers, "%" + txt_SearchBox.Text + "%");
                            break;
                        case "شماره تلفن":
                            customersTableAdapter.FillBy_customer_phone(dsCafe.Customers, txt_SearchBox.Text + "%");
                            break;
                        case "آدرس":
                            customersTableAdapter.FillBy_customer_address(dsCafe.Customers, "%" + txt_SearchBox.Text + "%");
                            break;
                        default:
                            msg.NewMessage("هشدار", "ابتدا باید یک متد برای جستجو انتخاب کنید.", "Y", "warning", null); break;
                    }
                }
            }
            catch (Exception)
            {
                msg.NewMessage("خطا", "در جستجو مشکلی پیش آمده.\nفرم را ببندید و دوباره تلاش کنید.", "Y", "error", null);
            }

        }

        private void txt_SearchBox_Leave(object sender, EventArgs e)
        {
            customersTableAdapter.Fill(dsCafe.Customers);
        }

        private void txt_SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Cmb_SearchFrame.Text == "شماره تلفن" || Cmb_SearchFrame.Text == "کد")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        //ساخت متغیر های پابلیک برای ارسال به فرم ادیت
        public string Customer_id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_phone { get; set; }
        public string Customer_address { get; set; }
        public string created_at { get; set; }
        //----------------------------------------------

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.tbl_customers.Rows.Count == 0)
            {
                msg.NewMessage("هشدار", "اطلاعاتی برای ویرایش وجود ندارد", "Y", "warning", null);
                return;
            }
            Customer_id = customerIDLabel1.Text;
            Customer_name = nameLabel1.Text;
            Customer_phone = phoneLabel1.Text;
            Customer_address = addressLabel1.Text;
            created_at = createdAtLabel1.Text;

            //---
            using (EditCustomer form_edit = new EditCustomer(Customer_id, Customer_name, Customer_phone, Customer_address, created_at))
            {
                DialogResult d = form_edit.ShowDialog();
                if (d == DialogResult.Yes)
                {
                    this.Refresh();
                    customersTableAdapter.Fill(dsCafe.Customers);
                    msg.NewMessage("ویرایش", "تغیرات با موفقیت اعمال شد", "Y", "success", null);
                }
                else if (d == DialogResult.Cancel)
                {
                    msg.NewMessage("ویرایش", "تغیراتی اعمال نشد", "Y", "success", null);
                }
                else if (d == DialogResult.No)
                {
                    msg.NewMessage("خطا", "اعمال تغیرات با شکست رو به رو  شد\n دوباره تلاش کنید", "Y", "error", null);
                }
            }
            
            
            


        }
    }
}
