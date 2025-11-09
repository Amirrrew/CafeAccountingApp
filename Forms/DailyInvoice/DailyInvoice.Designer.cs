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
            this.Pnl_ActionInner = new System.Windows.Forms.Panel();
            this.btn_ConfirmPurchase = new Telerik.WinControls.UI.RadButton();
            this.btn_addCustomer = new Telerik.WinControls.UI.RadButton();
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.Cmb_customers = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_customer = new System.Windows.Forms.Label();
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.object_5df848ca_f927_4389_812f_3545e39e23ab = new Telerik.WinControls.RootRadElement();
            this.fKSalesCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.SalesTableAdapter();
            this.tooltip_AddCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ExpandPanel = new Telerik.WinControls.UI.RadButton();
            this.Pnl_ActionTitles = new System.Windows.Forms.Panel();
            this.lbl_InAction_AddCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Actions.SuspendLayout();
            this.Pnl_ActionInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ConfirmPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).BeginInit();
            this.Pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExpandPanel)).BeginInit();
            this.Pnl_ActionTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Actions
            // 
            this.Pnl_Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Pnl_Actions.Controls.Add(this.Pnl_ActionTitles);
            this.Pnl_Actions.Controls.Add(this.Pnl_ActionInner);
            this.Pnl_Actions.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Actions.Location = new System.Drawing.Point(1217, 0);
            this.Pnl_Actions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Actions.Name = "Pnl_Actions";
            this.Pnl_Actions.Size = new System.Drawing.Size(76, 772);
            this.Pnl_Actions.TabIndex = 0;
            this.Pnl_Actions.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Actions_Paint);
            // 
            // Pnl_ActionInner
            // 
            this.Pnl_ActionInner.Controls.Add(this.btn_ConfirmPurchase);
            this.Pnl_ActionInner.Controls.Add(this.btn_addCustomer);
            this.Pnl_ActionInner.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_ActionInner.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ActionInner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_ActionInner.Name = "Pnl_ActionInner";
            this.Pnl_ActionInner.Size = new System.Drawing.Size(76, 772);
            this.Pnl_ActionInner.TabIndex = 0;
            this.Pnl_ActionInner.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_ActionInner_Paint);
            // 
            // btn_ConfirmPurchase
            // 
            this.btn_ConfirmPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_ConfirmPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ConfirmPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmPurchase.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_ConfirmPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ConfirmPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConfirmPurchase.Image")));
            this.btn_ConfirmPurchase.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ConfirmPurchase.Location = new System.Drawing.Point(11, 70);
            this.btn_ConfirmPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmPurchase.Name = "btn_ConfirmPurchase";
            this.btn_ConfirmPurchase.Size = new System.Drawing.Size(55, 53);
            this.btn_ConfirmPurchase.TabIndex = 1;
            this.btn_ConfirmPurchase.Text = "-";
            this.btn_ConfirmPurchase.Click += new System.EventHandler(this.btn_ConfirmPurchase_Click);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_addCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCustomer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_addCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addCustomer.Image")));
            this.btn_addCustomer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addCustomer.Location = new System.Drawing.Point(11, 9);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(55, 53);
            this.btn_addCustomer.TabIndex = 0;
            this.btn_addCustomer.Text = "-";
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Pnl_Top.Controls.Add(this.Cmb_customers);
            this.Pnl_Top.Controls.Add(this.lbl_customer);
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(1217, 125);
            this.Pnl_Top.TabIndex = 1;
            this.Pnl_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Cmb_customers
            // 
            this.Cmb_customers.BackColor = System.Drawing.Color.Black;
            this.Cmb_customers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.Cmb_customers.DataSource = this.customersBindingSource1;
            this.Cmb_customers.Font = new System.Drawing.Font("Rokh", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_customers.ForeColor = System.Drawing.Color.White;
            this.Cmb_customers.FormattingEnabled = true;
            this.Cmb_customers.Location = new System.Drawing.Point(975, 33);
            this.Cmb_customers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cmb_customers.Name = "Cmb_customers";
            this.Cmb_customers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_customers.Size = new System.Drawing.Size(236, 35);
            this.Cmb_customers.TabIndex = 7;
            this.Cmb_customers.SelectedIndexChanged += new System.EventHandler(this.Cmb_customers_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dsCafe;
            this.customersBindingSource.CurrentChanged += new System.EventHandler(this.customersBindingSource_CurrentChanged);
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
            this.customersBindingSource1.CurrentChanged += new System.EventHandler(this.customersBindingSource1_CurrentChanged);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_customer.Location = new System.Drawing.Point(1109, 9);
            this.lbl_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(98, 21);
            this.lbl_customer.TabIndex = 6;
            this.lbl_customer.Text = "طرف حساب ها";
            this.lbl_customer.Click += new System.EventHandler(this.lbl_customer_Click);
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
            this.fKSalesCustomerBindingSource.CurrentChanged += new System.EventHandler(this.fKSalesCustomerBindingSource_CurrentChanged);
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tooltip_AddCustomer
            // 
            this.tooltip_AddCustomer.BackColor = System.Drawing.Color.Black;
            this.tooltip_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.tooltip_AddCustomer.Tag = "برای افزودن یک مشتری جدید کلیک کنید";
            this.tooltip_AddCustomer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_AddCustomer.ToolTipTitle = "افزودن مشتری جدید";
            this.tooltip_AddCustomer.Popup += new System.Windows.Forms.PopupEventHandler(this.tooltip_AddCustomer_Popup);
            // 
            // btn_ExpandPanel
            // 
            this.btn_ExpandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExpandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ExpandPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExpandPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExpandPanel.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_ExpandPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ExpandPanel.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExpandPanel.Image")));
            this.btn_ExpandPanel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ExpandPanel.Location = new System.Drawing.Point(1197, 354);
            this.btn_ExpandPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExpandPanel.Name = "btn_ExpandPanel";
            this.btn_ExpandPanel.Size = new System.Drawing.Size(20, 26);
            this.btn_ExpandPanel.TabIndex = 9;
            this.btn_ExpandPanel.Text = "-";
            this.btn_ExpandPanel.Click += new System.EventHandler(this.btn_DailyInvoice_Click);
            // 
            // Pnl_ActionTitles
            // 
            this.Pnl_ActionTitles.Controls.Add(this.label1);
            this.Pnl_ActionTitles.Controls.Add(this.lbl_InAction_AddCustomer);
            this.Pnl_ActionTitles.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_ActionTitles.Location = new System.Drawing.Point(-146, 0);
            this.Pnl_ActionTitles.Name = "Pnl_ActionTitles";
            this.Pnl_ActionTitles.Size = new System.Drawing.Size(146, 772);
            this.Pnl_ActionTitles.TabIndex = 1;
            // 
            // lbl_InAction_AddCustomer
            // 
            this.lbl_InAction_AddCustomer.AutoSize = true;
            this.lbl_InAction_AddCustomer.Location = new System.Drawing.Point(10, 25);
            this.lbl_InAction_AddCustomer.Name = "lbl_InAction_AddCustomer";
            this.lbl_InAction_AddCustomer.Size = new System.Drawing.Size(133, 21);
            this.lbl_InAction_AddCustomer.TabIndex = 10;
            this.lbl_InAction_AddCustomer.Text = "افزودن مشتری جدید";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ثبت نهایی فاکتور";
            // 
            // DailyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1293, 772);
            this.Controls.Add(this.Pnl_Top);
            this.Controls.Add(this.Pnl_Actions);
            this.Controls.Add(this.btn_ExpandPanel);
            this.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "DailyInvoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور فاکتور فروش روزانه";
            this.Load += new System.EventHandler(this.DailyInvoice_Load);
            this.Pnl_Actions.ResumeLayout(false);
            this.Pnl_ActionInner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ConfirmPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).EndInit();
            this.Pnl_Top.ResumeLayout(false);
            this.Pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExpandPanel)).EndInit();
            this.Pnl_ActionTitles.ResumeLayout(false);
            this.Pnl_ActionTitles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Actions;
        private System.Windows.Forms.Panel Pnl_Top;
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
        private System.Windows.Forms.ToolTip tooltip_AddCustomer;
        public Telerik.WinControls.UI.RadButton btn_ExpandPanel;
        private System.Windows.Forms.Panel Pnl_ActionInner;
        public Telerik.WinControls.UI.RadButton btn_ConfirmPurchase;
        private System.Windows.Forms.Panel Pnl_ActionTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_InAction_AddCustomer;
    }
}