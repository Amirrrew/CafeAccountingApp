namespace CafeApplication.Forms.CustomerManageForms
{
    partial class CustomerManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_SearchFrame = new System.Windows.Forms.ComboBox();
            this.btn_edit = new Telerik.WinControls.UI.RadButton();
            this.btn_delete_coustomer = new Telerik.WinControls.UI.RadButton();
            this.btn_addCustomer = new Telerik.WinControls.UI.RadButton();
            this.tbl_customers = new System.Windows.Forms.DataGridView();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.customerIDLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.createdAtLabel1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_coustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsCafe;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.BackColor = System.Drawing.Color.Black;
            this.txt_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchBox.Font = new System.Drawing.Font("RokhFaNum Normal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SearchBox.ForeColor = System.Drawing.Color.White;
            this.txt_SearchBox.Location = new System.Drawing.Point(661, 7);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SearchBox.Size = new System.Drawing.Size(460, 45);
            this.txt_SearchBox.TabIndex = 24;
            this.txt_SearchBox.Text = "جستجو";
            this.txt_SearchBox.WordWrap = false;
            this.txt_SearchBox.Click += new System.EventHandler(this.txt_SearchBox_Click);
            this.txt_SearchBox.TextChanged += new System.EventHandler(this.txt_SearchBox_TextChanged);
            this.txt_SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SearchBox_KeyPress);
            this.txt_SearchBox.Leave += new System.EventHandler(this.txt_SearchBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cmb_SearchFrame);
            this.panel1.Controls.Add(this.txt_SearchBox);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delete_coustomer);
            this.panel1.Controls.Add(this.btn_addCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 61);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(499, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "جستجو بر اساس:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_SearchFrame
            // 
            this.Cmb_SearchFrame.BackColor = System.Drawing.Color.Black;
            this.Cmb_SearchFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SearchFrame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_SearchFrame.Font = new System.Drawing.Font("Rokh Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_SearchFrame.ForeColor = System.Drawing.Color.White;
            this.Cmb_SearchFrame.FormattingEnabled = true;
            this.Cmb_SearchFrame.Items.AddRange(new object[] {
            "کد",
            "نام و نام خانوادگی",
            "شماره تلفن",
            "آدرس"});
            this.Cmb_SearchFrame.Location = new System.Drawing.Point(306, 12);
            this.Cmb_SearchFrame.Name = "Cmb_SearchFrame";
            this.Cmb_SearchFrame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_SearchFrame.Size = new System.Drawing.Size(190, 35);
            this.Cmb_SearchFrame.TabIndex = 29;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Location = new System.Drawing.Point(8, 7);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(53, 48);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "-";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_delete_coustomer.Location = new System.Drawing.Point(65, 7);
            this.btn_delete_coustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_coustomer.Name = "btn_delete_coustomer";
            this.btn_delete_coustomer.Size = new System.Drawing.Size(53, 48);
            this.btn_delete_coustomer.TabIndex = 27;
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
            this.btn_addCustomer.Location = new System.Drawing.Point(122, 7);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(53, 48);
            this.btn_addCustomer.TabIndex = 26;
            this.btn_addCustomer.Text = "-";
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // tbl_customers
            // 
            this.tbl_customers.AllowUserToAddRows = false;
            this.tbl_customers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_customers.AutoGenerateColumns = false;
            this.tbl_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_customers.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tbl_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_customers.ColumnHeadersHeight = 40;
            this.tbl_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.Balance,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.tbl_customers.DataSource = this.customersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_customers.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbl_customers.EnableHeadersVisualStyles = false;
            this.tbl_customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_customers.Location = new System.Drawing.Point(10, 77);
            this.tbl_customers.MultiSelect = false;
            this.tbl_customers.Name = "tbl_customers";
            this.tbl_customers.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tbl_customers.RowHeadersWidth = 5;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_customers.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tbl_customers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tbl_customers.RowTemplate.Height = 35;
            this.tbl_customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_customers.Size = new System.Drawing.Size(1141, 545);
            this.tbl_customers.TabIndex = 23;
            this.tbl_customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_customers_CellClick);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafeTablesTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
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
            // customerIDLabel1
            // 
            this.customerIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDLabel1.Location = new System.Drawing.Point(1354, 121);
            this.customerIDLabel1.Name = "customerIDLabel1";
            this.customerIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.customerIDLabel1.TabIndex = 29;
            this.customerIDLabel1.Text = "label2";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(1354, 158);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 30;
            this.nameLabel1.Text = "label2";
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneLabel1.Location = new System.Drawing.Point(1354, 193);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(100, 23);
            this.phoneLabel1.TabIndex = 31;
            this.phoneLabel1.Text = "label2";
            // 
            // addressLabel1
            // 
            this.addressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressLabel1.Location = new System.Drawing.Point(1354, 230);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(100, 23);
            this.addressLabel1.TabIndex = 32;
            this.addressLabel1.Text = "label2";
            // 
            // createdAtLabel1
            // 
            this.createdAtLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CreatedAt", true));
            this.createdAtLabel1.Location = new System.Drawing.Point(1354, 268);
            this.createdAtLabel1.Name = "createdAtLabel1";
            this.createdAtLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdAtLabel1.TabIndex = 33;
            this.createdAtLabel1.Text = "label2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ ثبت";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "مبلغ بدهکاری";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Balance.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "آدرس";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 330;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره تلفن";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1153, 627);
            this.Controls.Add(this.createdAtLabel1);
            this.Controls.Add(this.addressLabel1);
            this.Controls.Add(this.phoneLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.customerIDLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_customers);
            this.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CustomerManage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منوی مدیریت مشتریان";
            this.Load += new System.EventHandler(this.CustomerManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_coustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox txt_SearchBox;
        public Telerik.WinControls.UI.RadButton btn_edit;
        public Telerik.WinControls.UI.RadButton btn_delete_coustomer;
        public Telerik.WinControls.UI.RadButton btn_addCustomer;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView tbl_customers;
        public System.Windows.Forms.ComboBox Cmb_SearchFrame;
        private System.Windows.Forms.Label label1;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label customerIDLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label phoneLabel1;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.Label createdAtLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}