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
    }
}
