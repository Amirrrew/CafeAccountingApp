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
using System.Windows.Interop;

namespace CafeApplication.Forms.ProductManageForms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        CustomMessage msg = new CustomMessage();

        

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dsCafe.Products);
            msg.BtnOK.DialogResult = DialogResult.Yes;
            msg.btnNo.DialogResult = DialogResult.No;
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
        }

        public void RemovePrd()
        {
            productsBindingSource.RemoveAt(tbl_Products.CurrentRow.Index);
            productsTableAdapter.Update(dsCafe.Products);
            productsBindingSource.EndEdit();
        }

        private void btn_delete_coustomer_Click(object sender, EventArgs e)
        {
            msg.NewMessage("حذف کالا", "آیا از حذف کالای انتخاب شده مطمئن هستید. در صورت حذف بازیابی آن امکان پذیر نخواهد بود.", "YN", "info", "med", YesClick: () => { RemovePrd(); }, NoClick: () => this.Close());
        }
    }
}
