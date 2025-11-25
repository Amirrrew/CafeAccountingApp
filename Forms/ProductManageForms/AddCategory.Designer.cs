namespace CafeApplication.Forms.ProductManageForms
{
    partial class AddCategory
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
            System.Windows.Forms.Label lbl_CatName;
            System.Windows.Forms.Label lbl_CatID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.categoriesTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CategoriesTableAdapter();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.btn_save = new Telerik.WinControls.UI.RadButton();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.Chk_IsActive = new System.Windows.Forms.CheckBox();
            this.txt_CatID = new System.Windows.Forms.TextBox();
            this.txt_CatName = new System.Windows.Forms.TextBox();
            this.txt_cateParent = new System.Windows.Forms.TextBox();
            lbl_CatName = new System.Windows.Forms.Label();
            lbl_CatID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CatName
            // 
            lbl_CatName.AutoSize = true;
            lbl_CatName.Location = new System.Drawing.Point(268, 31);
            lbl_CatName.Name = "lbl_CatName";
            lbl_CatName.Size = new System.Drawing.Size(99, 21);
            lbl_CatName.TabIndex = 1;
            lbl_CatName.Text = "نام دسته بندی";
            // 
            // lbl_CatID
            // 
            lbl_CatID.AutoSize = true;
            lbl_CatID.Location = new System.Drawing.Point(12, 9);
            lbl_CatID.Name = "lbl_CatID";
            lbl_CatID.Size = new System.Drawing.Size(98, 21);
            lbl_CatID.TabIndex = 4;
            lbl_CatID.Text = "کد دسته بندی";
            lbl_CatID.Visible = false;
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dsCafe;
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
            this.btn_cancel.Location = new System.Drawing.Point(54, 99);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(44, 44);
            this.btn_cancel.TabIndex = 3;
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
            this.btn_save.Location = new System.Drawing.Point(6, 99);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(44, 44);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "-";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafeTablesTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
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
            // Chk_IsActive
            // 
            this.Chk_IsActive.Checked = true;
            this.Chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_IsActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.categoriesBindingSource, "IsActive", true));
            this.Chk_IsActive.Location = new System.Drawing.Point(204, 101);
            this.Chk_IsActive.Name = "Chk_IsActive";
            this.Chk_IsActive.Size = new System.Drawing.Size(57, 24);
            this.Chk_IsActive.TabIndex = 7;
            this.Chk_IsActive.Text = "active";
            this.Chk_IsActive.UseVisualStyleBackColor = true;
            this.Chk_IsActive.Visible = false;
            // 
            // txt_CatID
            // 
            this.txt_CatID.BackColor = System.Drawing.Color.Black;
            this.txt_CatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryID", true));
            this.txt_CatID.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CatID.ForeColor = System.Drawing.Color.White;
            this.txt_CatID.Location = new System.Drawing.Point(5, 2);
            this.txt_CatID.Name = "txt_CatID";
            this.txt_CatID.ReadOnly = true;
            this.txt_CatID.Size = new System.Drawing.Size(108, 38);
            this.txt_CatID.TabIndex = 9;
            this.txt_CatID.Visible = false;
            // 
            // txt_CatName
            // 
            this.txt_CatName.BackColor = System.Drawing.Color.Black;
            this.txt_CatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CatName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "Name", true));
            this.txt_CatName.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CatName.ForeColor = System.Drawing.Color.White;
            this.txt_CatName.Location = new System.Drawing.Point(6, 55);
            this.txt_CatName.Name = "txt_CatName";
            this.txt_CatName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CatName.Size = new System.Drawing.Size(362, 38);
            this.txt_CatName.TabIndex = 10;
            // 
            // txt_cateParent
            // 
            this.txt_cateParent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "ParentID", true));
            this.txt_cateParent.Location = new System.Drawing.Point(267, 99);
            this.txt_cateParent.Name = "txt_cateParent";
            this.txt_cateParent.Size = new System.Drawing.Size(100, 28);
            this.txt_cateParent.TabIndex = 8;
            this.txt_cateParent.Visible = false;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 149);
            this.Controls.Add(this.txt_CatName);
            this.Controls.Add(this.txt_CatID);
            this.Controls.Add(this.txt_cateParent);
            this.Controls.Add(this.Chk_IsActive);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(lbl_CatID);
            this.Controls.Add(lbl_CatName);
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCategory";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن دسته بندی";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCategory_FormClosed);
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.DataSet.DsCafeTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        public Telerik.WinControls.UI.RadButton btn_cancel;
        public Telerik.WinControls.UI.RadButton btn_save;
        private System.Windows.Forms.CheckBox Chk_IsActive;
        private System.Windows.Forms.TextBox txt_CatID;
        private System.Windows.Forms.TextBox txt_CatName;
        private System.Windows.Forms.TextBox txt_cateParent;
    }
}