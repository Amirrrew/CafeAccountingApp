namespace CafeApplication.Forms.DailyInvoice
{
    partial class SearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle110 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle111 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle112 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle109 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_dailyInvoice = new System.Windows.Forms.Label();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.btn_EndSearch = new Telerik.WinControls.UI.RadButton();
            this.lbl_SearchResult = new System.Windows.Forms.Label();
            this.lbl_ResultTitle = new System.Windows.Forms.Label();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.Cmb_SearchFrame = new System.Windows.Forms.ComboBox();
            this.tbl_customers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EndSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dailyInvoice
            // 
            this.lbl_dailyInvoice.AutoSize = true;
            this.lbl_dailyInvoice.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_dailyInvoice.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dailyInvoice.Location = new System.Drawing.Point(597, 9);
            this.lbl_dailyInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dailyInvoice.Name = "lbl_dailyInvoice";
            this.lbl_dailyInvoice.Size = new System.Drawing.Size(268, 41);
            this.lbl_dailyInvoice.TabIndex = 14;
            this.lbl_dailyInvoice.Text = "جستجو بین مشتریان";
            this.lbl_dailyInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.BackColor = System.Drawing.Color.Black;
            this.txt_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchBox.Font = new System.Drawing.Font("Rokh Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SearchBox.ForeColor = System.Drawing.Color.White;
            this.txt_SearchBox.Location = new System.Drawing.Point(530, 93);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SearchBox.Size = new System.Drawing.Size(326, 34);
            this.txt_SearchBox.TabIndex = 18;
            this.txt_SearchBox.Text = "مشتری نقدی";
            this.txt_SearchBox.TextChanged += new System.EventHandler(this.txt_SearchBox_TextChanged);
            this.txt_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SearchBox_KeyPress);
            // 
            // lbl_Search
            // 
            this.lbl_Search.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Search.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Search.Image")));
            this.lbl_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Search.Location = new System.Drawing.Point(767, 69);
            this.lbl_Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Search.Size = new System.Drawing.Size(90, 21);
            this.lbl_Search.TabIndex = 20;
            this.lbl_Search.Text = "جستجو";
            this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(384, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "جستجو بر اساس:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsCafe;
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            // btn_EndSearch
            // 
            this.btn_EndSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_EndSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EndSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EndSearch.Font = new System.Drawing.Font("Rokh Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_EndSearch.ForeColor = System.Drawing.Color.White;
            this.btn_EndSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_EndSearch.Image")));
            this.btn_EndSearch.Location = new System.Drawing.Point(12, 478);
            this.btn_EndSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EndSearch.Name = "btn_EndSearch";
            this.btn_EndSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_EndSearch.Size = new System.Drawing.Size(178, 43);
            this.btn_EndSearch.TabIndex = 22;
            this.btn_EndSearch.Text = "اتمام و ادامه";
            this.btn_EndSearch.Click += new System.EventHandler(this.btn_EndSearch_Click);
            // 
            // lbl_SearchResult
            // 
            this.lbl_SearchResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.lbl_SearchResult.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SearchResult.Location = new System.Drawing.Point(489, 486);
            this.lbl_SearchResult.Name = "lbl_SearchResult";
            this.lbl_SearchResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SearchResult.Size = new System.Drawing.Size(236, 29);
            this.lbl_SearchResult.TabIndex = 23;
            // 
            // lbl_ResultTitle
            // 
            this.lbl_ResultTitle.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ResultTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ResultTitle.Location = new System.Drawing.Point(723, 488);
            this.lbl_ResultTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ResultTitle.Name = "lbl_ResultTitle";
            this.lbl_ResultTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_ResultTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ResultTitle.Size = new System.Drawing.Size(123, 29);
            this.lbl_ResultTitle.TabIndex = 24;
            this.lbl_ResultTitle.Text = "مشتری انتخابی:";
            this.lbl_ResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_SearchFrame
            // 
            this.Cmb_SearchFrame.BackColor = System.Drawing.Color.Black;
            this.Cmb_SearchFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SearchFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_SearchFrame.Font = new System.Drawing.Font("RokhFaNum Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_SearchFrame.ForeColor = System.Drawing.Color.White;
            this.Cmb_SearchFrame.FormattingEnabled = true;
            this.Cmb_SearchFrame.Items.AddRange(new object[] {
            "کد",
            "نام و نام خانوادگی",
            "شماره تلفن",
            "آدرس"});
            this.Cmb_SearchFrame.Location = new System.Drawing.Point(200, 91);
            this.Cmb_SearchFrame.Name = "Cmb_SearchFrame";
            this.Cmb_SearchFrame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_SearchFrame.Size = new System.Drawing.Size(191, 35);
            this.Cmb_SearchFrame.TabIndex = 25;
            // 
            // tbl_customers
            // 
            this.tbl_customers.AllowUserToAddRows = false;
            this.tbl_customers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle106.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle106.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle106.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle106.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle106;
            this.tbl_customers.AutoGenerateColumns = false;
            this.tbl_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_customers.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle107.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle107.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle107.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle107.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle107.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle107;
            this.tbl_customers.ColumnHeadersHeight = 40;
            this.tbl_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tbl_customers.DataSource = this.customersBindingSource;
            dataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle110.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle110.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle110.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle110.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle110.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle110.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle110.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_customers.DefaultCellStyle = dataGridViewCellStyle110;
            this.tbl_customers.EnableHeadersVisualStyles = false;
            this.tbl_customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_customers.Location = new System.Drawing.Point(8, 151);
            this.tbl_customers.MultiSelect = false;
            this.tbl_customers.Name = "tbl_customers";
            this.tbl_customers.ReadOnly = true;
            dataGridViewCellStyle111.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle111.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle111.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle111.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle111.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle111.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle111;
            this.tbl_customers.RowHeadersWidth = 5;
            dataGridViewCellStyle112.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle112.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle112.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle112.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle112.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle112.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle112.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_customers.RowsDefaultCellStyle = dataGridViewCellStyle112;
            this.tbl_customers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tbl_customers.RowTemplate.Height = 35;
            this.tbl_customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_customers.Size = new System.Drawing.Size(848, 307);
            this.tbl_customers.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle108;
            this.dataGridViewTextBoxColumn5.HeaderText = "تاریخ ثبت";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "آدرس";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 270;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "شماره تلفن";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            dataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle109;
            this.dataGridViewTextBoxColumn9.HeaderText = "نام و نام خانوادگی";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn10.HeaderText = "کد";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.tbl_customers);
            this.Controls.Add(this.Cmb_SearchFrame);
            this.Controls.Add(this.lbl_ResultTitle);
            this.Controls.Add(this.lbl_SearchResult);
            this.Controls.Add(this.btn_EndSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_SearchBox);
            this.Controls.Add(this.lbl_dailyInvoice);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو بین مشتریان";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EndSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dailyInvoice;
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label label1;
        public Telerik.WinControls.UI.RadButton btn_EndSearch;
        private System.Windows.Forms.Label lbl_ResultTitle;
        public System.Windows.Forms.Label lbl_SearchResult;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        public Telerik.WinControls.RadThemeManager radThemeManager1;
        public System.Windows.Forms.ComboBox Cmb_SearchFrame;
        public System.Windows.Forms.DataGridView tbl_customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}