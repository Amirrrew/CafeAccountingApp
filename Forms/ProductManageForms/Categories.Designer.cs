namespace CafeApplication.Forms.ProductManageForms
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titele = new System.Windows.Forms.Label();
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.ProductsTableAdapter();
            this.tbl_Category = new System.Windows.Forms.DataGridView();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKCategoriesParentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKProductsCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_delete_coustomer = new Telerik.WinControls.UI.RadButton();
            this.btn_addCustomer = new Telerik.WinControls.UI.RadButton();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCategoriesParentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_coustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titele
            // 
            this.lbl_titele.AutoSize = true;
            this.lbl_titele.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_titele.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titele.Location = new System.Drawing.Point(245, 9);
            this.lbl_titele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titele.Name = "lbl_titele";
            this.lbl_titele.Size = new System.Drawing.Size(222, 41);
            this.lbl_titele.TabIndex = 28;
            this.lbl_titele.Text = "دسته بندی کالا ها";
            this.lbl_titele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dsCafe;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafeTablesTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
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
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Category
            // 
            this.tbl_Category.AllowUserToAddRows = false;
            this.tbl_Category.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.tbl_Category.AutoGenerateColumns = false;
            this.tbl_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_Category.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.tbl_Category.ColumnHeadersHeight = 40;
            this.tbl_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isActiveDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.tbl_Category.DataSource = this.categoriesBindingSource1;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_Category.DefaultCellStyle = dataGridViewCellStyle26;
            this.tbl_Category.EnableHeadersVisualStyles = false;
            this.tbl_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_Category.Location = new System.Drawing.Point(12, 53);
            this.tbl_Category.MultiSelect = false;
            this.tbl_Category.Name = "tbl_Category";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Category.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.tbl_Category.RowHeadersWidth = 5;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Category.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.tbl_Category.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tbl_Category.RowTemplate.Height = 35;
            this.tbl_Category.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Category.Size = new System.Drawing.Size(436, 545);
            this.tbl_Category.TabIndex = 29;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.dsCafe;
            // 
            // fKCategoriesParentBindingSource
            // 
            this.fKCategoriesParentBindingSource.DataMember = "FK_Categories_Parent";
            this.fKCategoriesParentBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // fKProductsCategoryBindingSource
            // 
            this.fKProductsCategoryBindingSource.DataMember = "FK_Products_Category";
            this.fKProductsCategoryBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // btn_delete_coustomer
            // 
            this.btn_delete_coustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_coustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_delete_coustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delete_coustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_coustomer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_delete_coustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_delete_coustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_coustomer.Image")));
            this.btn_delete_coustomer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete_coustomer.Location = new System.Drawing.Point(10, 9);
            this.btn_delete_coustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_coustomer.Name = "btn_delete_coustomer";
            this.btn_delete_coustomer.Size = new System.Drawing.Size(41, 37);
            this.btn_delete_coustomer.TabIndex = 31;
            this.btn_delete_coustomer.Text = "-";
            this.btn_delete_coustomer.Click += new System.EventHandler(this.btn_delete_coustomer_Click);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_addCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCustomer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_addCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCustomer.Image")));
            this.btn_addCustomer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addCustomer.Location = new System.Drawing.Point(55, 9);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(41, 37);
            this.btn_addCustomer.TabIndex = 30;
            this.btn_addCustomer.Text = "-";
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.NullValue = false;
            this.isActiveDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.isActiveDataGridViewCheckBoxColumn.FillWeight = 101.5228F;
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "فعال";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.nameDataGridViewTextBoxColumn.FillWeight = 98.47716F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام دسته بندی";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 530);
            this.Controls.Add(this.btn_delete_coustomer);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.tbl_Category);
            this.Controls.Add(this.lbl_titele);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Categories";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت دسته بندی ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categories_FormClosing);
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCategoriesParentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_coustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Data.DataSet.DsCafe dsCafe;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private Data.DataSet.DsCafeTableAdapters.ProductsTableAdapter productsTableAdapter;
        public System.Windows.Forms.DataGridView tbl_Category;
        private System.Windows.Forms.BindingSource fKProductsCategoryBindingSource;
        private System.Windows.Forms.BindingSource fKCategoriesParentBindingSource;
        public Telerik.WinControls.UI.RadButton btn_delete_coustomer;
        public Telerik.WinControls.UI.RadButton btn_addCustomer;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource categoriesBindingSource;
        public Data.DataSet.DsCafeTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        public System.Windows.Forms.Label lbl_titele;
    }
}