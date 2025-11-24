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

namespace CafeApplication.Forms.ProductManageForms
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dsCafe.Products);
            // TODO: This line of code loads data into the 'dsCafe.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dsCafe.Categories);

        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AddCategory add = new AddCategory();
            add.ShowDialog();
        }
    }
}
