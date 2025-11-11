using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CafeApplication.Forms.DailyInvoice
{
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            Cmb_SearchFrame.SelectedIndex = 0;
        }

        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        CustomMessage msg = new CustomMessage();
        CafeApplication.Forms.DailyFactor.DailyInvoice dailyInvoice = new CafeApplication.Forms.DailyFactor.DailyInvoice();
        string customerName;

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsCafe.Customers);
            txt_SearchBox.Focus();
        }


        public string SearchForCustomer()
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

                    if (tbl_Customers.RowCount != 0)
                    {
                        customerName = tbl_Customers.Rows[0].Cells[1].Value.ToString();
                    }
                    else
                    {
                        customerName = null;
                    }
                }


                return customerName;
            
            
        }

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_SearchResult.Text = SearchForCustomer();
            }
            catch (Exception)
            {

            }
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

        private void Cmb_SearchFrame_TextChanged(object sender, EventArgs e)
        {
            this.txt_SearchBox.Clear();
            this.txt_SearchBox.Focus();
        }

        private void btn_EndSearch_Click(object sender, EventArgs e)
        {
            dailyInvoice.txt_CustomerName.Text = lbl_SearchResult.Text;
            dailyInvoice.Focus();
            this.Close();
        }

        private void tbl_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbl_SearchResult.Text = tbl_Customers.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch 
            {

               
            }
           
        }
    }
}
