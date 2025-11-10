using CafeApplication.Classes.PublicClasses;
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

namespace CafeApplication.Forms.DailyInvoice
{
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        CustomMessage msg = new CustomMessage();

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

        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (true)
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
    }
}
