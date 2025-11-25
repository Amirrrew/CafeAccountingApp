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

namespace CafeApplication.Forms.ProductManageForms
{
    public partial class AddCategory : Form
    {
        public AddCategory()
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

        private void AddCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dsCafe.Categories);
            NewData();
        }

        private void NewData()
        {
            categoriesBindingSource.AddNew();
            txt_CatID.Text = (categoriesTableAdapter.SetMaxID().GetValueOrDefault() + 1).ToString();
            Chk_IsActive.Checked = true;
            txt_CatName.ResetText();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            msg.NewMessage("افزودن دسته بندی", "دسته بندی اضافه نشد.", "Y", "info", null);
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int IsUpdated;
            if (txt_CatID.Text != string.Empty && txt_CatName.Text != string.Empty)
            {
                categoriesBindingSource.EndEdit();
                IsUpdated = categoriesTableAdapter.Update(dsCafe.Categories);
                if (IsUpdated > 0)
                {
                    msg.NewMessage("دسته بندی جدید", "دسته بندی جدید با موفقیت اضاقه شد.", "Y", "success", null);
                    NewData();
                }
                else
                {
                    msg.NewMessage("دسته بندی جدید", "مشکلی در افزودن دسته بندی جدید بوجود آمده.", "Y", "error", null);
                }


            }
            else
            {
                msg.NewMessage("دسته بندی جدید", "ابتدا برای دسته بندی جدید یک نام انتخاب کنید!", "Y", "warning", null);
            }
        }

        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Categories ct = new Categories();
            ct.categoriesTableAdapter.Fill(dsCafe.Categories);
        }
    }
}
