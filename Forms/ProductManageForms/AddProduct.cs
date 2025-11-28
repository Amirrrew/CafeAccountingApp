using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using Calendar;
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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);

        }

        int lastID;
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        GetTime gt = new GetTime();
        CustomMessage msg = new CustomMessage();

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dsCafe.Categories);
            // TODO: This line of code loads data into the 'dsCafe.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dsCafe.Products);
            lastID = productsTableAdapter.ProdMaxID().GetValueOrDefault() + 1;
            lbl_ProdCreated.Text = gt.generateFullDate();
            productsBindingSource.AddNew();
            txt_ProdID.Text = lastID.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Int32 isUpdated;
            if (txt_ProdID.Text != string.Empty && txt_ProdName.Text != string.Empty)
            {
                productsBindingSource.EndEdit();
                isUpdated = productsTableAdapter.Update(dsCafe.Products);
                if (isUpdated > 0)
                {
                    msg.NewMessage("افزودن کالا", "کالای جدید با موفقیت افزوده شد.", "Y", "success", null);
                }
                else
                {
                    msg.NewMessage("فزودن کالا", "مشکلی در افزودن کالای جدید بوجود آمده.", "Y", "error", null);
                }
            }
            else
            {
                msg.NewMessage("افزودن کالا", "برای افزودن کالا جدید حداقل باید فیلد های کد کالا و نام پر شوند.", "Y", "info", null);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            productsBindingSource.CancelEdit();
            this.Close();
        }
    }
}
