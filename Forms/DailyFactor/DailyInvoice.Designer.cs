namespace CafeApplication.Forms.DailyFactor
{
    partial class DailyInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyInvoice));
            this.Pnl_Actions = new System.Windows.Forms.Panel();
            this.btn_addCustomer = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cmb_customers = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_customer = new System.Windows.Forms.Label();
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.object_5df848ca_f927_4389_812f_3545e39e23ab = new Telerik.WinControls.RootRadElement();
            this.fKSalesCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.SalesTableAdapter();
            this.Pnl_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Actions
            // 
            this.Pnl_Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Pnl_Actions.Controls.Add(this.btn_addCustomer);
            this.Pnl_Actions.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Actions.Location = new System.Drawing.Point(1214, 0);
            this.Pnl_Actions.Name = "Pnl_Actions";
            this.Pnl_Actions.Size = new System.Drawing.Size(76, 735);
            this.Pnl_Actions.TabIndex = 0;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_addCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCustomer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_addCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCustomer.Image")));
            this.btn_addCustomer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addCustomer.Location = new System.Drawing.Point(10, 10);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(56, 53);
            this.btn_addCustomer.TabIndex = 9;
            this.btn_addCustomer.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.Cmb_customers);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 119);
            this.panel1.TabIndex = 1;
            // 
            // Cmb_customers
            // 
            this.Cmb_customers.BackColor = System.Drawing.Color.Black;
            this.Cmb_customers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.Cmb_customers.DataSource = this.customersBindingSource1;
            this.Cmb_customers.Font = new System.Drawing.Font("Rokh Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_customers.ForeColor = System.Drawing.Color.White;
            this.Cmb_customers.FormattingEnabled = true;
            this.Cmb_customers.Location = new System.Drawing.Point(893, 33);
            this.Cmb_customers.Name = "Cmb_customers";
            this.Cmb_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_customers.Size = new System.Drawing.Size(302, 35);
            this.Cmb_customers.TabIndex = 7;
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
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.dsCafe;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Rokh Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_customer.Location = new System.Drawing.Point(1092, 9);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(100, 21);
            this.lbl_customer.TabIndex = 6;
            this.lbl_customer.Text = "طرف حساب ها";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // object_5df848ca_f927_4389_812f_3545e39e23ab
            // 
            this.object_5df848ca_f927_4389_812f_3545e39e23ab.Name = "object_5df848ca_f927_4389_812f_3545e39e23ab";
            this.object_5df848ca_f927_4389_812f_3545e39e23ab.StretchHorizontally = true;
            this.object_5df848ca_f927_4389_812f_3545e39e23ab.StretchVertically = true;
            // 
            // fKSalesCustomerBindingSource
            // 
            this.fKSalesCustomerBindingSource.DataMember = "FK_Sales_Customer";
            this.fKSalesCustomerBindingSource.DataSource = this.customersBindingSource;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // DailyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1290, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_Actions);
            this.Font = new System.Drawing.Font("Rokh Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DailyInvoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور فاکتور فروش روزانه";
            this.Load += new System.EventHandler(this.DailyInvoice_Load);
            this.Pnl_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Actions;
        private System.Windows.Forms.Panel panel1;
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label lbl_customer;
        public System.Windows.Forms.ComboBox Cmb_customers;
        private Telerik.WinControls.RootRadElement object_5df848ca_f927_4389_812f_3545e39e23ab;
        private System.Windows.Forms.BindingSource fKSalesCustomerBindingSource;
        private Data.DataSet.DsCafeTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        public Telerik.WinControls.UI.RadButton btn_addCustomer;
    }
}