namespace CafeApplication.Forms.ProductManageForms
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_ProdID;
            System.Windows.Forms.Label lbl_ProdCode;
            System.Windows.Forms.Label lbl_ProdName;
            System.Windows.Forms.Label lbl_ProdCat;
            System.Windows.Forms.Label lbl_ProdPrice;
            System.Windows.Forms.Label lbl_ProdBuy;
            System.Windows.Forms.Label lbl_ProdTax;
            System.Windows.Forms.Label lbl_ProdUnit;
            System.Windows.Forms.Label lbl_title1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.txt_ProdID = new System.Windows.Forms.TextBox();
            this.txt_ProdCode = new System.Windows.Forms.TextBox();
            this.txt_ProdName = new System.Windows.Forms.TextBox();
            this.txt_ProdPrice = new System.Windows.Forms.TextBox();
            this.txt_ProdBuy = new System.Windows.Forms.TextBox();
            this.txt_ProdTax = new System.Windows.Forms.TextBox();
            this.txt_ProdUnit = new System.Windows.Forms.TextBox();
            this.lbl_titele = new System.Windows.Forms.Label();
            this.Cmb_ProdCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ProdCreated = new System.Windows.Forms.Label();
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.btn_save = new Telerik.WinControls.UI.RadButton();
            this.categoriesTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CategoriesTableAdapter();
            lbl_ProdID = new System.Windows.Forms.Label();
            lbl_ProdCode = new System.Windows.Forms.Label();
            lbl_ProdName = new System.Windows.Forms.Label();
            lbl_ProdCat = new System.Windows.Forms.Label();
            lbl_ProdPrice = new System.Windows.Forms.Label();
            lbl_ProdBuy = new System.Windows.Forms.Label();
            lbl_ProdTax = new System.Windows.Forms.Label();
            lbl_ProdUnit = new System.Windows.Forms.Label();
            lbl_title1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProdID
            // 
            lbl_ProdID.AutoSize = true;
            lbl_ProdID.Location = new System.Drawing.Point(517, 104);
            lbl_ProdID.Name = "lbl_ProdID";
            lbl_ProdID.Size = new System.Drawing.Size(47, 21);
            lbl_ProdID.TabIndex = 1;
            lbl_ProdID.Text = "کد کالا";
            // 
            // lbl_ProdCode
            // 
            lbl_ProdCode.AutoSize = true;
            lbl_ProdCode.Location = new System.Drawing.Point(415, 104);
            lbl_ProdCode.Name = "lbl_ProdCode";
            lbl_ProdCode.Size = new System.Drawing.Size(40, 21);
            lbl_ProdCode.TabIndex = 3;
            lbl_ProdCode.Text = "بارکد";
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Location = new System.Drawing.Point(537, 216);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new System.Drawing.Size(28, 21);
            lbl_ProdName.TabIndex = 5;
            lbl_ProdName.Text = "نام";
            // 
            // lbl_ProdCat
            // 
            lbl_ProdCat.AutoSize = true;
            lbl_ProdCat.Location = new System.Drawing.Point(187, 104);
            lbl_ProdCat.Name = "lbl_ProdCat";
            lbl_ProdCat.Size = new System.Drawing.Size(79, 21);
            lbl_ProdCat.TabIndex = 7;
            lbl_ProdCat.Text = "دسته بندی";
            // 
            // lbl_ProdPrice
            // 
            lbl_ProdPrice.AutoSize = true;
            lbl_ProdPrice.Location = new System.Drawing.Point(461, 336);
            lbl_ProdPrice.Name = "lbl_ProdPrice";
            lbl_ProdPrice.Size = new System.Drawing.Size(104, 21);
            lbl_ProdPrice.TabIndex = 9;
            lbl_ProdPrice.Text = "فی / قیمت واحد";
            // 
            // lbl_ProdBuy
            // 
            lbl_ProdBuy.AutoSize = true;
            lbl_ProdBuy.Location = new System.Drawing.Point(264, 336);
            lbl_ProdBuy.Name = "lbl_ProdBuy";
            lbl_ProdBuy.Size = new System.Drawing.Size(78, 21);
            lbl_ProdBuy.TabIndex = 11;
            lbl_ProdBuy.Text = "قیمت خرید";
            // 
            // lbl_ProdTax
            // 
            lbl_ProdTax.AutoSize = true;
            lbl_ProdTax.Location = new System.Drawing.Point(119, 333);
            lbl_ProdTax.Name = "lbl_ProdTax";
            lbl_ProdTax.Size = new System.Drawing.Size(51, 21);
            lbl_ProdTax.TabIndex = 13;
            lbl_ProdTax.Text = "مالیات";
            // 
            // lbl_ProdUnit
            // 
            lbl_ProdUnit.AutoSize = true;
            lbl_ProdUnit.Location = new System.Drawing.Point(35, 216);
            lbl_ProdUnit.Name = "lbl_ProdUnit";
            lbl_ProdUnit.Size = new System.Drawing.Size(90, 21);
            lbl_ProdUnit.TabIndex = 15;
            lbl_ProdUnit.Text = "تعداد / مقدار";
            // 
            // lbl_title1
            // 
            lbl_title1.AutoSize = true;
            lbl_title1.ForeColor = System.Drawing.Color.DimGray;
            lbl_title1.Location = new System.Drawing.Point(358, 74);
            lbl_title1.Name = "lbl_title1";
            lbl_title1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_title1.Size = new System.Drawing.Size(207, 21);
            lbl_title1.TabIndex = 24;
            lbl_title1.Text = "مشخصات اولیه  -------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.DimGray;
            label1.Location = new System.Drawing.Point(356, 188);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(209, 21);
            label1.TabIndex = 25;
            label1.Text = "نام و تعداد ---------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.DimGray;
            label2.Location = new System.Drawing.Point(354, 301);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label2.Size = new System.Drawing.Size(210, 21);
            label2.TabIndex = 26;
            label2.Text = "قیمت و کسورات -------------------------";
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dsCafe;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafeTablesTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.PurchaseItemsTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.SaleItemsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.SetupTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.TrashBinTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // txt_ProdID
            // 
            this.txt_ProdID.BackColor = System.Drawing.Color.Black;
            this.txt_ProdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.txt_ProdID.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdID.ForeColor = System.Drawing.Color.White;
            this.txt_ProdID.Location = new System.Drawing.Point(464, 128);
            this.txt_ProdID.Name = "txt_ProdID";
            this.txt_ProdID.ReadOnly = true;
            this.txt_ProdID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdID.Size = new System.Drawing.Size(100, 38);
            this.txt_ProdID.TabIndex = 2;
            this.txt_ProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ProdCode
            // 
            this.txt_ProdCode.BackColor = System.Drawing.Color.Black;
            this.txt_ProdCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Code", true));
            this.txt_ProdCode.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdCode.ForeColor = System.Drawing.Color.White;
            this.txt_ProdCode.Location = new System.Drawing.Point(275, 128);
            this.txt_ProdCode.Name = "txt_ProdCode";
            this.txt_ProdCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdCode.Size = new System.Drawing.Size(183, 38);
            this.txt_ProdCode.TabIndex = 4;
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.BackColor = System.Drawing.Color.Black;
            this.txt_ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.txt_ProdName.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdName.ForeColor = System.Drawing.Color.White;
            this.txt_ProdName.Location = new System.Drawing.Point(131, 240);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdName.Size = new System.Drawing.Size(434, 38);
            this.txt_ProdName.TabIndex = 0;
            // 
            // txt_ProdPrice
            // 
            this.txt_ProdPrice.BackColor = System.Drawing.Color.Black;
            this.txt_ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.txt_ProdPrice.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdPrice.ForeColor = System.Drawing.Color.White;
            this.txt_ProdPrice.Location = new System.Drawing.Point(349, 357);
            this.txt_ProdPrice.Name = "txt_ProdPrice";
            this.txt_ProdPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdPrice.Size = new System.Drawing.Size(216, 38);
            this.txt_ProdPrice.TabIndex = 1;
            // 
            // txt_ProdBuy
            // 
            this.txt_ProdBuy.BackColor = System.Drawing.Color.Black;
            this.txt_ProdBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdBuy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CostPrice", true));
            this.txt_ProdBuy.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdBuy.ForeColor = System.Drawing.Color.White;
            this.txt_ProdBuy.Location = new System.Drawing.Point(176, 357);
            this.txt_ProdBuy.Name = "txt_ProdBuy";
            this.txt_ProdBuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdBuy.Size = new System.Drawing.Size(167, 38);
            this.txt_ProdBuy.TabIndex = 2;
            // 
            // txt_ProdTax
            // 
            this.txt_ProdTax.BackColor = System.Drawing.Color.Black;
            this.txt_ProdTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdTax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Tax", true));
            this.txt_ProdTax.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdTax.ForeColor = System.Drawing.Color.White;
            this.txt_ProdTax.Location = new System.Drawing.Point(13, 357);
            this.txt_ProdTax.Name = "txt_ProdTax";
            this.txt_ProdTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdTax.Size = new System.Drawing.Size(157, 38);
            this.txt_ProdTax.TabIndex = 3;
            // 
            // txt_ProdUnit
            // 
            this.txt_ProdUnit.BackColor = System.Drawing.Color.Black;
            this.txt_ProdUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Unit", true));
            this.txt_ProdUnit.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProdUnit.ForeColor = System.Drawing.Color.White;
            this.txt_ProdUnit.Location = new System.Drawing.Point(13, 240);
            this.txt_ProdUnit.Name = "txt_ProdUnit";
            this.txt_ProdUnit.ReadOnly = true;
            this.txt_ProdUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProdUnit.Size = new System.Drawing.Size(112, 38);
            this.txt_ProdUnit.TabIndex = 16;
            // 
            // lbl_titele
            // 
            this.lbl_titele.AutoSize = true;
            this.lbl_titele.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_titele.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titele.Location = new System.Drawing.Point(341, 9);
            this.lbl_titele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titele.Name = "lbl_titele";
            this.lbl_titele.Size = new System.Drawing.Size(226, 41);
            this.lbl_titele.TabIndex = 21;
            this.lbl_titele.Text = "افزودن کالای جدید";
            this.lbl_titele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cmb_ProdCategory
            // 
            this.Cmb_ProdCategory.BackColor = System.Drawing.Color.Black;
            this.Cmb_ProdCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CategoryID", true));
            this.Cmb_ProdCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriesBindingSource, "CategoryID", true));
            this.Cmb_ProdCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_ProdCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_ProdCategory.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_ProdCategory.ForeColor = System.Drawing.Color.White;
            this.Cmb_ProdCategory.FormattingEnabled = true;
            this.Cmb_ProdCategory.Location = new System.Drawing.Point(13, 127);
            this.Cmb_ProdCategory.Name = "Cmb_ProdCategory";
            this.Cmb_ProdCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_ProdCategory.Size = new System.Drawing.Size(256, 39);
            this.Cmb_ProdCategory.TabIndex = 5;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dsCafe;
            // 
            // lbl_ProdCreated
            // 
            this.lbl_ProdCreated.AutoSize = true;
            this.lbl_ProdCreated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CreatedAt", true));
            this.lbl_ProdCreated.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ProdCreated.Location = new System.Drawing.Point(312, 74);
            this.lbl_ProdCreated.Name = "lbl_ProdCreated";
            this.lbl_ProdCreated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ProdCreated.Size = new System.Drawing.Size(52, 21);
            this.lbl_ProdCreated.TabIndex = 27;
            this.lbl_ProdCreated.Text = "----/--/--";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Location = new System.Drawing.Point(75, 405);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(57, 55);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "-";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Location = new System.Drawing.Point(13, 405);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 55);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "-";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(578, 473);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_ProdCreated);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(lbl_title1);
            this.Controls.Add(this.Cmb_ProdCategory);
            this.Controls.Add(this.lbl_titele);
            this.Controls.Add(lbl_ProdUnit);
            this.Controls.Add(this.txt_ProdUnit);
            this.Controls.Add(lbl_ProdTax);
            this.Controls.Add(this.txt_ProdTax);
            this.Controls.Add(lbl_ProdBuy);
            this.Controls.Add(this.txt_ProdBuy);
            this.Controls.Add(lbl_ProdPrice);
            this.Controls.Add(this.txt_ProdPrice);
            this.Controls.Add(lbl_ProdCat);
            this.Controls.Add(lbl_ProdName);
            this.Controls.Add(this.txt_ProdName);
            this.Controls.Add(lbl_ProdCode);
            this.Controls.Add(this.txt_ProdCode);
            this.Controls.Add(lbl_ProdID);
            this.Controls.Add(this.txt_ProdID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن کالای جدید";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Data.DataSet.DsCafeTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_ProdID;
        private System.Windows.Forms.TextBox txt_ProdCode;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.TextBox txt_ProdPrice;
        private System.Windows.Forms.TextBox txt_ProdBuy;
        private System.Windows.Forms.TextBox txt_ProdTax;
        private System.Windows.Forms.TextBox txt_ProdUnit;
        private System.Windows.Forms.Label lbl_titele;
        public System.Windows.Forms.ComboBox Cmb_ProdCategory;
        private System.Windows.Forms.Label lbl_ProdCreated;
        public Telerik.WinControls.UI.RadButton btn_cancel;
        public Telerik.WinControls.UI.RadButton btn_save;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.DataSet.DsCafeTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}