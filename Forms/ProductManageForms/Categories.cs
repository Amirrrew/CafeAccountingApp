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
        CustomMessage msg = new CustomMessage();

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

        private DialogResult msg_Question()
        {
            msg.NewMessage("هشدار", "\nدرصورتی که دسته بندی را حذف کنید کل کالا های مربوطه هم حذف خواهند شد.آیا از حذف اطلاعات انتخاب شده مطمعن هستید ؟", "YN", "warning", "med");
            return msg.DialogResult;
        }

        private void btn_delete_coustomer_Click(object sender, EventArgs e)
        {
            if (tbl_Category.Rows.Count == 0)
            {
                msg.NewMessage("حذف", "برای حدف ابتدا ردیفی انتخاب کنید.", "Y", "info", null);
                return;
            }
            if (msg_Question() == DialogResult.OK)
            {
                categoriesBindingSource.RemoveAt(tbl_Category.CurrentRow.Index);
                categoriesBindingSource.EndEdit();
                categoriesTableAdapter.Update(dsCafe.Categories);
            }
        }

        private void Categories_FormClosing(object sender, FormClosingEventArgs e)
        {
            categoriesTableAdapter.Update(dsCafe.Categories);
        }
    }
}
