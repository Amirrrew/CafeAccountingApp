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

namespace CafeApplication.Forms.DailyInvoice
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            txt_CustomerID.Text = (customersTableAdapter.SetLastCustomerID().GetValueOrDefault() +1 ).ToString();

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txt_CustomerName.Focus();
        }


        //--------------------- import classes ---------------
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();

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

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }


    }
}
