namespace CafeApplication.Forms.CustomerManageForms
{
    partial class EditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
            this.lbl_CreatedAt = new System.Windows.Forms.Label();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.btn_save = new Telerik.WinControls.UI.RadButton();
            this.lbl_titele = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CustomerAddress = new System.Windows.Forms.TextBox();
            this.txt_CustomerPhone = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.lbl_CustomerID = new System.Windows.Forms.Label();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CreatedAt
            // 
            this.lbl_CreatedAt.AutoSize = true;
            this.lbl_CreatedAt.Location = new System.Drawing.Point(240, 83);
            this.lbl_CreatedAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CreatedAt.Name = "lbl_CreatedAt";
            this.lbl_CreatedAt.Size = new System.Drawing.Size(67, 21);
            this.lbl_CreatedAt.TabIndex = 29;
            this.lbl_CreatedAt.Text = "تاریخ ثبت";
            this.lbl_CreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Date
            // 
            this.txt_Date.BackColor = System.Drawing.Color.Black;
            this.txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CreatedAt", true));
            this.txt_Date.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Date.ForeColor = System.Drawing.Color.White;
            this.txt_Date.Location = new System.Drawing.Point(163, 107);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Date.Size = new System.Drawing.Size(141, 34);
            this.txt_Date.TabIndex = 28;
            this.txt_Date.Text = "----/--/--";
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Location = new System.Drawing.Point(72, 384);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 57);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "-";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Location = new System.Drawing.Point(7, 384);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 57);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "-";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_titele
            // 
            this.lbl_titele.AutoSize = true;
            this.lbl_titele.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_titele.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titele.Location = new System.Drawing.Point(229, 3);
            this.lbl_titele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titele.Name = "lbl_titele";
            this.lbl_titele.Size = new System.Drawing.Size(201, 41);
            this.lbl_titele.TabIndex = 27;
            this.lbl_titele.Text = "ویرایش مشتری";
            this.lbl_titele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "آدرس";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "شماره تلفن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CustomerAddress
            // 
            this.txt_CustomerAddress.BackColor = System.Drawing.Color.Black;
            this.txt_CustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.txt_CustomerAddress.Font = new System.Drawing.Font("Rokh Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CustomerAddress.ForeColor = System.Drawing.Color.White;
            this.txt_CustomerAddress.Location = new System.Drawing.Point(8, 271);
            this.txt_CustomerAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_CustomerAddress.Multiline = true;
            this.txt_CustomerAddress.Name = "txt_CustomerAddress";
            this.txt_CustomerAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CustomerAddress.Size = new System.Drawing.Size(415, 106);
            this.txt_CustomerAddress.TabIndex = 21;
            // 
            // txt_CustomerPhone
            // 
            this.txt_CustomerPhone.BackColor = System.Drawing.Color.Black;
            this.txt_CustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.txt_CustomerPhone.Font = new System.Drawing.Font("RokhFaNum ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CustomerPhone.ForeColor = System.Drawing.Color.White;
            this.txt_CustomerPhone.Location = new System.Drawing.Point(8, 190);
            this.txt_CustomerPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_CustomerPhone.Name = "txt_CustomerPhone";
            this.txt_CustomerPhone.Size = new System.Drawing.Size(151, 34);
            this.txt_CustomerPhone.TabIndex = 20;
            this.txt_CustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BackColor = System.Drawing.Color.Black;
            this.txt_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.txt_CustomerName.Font = new System.Drawing.Font("RokhFaNum ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CustomerName.ForeColor = System.Drawing.Color.White;
            this.txt_CustomerName.Location = new System.Drawing.Point(163, 190);
            this.txt_CustomerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(259, 34);
            this.txt_CustomerName.TabIndex = 19;
            this.txt_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "نام و نام خانوادگی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BackColor = System.Drawing.Color.Black;
            this.txt_CustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.txt_CustomerID.Font = new System.Drawing.Font("RokhFaNum ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CustomerID.ForeColor = System.Drawing.Color.White;
            this.txt_CustomerID.Location = new System.Drawing.Point(309, 107);
            this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.ReadOnly = true;
            this.txt_CustomerID.Size = new System.Drawing.Size(113, 34);
            this.txt_CustomerID.TabIndex = 18;
            this.txt_CustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.Location = new System.Drawing.Point(346, 83);
            this.lbl_CustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(74, 21);
            this.lbl_CustomerID.TabIndex = 17;
            this.lbl_CustomerID.Text = "کد مشتری";
            this.lbl_CustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(506, 107);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.customersDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreatedAt";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.ControlBox = false;
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.lbl_CreatedAt);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_titele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CustomerAddress);
            this.Controls.Add(this.txt_CustomerPhone);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.lbl_CustomerID);
            this.Font = new System.Drawing.Font("Rokh Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditCustomer";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش اطلاعات مشتری";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CreatedAt;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.DataSet.DsCafe dsCafe;
        public Telerik.WinControls.UI.RadButton btn_cancel;
        public Telerik.WinControls.UI.RadButton btn_save;
        private System.Windows.Forms.Label lbl_titele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CustomerID;
        public System.Windows.Forms.TextBox txt_Date;
        public System.Windows.Forms.TextBox txt_CustomerAddress;
        public System.Windows.Forms.TextBox txt_CustomerPhone;
        public System.Windows.Forms.TextBox txt_CustomerName;
        public System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}