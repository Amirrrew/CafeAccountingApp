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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> parent of 9e77c26 (manageCustomers)
            this.lbl_dailyInvoice = new System.Windows.Forms.Label();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.tbl_customers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.tbl_Customers = new System.Windows.Forms.DataGridView();
>>>>>>> parent of 9e77c26 (manageCustomers)
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.btn_EndSearch = new Telerik.WinControls.UI.RadButton();
            this.lbl_SearchResult = new System.Windows.Forms.Label();
            this.lbl_ResultTitle = new System.Windows.Forms.Label();
            this.Cmb_SearchFrame = new System.Windows.Forms.ComboBox();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customers)).BeginInit();
=======
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Customers)).BeginInit();
>>>>>>> parent of 9e77c26 (manageCustomers)
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EndSearch)).BeginInit();
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
<<<<<<< HEAD
            // tbl_customers
            // 
            this.tbl_customers.AllowUserToAddRows = false;
            this.tbl_customers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tbl_customers.AutoGenerateColumns = false;
            this.tbl_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_customers.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tbl_customers.ColumnHeadersHeight = 40;
            this.tbl_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
=======
            // tbl_Customers
            // 
            this.tbl_Customers.AllowUserToAddRows = false;
            this.tbl_Customers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_Customers.AutoGenerateColumns = false;
            this.tbl_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_Customers.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_Customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_Customers.ColumnHeadersHeight = 40;
            this.tbl_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
>>>>>>> parent of 9e77c26 (manageCustomers)
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
<<<<<<< HEAD
            this.tbl_customers.DataSource = this.customersBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_customers.DefaultCellStyle = dataGridViewCellStyle12;
            this.tbl_customers.EnableHeadersVisualStyles = false;
            this.tbl_customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_customers.Location = new System.Drawing.Point(12, 133);
            this.tbl_customers.MultiSelect = false;
            this.tbl_customers.Name = "tbl_customers";
            this.tbl_customers.ReadOnly = true;
            this.tbl_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tbl_customers.RowHeadersWidth = 5;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_customers.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.tbl_customers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tbl_customers.RowTemplate.Height = 35;
            this.tbl_customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_customers.Size = new System.Drawing.Size(845, 305);
            this.tbl_customers.TabIndex = 21;
            this.tbl_customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_Customers_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره تلفن";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "آدرس";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ ثبت";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
=======
            this.tbl_Customers.DataSource = this.customersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_Customers.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbl_Customers.EnableHeadersVisualStyles = false;
            this.tbl_Customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_Customers.Location = new System.Drawing.Point(12, 147);
            this.tbl_Customers.MultiSelect = false;
            this.tbl_Customers.Name = "tbl_Customers";
            this.tbl_Customers.ReadOnly = true;
            this.tbl_Customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbl_Customers.RowHeadersWidth = 5;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Customers.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tbl_Customers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tbl_Customers.RowTemplate.Height = 35;
            this.tbl_Customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Customers.Size = new System.Drawing.Size(845, 305);
            this.tbl_Customers.TabIndex = 21;
            this.tbl_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_Customers_CellClick);
>>>>>>> parent of 9e77c26 (manageCustomers)
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
            this.btn_EndSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btn_EndSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EndSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EndSearch.Font = new System.Drawing.Font("Rokh Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_EndSearch.ForeColor = System.Drawing.Color.White;
            this.btn_EndSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_EndSearch.Image")));
<<<<<<< HEAD
            this.btn_EndSearch.Location = new System.Drawing.Point(8, 445);
=======
            this.btn_EndSearch.Location = new System.Drawing.Point(8, 459);
>>>>>>> parent of 9e77c26 (manageCustomers)
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
<<<<<<< HEAD
            this.lbl_SearchResult.Location = new System.Drawing.Point(490, 450);
=======
            this.lbl_SearchResult.Location = new System.Drawing.Point(490, 473);
>>>>>>> parent of 9e77c26 (manageCustomers)
            this.lbl_SearchResult.Name = "lbl_SearchResult";
            this.lbl_SearchResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SearchResult.Size = new System.Drawing.Size(236, 29);
            this.lbl_SearchResult.TabIndex = 23;
            // 
            // lbl_ResultTitle
            // 
            this.lbl_ResultTitle.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ResultTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.lbl_ResultTitle.Location = new System.Drawing.Point(731, 451);
=======
            this.lbl_ResultTitle.Location = new System.Drawing.Point(731, 472);
>>>>>>> parent of 9e77c26 (manageCustomers)
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
            //<<<<<<< HEAD
            this.Cmb_SearchFrame.BackColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.Cmb_SearchFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SearchFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_SearchFrame.Font = new System.Drawing.Font("Rokh Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
=======
            this.Cmb_SearchFrame.Font = new System.Drawing.Font("RokhFaNum Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
>>>>>>> parent of 9e77c26 (manageCustomers)
            this.Cmb_SearchFrame.ForeColor = System.Drawing.Color.White;
            this.Cmb_SearchFrame.FormattingEnabled = true;
            this.Cmb_SearchFrame.Items.AddRange(new object[] {
            "کد",
            "نام و نام خانوادگی",
            "شماره تلفن",
            "آدرس"});
<<<<<<< HEAD
            this.Cmb_SearchFrame.Location = new System.Drawing.Point(202, 89);
            this.Cmb_SearchFrame.AutoSize = false;
            this.Cmb_SearchFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            //this.Cmb_SearchFrame.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // Cmb_SearchFrame.NestedRadGridView
            // 
<<<<<<< HEAD
            //this.Cmb_SearchFrame.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            //this.Cmb_SearchFrame.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Cmb_SearchFrame.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            //this.Cmb_SearchFrame.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.AllowAddNewRow = false;
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.AllowColumnChooser = false;
            //gridViewTextBoxColumn1.HeaderText = "کد";
            //gridViewTextBoxColumn1.Name = "کد";
            //gridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            //gridViewTextBoxColumn2.Name = "نام و نام خانوادگی";
            //gridViewTextBoxColumn3.HeaderText = "آدرس";
            //gridViewTextBoxColumn3.Name = "آدرس";
            //gridViewTextBoxColumn4.HeaderText = "شماره تلفن";
            //gridViewTextBoxColumn4.Name = "شماره تلفن";
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            //gridViewTextBoxColumn1,
            //gridViewTextBoxColumn2,
            //gridViewTextBoxColumn3,
            //gridViewTextBoxColumn4});
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.EnableGrouping = false;
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.ShowFilteringRow = false;
            //this.Cmb_SearchFrame.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            //this.Cmb_SearchFrame.EditorControl.Name = "NestedRadGridView";
            //this.Cmb_SearchFrame.EditorControl.ReadOnly = true;
            //this.Cmb_SearchFrame.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Cmb_SearchFrame.EditorControl.ShowGroupPanel = false;
            //this.Cmb_SearchFrame.EditorControl.Size = new System.Drawing.Size(240, 150);
            //this.Cmb_SearchFrame.EditorControl.TabIndex = 0;
=======
            this.Cmb_SearchFrame.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.Cmb_SearchFrame.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_SearchFrame.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cmb_SearchFrame.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.AllowColumnChooser = false;
            gridViewTextBoxColumn1.HeaderText = "کد";
            gridViewTextBoxColumn1.Name = "کد";
            gridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            gridViewTextBoxColumn2.Name = "نام و نام خانوادگی";
            gridViewTextBoxColumn3.HeaderText = "آدرس";
            gridViewTextBoxColumn3.Name = "آدرس";
            gridViewTextBoxColumn4.HeaderText = "شماره تلفن";
            gridViewTextBoxColumn4.Name = "شماره تلفن";
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.EnableGrouping = false;
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.Cmb_SearchFrame.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Cmb_SearchFrame.EditorControl.Name = "NestedRadGridView";
            this.Cmb_SearchFrame.EditorControl.ReadOnly = true;
            this.Cmb_SearchFrame.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_SearchFrame.EditorControl.ShowGroupPanel = false;
            this.Cmb_SearchFrame.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.Cmb_SearchFrame.EditorControl.TabIndex = 0;
>>>>>>> parent of f9b7fe3 (new)
            this.Cmb_SearchFrame.Font = new System.Drawing.Font("RokhFaNum Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_SearchFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cmb_SearchFrame.Location = new System.Drawing.Point(203, 93);
            this.Cmb_SearchFrame.Name = "Cmb_SearchFrame";
            this.Cmb_SearchFrame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_SearchFrame.Size = new System.Drawing.Size(189, 35);
            this.Cmb_SearchFrame.TabIndex = 33;
=======
            this.Cmb_SearchFrame.Location = new System.Drawing.Point(212, 92);
            this.Cmb_SearchFrame.Name = "Cmb_SearchFrame";
            this.Cmb_SearchFrame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_SearchFrame.Size = new System.Drawing.Size(179, 35);
            this.Cmb_SearchFrame.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره تلفن";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "آدرس";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 270;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ ثبت";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
>>>>>>> parent of 9e77c26 (manageCustomers)
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(865, 496);
=======
            this.ClientSize = new System.Drawing.Size(865, 512);
>>>>>>> parent of 9e77c26 (manageCustomers)
            this.Controls.Add(this.Cmb_SearchFrame);
            this.Controls.Add(this.lbl_ResultTitle);
            this.Controls.Add(this.lbl_SearchResult);
            this.Controls.Add(this.btn_EndSearch);
<<<<<<< HEAD
            this.Controls.Add(this.tbl_customers);
=======
            this.Controls.Add(this.tbl_Customers);
>>>>>>> parent of 9e77c26 (manageCustomers)
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
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customers)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Customers)).EndInit();
>>>>>>> parent of 9e77c26 (manageCustomers)
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EndSearch)).EndInit();
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
<<<<<<< HEAD
        public System.Windows.Forms.DataGridView tbl_customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
=======
        public System.Windows.Forms.DataGridView tbl_Customers;
>>>>>>> parent of 9e77c26 (manageCustomers)
        public Telerik.WinControls.UI.RadButton btn_EndSearch;
        private System.Windows.Forms.Label lbl_ResultTitle;
        public System.Windows.Forms.Label lbl_SearchResult;
        public System.Windows.Forms.ComboBox Cmb_SearchFrame;
<<<<<<< HEAD
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
>>>>>>> parent of 9e77c26 (manageCustomers)
    }
}