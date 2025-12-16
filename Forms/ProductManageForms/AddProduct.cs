using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using Calendar;
using Stimulsoft.Base.Indicator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        //برای تایین وضعیت ذخیره
        bool status;
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
            // TODO: This line of code loads data into the 'dsCafe.Categories' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dsCafe.Products);
            // TODO: This line of code loads data into the 'dsCafe.Products' table. You can move, or remove it, as needed.
            LoadData();

        }

        public void LoadData()
        {
            this.productsTableAdapter.Fill(this.dsCafe.Products);
            lastID = this.productsTableAdapter.ProdMaxID().GetValueOrDefault() + 1;
            productsBindingSource.AddNew();
            txt_ProdID.Text = lastID.ToString();
            lbl_ProdCreated.Text = gt.generateFullDate();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NewProduct();
        }

        public void NewProduct()
        {
            Int32 isUpdated;
            if (status)
            {
                if (txt_ProdID.Text != string.Empty && txt_ProdName.Text != string.Empty)
                {//---------------------------------------------------------
                    int num1 = 0, num2 = 0;
                    //---------------------------------------------------------
                    if (lbl_unit.Text != string.Empty)
                    {
                        num1 = int.Parse(lbl_unit.Text);
                    }
                    //---------------------------------------------------------
                    if (txt_Unit.Text != string.Empty)
                    {
                        num2 = int.Parse(txt_Unit.Text);
                    }
                    //---------------------------------------------------------
                    lbl_unit.Text = (num1 + num2).ToString();
                    //---------------------------------------------------------
                    this.productsBindingSource.EndEdit();
                    isUpdated = this.productsTableAdapter.Update(this.dsCafe.Products);
                    //---------------------------------------------------------
                    if (isUpdated > 0)
                    {
                        msg.NewMessage("به روز رسانی کالا", "کالای مورد نظر با موفقیت به روز رسانی شد.", "Y", "success", null);
                        Cmb_ProdCategory.Enabled = true;
                    }
                    else
                    {
                        msg.NewMessage("به روز رسانی کالا", "مشکلی در به روز رسانی کالای مورد نظر بوجود آمده.", "Y", "error", null);
                    }
                }
            }
            else
            {
                if (txt_ProdID.Text != string.Empty && txt_ProdName.Text != string.Empty)
                {
                    productsBindingSource.EndEdit();
                    isUpdated = productsTableAdapter.Update(dsCafe.Products);
                    if (isUpdated > 0)
                    {
                        msg.NewMessage("افزودن کالا", "کالای جدید با موفقیت افزوده شد.", "Y", "success", null);
                        LoadData();
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
    
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            productsBindingSource.CancelEdit();
            this.Close();
        }

        private void btn_GenerateCode_Click(object sender, EventArgs e)
        {
            GenerateCode gen = new GenerateCode();
            txt_ProdCode.Text = gen.Barcode(txt_ProdCode.Text).ToString();
        }

        private void AddProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NewProduct();
            }
            else if (e.KeyCode == Keys.Escape) {
                productsBindingSource.CancelEdit();
                this.Close();
            }
        }

        private void Cmb_ProdCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            this.categoryIDLabel1.Text = Cmb_ProdCategory.Text.ToString();
        }

       

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ProdName.Text != string.Empty)
                {
                    this.productsTableAdapter.FillBy_prod_name(this.dsCafe.Products, txt_ProdName.Text);
                    if (productsDataGridView.Rows.Count >= 1)
                    {
                        status = true;
                        Cmb_ProdCategory.Enabled = false;
                    }
                    else
                    {
                        status = false;
                        Cmb_ProdCategory.Enabled = true;
                    }
                }
            }
            catch
            {

                throw;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ProdCode.Text != string.Empty)
                {
                    this.productsTableAdapter.FillBy_code_user(this.dsCafe.Products, txt_ProdCode.Text);
                    if (productsDataGridView.Rows.Count >= 1)
                    {
                        status = true;
                        Cmb_ProdCategory.Enabled = false;
                    }
                    else
                    {
                        status = false;
                        Cmb_ProdCategory.Enabled = true;
                    }
                }
            }
            catch
            {

                throw;
            }
        }
    }
}
