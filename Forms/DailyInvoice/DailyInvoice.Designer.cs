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
            this.Pnl_ActionTitles = new System.Windows.Forms.Panel();
            this.lbl_ConfirmIvoiceTitle = new System.Windows.Forms.Label();
            this.lbl_InAction_AddCustomer = new System.Windows.Forms.Label();
            this.Pnl_ActionInner = new System.Windows.Forms.Panel();
            this.btn_ConfirmPurchase = new Telerik.WinControls.UI.RadButton();
            this.btn_addCustomer = new Telerik.WinControls.UI.RadButton();
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.btn_InstantCustomer = new Telerik.WinControls.UI.RadButton();
            this.btn_SendToPOS = new Telerik.WinControls.UI.RadButton();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_InvoiceDateTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl_dailyInvoice = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.object_5df848ca_f927_4389_812f_3545e39e23ab = new Telerik.WinControls.RootRadElement();
            this.tooltip_Buttons = new System.Windows.Forms.ToolTip(this.components);
            this.Pnl_AllCategories = new System.Windows.Forms.Panel();
            this.Pnl_TotalAmount = new System.Windows.Forms.Panel();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_taxAmount = new System.Windows.Forms.Label();
            this.lbl_ComplictionsAmount = new System.Windows.Forms.Label();
            this.lbl_DiscountAmount = new System.Windows.Forms.Label();
            this.lbl_border1 = new System.Windows.Forms.Label();
            this.lbl_totalAfterTax = new System.Windows.Forms.Label();
            this.lbl_taxTitle = new System.Windows.Forms.Label();
            this.lbl_ComplicationsTitle = new System.Windows.Forms.Label();
            this.lbl_DiscountTitle = new System.Windows.Forms.Label();
            this.lbl_totalTitle = new System.Windows.Forms.Label();
            this.TimerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.customersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.Pnl_Actions.SuspendLayout();
            this.Pnl_ActionTitles.SuspendLayout();
            this.Pnl_ActionInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ConfirmPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).BeginInit();
            this.Pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InstantCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SendToPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            this.Pnl_AllCategories.SuspendLayout();
            this.Pnl_TotalAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Actions
            // 
            this.Pnl_Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Pnl_Actions.Controls.Add(this.Pnl_ActionTitles);
            this.Pnl_Actions.Controls.Add(this.Pnl_ActionInner);
            this.Pnl_Actions.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Actions.Location = new System.Drawing.Point(1272, 0);
            this.Pnl_Actions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Actions.Name = "Pnl_Actions";
            this.Pnl_Actions.Size = new System.Drawing.Size(76, 739);
            this.Pnl_Actions.TabIndex = 0;
            this.Pnl_Actions.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Actions_Paint);
            // 
            // Pnl_ActionTitles
            // 
            this.Pnl_ActionTitles.Controls.Add(this.lbl_ConfirmIvoiceTitle);
            this.Pnl_ActionTitles.Controls.Add(this.lbl_InAction_AddCustomer);
            this.Pnl_ActionTitles.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_ActionTitles.Location = new System.Drawing.Point(-146, 0);
            this.Pnl_ActionTitles.Name = "Pnl_ActionTitles";
            this.Pnl_ActionTitles.Size = new System.Drawing.Size(146, 739);
            this.Pnl_ActionTitles.TabIndex = 1;
            // 
            // lbl_ConfirmIvoiceTitle
            // 
            this.lbl_ConfirmIvoiceTitle.AutoSize = true;
            this.lbl_ConfirmIvoiceTitle.Location = new System.Drawing.Point(32, 85);
            this.lbl_ConfirmIvoiceTitle.Name = "lbl_ConfirmIvoiceTitle";
            this.lbl_ConfirmIvoiceTitle.Size = new System.Drawing.Size(110, 21);
            this.lbl_ConfirmIvoiceTitle.TabIndex = 11;
            this.lbl_ConfirmIvoiceTitle.Text = "ثبت نهایی فاکتور";
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
            // Pnl_ActionInner
            // 
            this.Pnl_ActionInner.Controls.Add(this.btn_ConfirmPurchase);
            this.Pnl_ActionInner.Controls.Add(this.btn_addCustomer);
            this.Pnl_ActionInner.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_ActionInner.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ActionInner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_ActionInner.Name = "Pnl_ActionInner";
            this.Pnl_ActionInner.Size = new System.Drawing.Size(76, 739);
            this.Pnl_ActionInner.TabIndex = 0;
            this.Pnl_ActionInner.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_ActionInner_Paint);
            this.Pnl_ActionInner.MouseLeave += new System.EventHandler(this.Pnl_ActionInner_MouseLeave);
            this.Pnl_ActionInner.MouseHover += new System.EventHandler(this.Pnl_ActionInner_MouseHover);
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
            this.tooltip_Buttons.SetToolTip(this.btn_ConfirmPurchase, "ثبت نهایی فاکتور");
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
            this.tooltip_Buttons.SetToolTip(this.btn_addCustomer, "افزودن مشتری جدید");
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.Pnl_Top.Controls.Add(this.btn_InstantCustomer);
            this.Pnl_Top.Controls.Add(this.btn_SendToPOS);
            this.Pnl_Top.Controls.Add(this.txt_CustomerName);
            this.Pnl_Top.Controls.Add(this.lbl_InvoiceDateTitle);
            this.Pnl_Top.Controls.Add(this.lblDate);
            this.Pnl_Top.Controls.Add(this.lbl_dailyInvoice);
            this.Pnl_Top.Controls.Add(this.lbl_customer);
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(1272, 141);
            this.Pnl_Top.TabIndex = 1;
            this.Pnl_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_InstantCustomer
            // 
            this.btn_InstantCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_InstantCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InstantCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InstantCustomer.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btn_InstantCustomer.Font = new System.Drawing.Font("Rokh Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_InstantCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_InstantCustomer.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InstantCustomer.Location = new System.Drawing.Point(762, 94);
            this.btn_InstantCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_InstantCustomer.Name = "btn_InstantCustomer";
            this.btn_InstantCustomer.Size = new System.Drawing.Size(120, 34);
            this.btn_InstantCustomer.TabIndex = 23;
            this.btn_InstantCustomer.Text = "مشتری نقدی";
            this.tooltip_Buttons.SetToolTip(this.btn_InstantCustomer, "استفاده از مشتری پیشفرض");
            this.btn_InstantCustomer.Visible = false;
            this.btn_InstantCustomer.Click += new System.EventHandler(this.btn_InstantCustomer_Click);
            // 
            // btn_SendToPOS
            // 
            this.btn_SendToPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_SendToPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SendToPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SendToPOS.Font = new System.Drawing.Font("Rokh Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SendToPOS.ForeColor = System.Drawing.Color.White;
            this.btn_SendToPOS.Image = ((System.Drawing.Image)(resources.GetObject("btn_SendToPOS.Image")));
            this.btn_SendToPOS.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SendToPOS.Location = new System.Drawing.Point(886, 94);
            this.btn_SendToPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendToPOS.Name = "btn_SendToPOS";
            this.btn_SendToPOS.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_SendToPOS.Size = new System.Drawing.Size(106, 34);
            this.btn_SendToPOS.TabIndex = 22;
            this.btn_SendToPOS.Text = "جستجو";
            this.tooltip_Buttons.SetToolTip(this.btn_SendToPOS, "جستجو بین مشتریان");
            this.btn_SendToPOS.Click += new System.EventHandler(this.btn_SendToPOS_Click);
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BackColor = System.Drawing.Color.Black;
            this.txt_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CustomerName.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CustomerName.ForeColor = System.Drawing.Color.White;
            this.txt_CustomerName.Location = new System.Drawing.Point(996, 94);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CustomerName.Size = new System.Drawing.Size(260, 34);
            this.txt_CustomerName.TabIndex = 17;
            this.txt_CustomerName.Text = "مشتری نقدی";
            this.txt_CustomerName.TextChanged += new System.EventHandler(this.txt_CustomerName_TextChanged);
            // 
            // lbl_InvoiceDateTitle
            // 
            this.lbl_InvoiceDateTitle.AutoSize = true;
            this.lbl_InvoiceDateTitle.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_InvoiceDateTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_InvoiceDateTitle.Location = new System.Drawing.Point(12, 12);
            this.lbl_InvoiceDateTitle.Name = "lbl_InvoiceDateTitle";
            this.lbl_InvoiceDateTitle.Size = new System.Drawing.Size(107, 21);
            this.lbl_InvoiceDateTitle.TabIndex = 16;
            this.lbl_InvoiceDateTitle.Text = "تاریخ ثبت فاکتور";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("RokhFaNum", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(12, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 35);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "----/--/--";
            // 
            // lbl_dailyInvoice
            // 
            this.lbl_dailyInvoice.AutoSize = true;
            this.lbl_dailyInvoice.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_dailyInvoice.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dailyInvoice.Location = new System.Drawing.Point(1025, 12);
            this.lbl_dailyInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dailyInvoice.Name = "lbl_dailyInvoice";
            this.lbl_dailyInvoice.Size = new System.Drawing.Size(243, 41);
            this.lbl_dailyInvoice.TabIndex = 13;
            this.lbl_dailyInvoice.Text = "فاکتور فروش روزانه";
            this.lbl_dailyInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_customer.Location = new System.Drawing.Point(1175, 70);
            this.lbl_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(81, 21);
            this.lbl_customer.TabIndex = 6;
            this.lbl_customer.Text = "طرف حساب";
            this.lbl_customer.Click += new System.EventHandler(this.lbl_customer_Click);
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
            // object_5df848ca_f927_4389_812f_3545e39e23ab
            // 
            this.object_5df848ca_f927_4389_812f_3545e39e23ab.Name = "object_5df848ca_f927_4389_812f_3545e39e23ab";
            this.object_5df848ca_f927_4389_812f_3545e39e23ab.StretchHorizontally = true;
            this.object_5df848ca_f927_4389_812f_3545e39e23ab.StretchVertically = true;
            // 
            // tooltip_Buttons
            // 
            this.tooltip_Buttons.BackColor = System.Drawing.Color.Transparent;
            this.tooltip_Buttons.ForeColor = System.Drawing.Color.White;
            this.tooltip_Buttons.Tag = "";
            this.tooltip_Buttons.Popup += new System.Windows.Forms.PopupEventHandler(this.tooltip_AddCustomer_Popup);
            // 
            // Pnl_AllCategories
            // 
            this.Pnl_AllCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.Pnl_AllCategories.Controls.Add(this.Pnl_TotalAmount);
            this.Pnl_AllCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_AllCategories.Location = new System.Drawing.Point(0, 512);
            this.Pnl_AllCategories.Name = "Pnl_AllCategories";
            this.Pnl_AllCategories.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_AllCategories.Size = new System.Drawing.Size(1272, 227);
            this.Pnl_AllCategories.TabIndex = 10;
            // 
            // Pnl_TotalAmount
            // 
            this.Pnl_TotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Pnl_TotalAmount.Controls.Add(this.lbl_currency);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_total);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_taxAmount);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_ComplictionsAmount);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_DiscountAmount);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_border1);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_totalAfterTax);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_taxTitle);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_ComplicationsTitle);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_DiscountTitle);
            this.Pnl_TotalAmount.Controls.Add(this.lbl_totalTitle);
            this.Pnl_TotalAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_TotalAmount.Location = new System.Drawing.Point(10, 10);
            this.Pnl_TotalAmount.Name = "Pnl_TotalAmount";
            this.Pnl_TotalAmount.Size = new System.Drawing.Size(350, 207);
            this.Pnl_TotalAmount.TabIndex = 11;
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_currency.ForeColor = System.Drawing.Color.Gray;
            this.lbl_currency.Location = new System.Drawing.Point(13, 154);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(33, 21);
            this.lbl_currency.TabIndex = 27;
            this.lbl_currency.Text = "ریال";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("RokhFaNum", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(73, 149);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(88, 31);
            this.lbl_total.TabIndex = 26;
            this.lbl_total.Text = "5230000";
            // 
            // lbl_taxAmount
            // 
            this.lbl_taxAmount.AutoSize = true;
            this.lbl_taxAmount.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_taxAmount.ForeColor = System.Drawing.Color.Gray;
            this.lbl_taxAmount.Location = new System.Drawing.Point(176, 92);
            this.lbl_taxAmount.Name = "lbl_taxAmount";
            this.lbl_taxAmount.Size = new System.Drawing.Size(15, 21);
            this.lbl_taxAmount.TabIndex = 25;
            this.lbl_taxAmount.Text = "0";
            // 
            // lbl_ComplictionsAmount
            // 
            this.lbl_ComplictionsAmount.AutoSize = true;
            this.lbl_ComplictionsAmount.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ComplictionsAmount.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ComplictionsAmount.Location = new System.Drawing.Point(176, 71);
            this.lbl_ComplictionsAmount.Name = "lbl_ComplictionsAmount";
            this.lbl_ComplictionsAmount.Size = new System.Drawing.Size(15, 21);
            this.lbl_ComplictionsAmount.TabIndex = 24;
            this.lbl_ComplictionsAmount.Text = "0";
            // 
            // lbl_DiscountAmount
            // 
            this.lbl_DiscountAmount.AutoSize = true;
            this.lbl_DiscountAmount.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_DiscountAmount.ForeColor = System.Drawing.Color.Gray;
            this.lbl_DiscountAmount.Location = new System.Drawing.Point(176, 50);
            this.lbl_DiscountAmount.Name = "lbl_DiscountAmount";
            this.lbl_DiscountAmount.Size = new System.Drawing.Size(15, 21);
            this.lbl_DiscountAmount.TabIndex = 23;
            this.lbl_DiscountAmount.Text = "0";
            // 
            // lbl_border1
            // 
            this.lbl_border1.AutoSize = true;
            this.lbl_border1.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_border1.ForeColor = System.Drawing.Color.Gray;
            this.lbl_border1.Location = new System.Drawing.Point(176, 122);
            this.lbl_border1.Name = "lbl_border1";
            this.lbl_border1.Size = new System.Drawing.Size(158, 21);
            this.lbl_border1.TabIndex = 22;
            this.lbl_border1.Text = "-------------------------------------";
            // 
            // lbl_totalAfterTax
            // 
            this.lbl_totalAfterTax.AutoSize = true;
            this.lbl_totalAfterTax.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_totalAfterTax.ForeColor = System.Drawing.Color.Gray;
            this.lbl_totalAfterTax.Location = new System.Drawing.Point(176, 155);
            this.lbl_totalAfterTax.Name = "lbl_totalAfterTax";
            this.lbl_totalAfterTax.Size = new System.Drawing.Size(150, 21);
            this.lbl_totalAfterTax.TabIndex = 21;
            this.lbl_totalAfterTax.Text = ":مجموع کل پس از اعمال";
            // 
            // lbl_taxTitle
            // 
            this.lbl_taxTitle.AutoSize = true;
            this.lbl_taxTitle.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_taxTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_taxTitle.Location = new System.Drawing.Point(271, 92);
            this.lbl_taxTitle.Name = "lbl_taxTitle";
            this.lbl_taxTitle.Size = new System.Drawing.Size(56, 21);
            this.lbl_taxTitle.TabIndex = 20;
            this.lbl_taxTitle.Text = "مالیات -";
            // 
            // lbl_ComplicationsTitle
            // 
            this.lbl_ComplicationsTitle.AutoSize = true;
            this.lbl_ComplicationsTitle.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ComplicationsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ComplicationsTitle.Location = new System.Drawing.Point(271, 71);
            this.lbl_ComplicationsTitle.Name = "lbl_ComplicationsTitle";
            this.lbl_ComplicationsTitle.Size = new System.Drawing.Size(57, 21);
            this.lbl_ComplicationsTitle.TabIndex = 19;
            this.lbl_ComplicationsTitle.Text = "عوارض -";
            // 
            // lbl_DiscountTitle
            // 
            this.lbl_DiscountTitle.AutoSize = true;
            this.lbl_DiscountTitle.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_DiscountTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_DiscountTitle.Location = new System.Drawing.Point(267, 50);
            this.lbl_DiscountTitle.Name = "lbl_DiscountTitle";
            this.lbl_DiscountTitle.Size = new System.Drawing.Size(61, 21);
            this.lbl_DiscountTitle.TabIndex = 18;
            this.lbl_DiscountTitle.Text = "تخفیف -";
            // 
            // lbl_totalTitle
            // 
            this.lbl_totalTitle.AutoSize = true;
            this.lbl_totalTitle.Font = new System.Drawing.Font("RokhFaNum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_totalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_totalTitle.Location = new System.Drawing.Point(267, 10);
            this.lbl_totalTitle.Name = "lbl_totalTitle";
            this.lbl_totalTitle.Size = new System.Drawing.Size(76, 21);
            this.lbl_totalTitle.TabIndex = 17;
            this.lbl_totalTitle.Text = "مجموع کل";
            // 
            // TimerCurrentTime
            // 
            this.TimerCurrentTime.Enabled = true;
            this.TimerCurrentTime.Interval = 1000;
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
            // DailyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1348, 739);
            this.Controls.Add(this.Pnl_AllCategories);
            this.Controls.Add(this.Pnl_Top);
            this.Controls.Add(this.Pnl_Actions);
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
            this.Pnl_ActionTitles.ResumeLayout(false);
            this.Pnl_ActionTitles.PerformLayout();
            this.Pnl_ActionInner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ConfirmPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addCustomer)).EndInit();
            this.Pnl_Top.ResumeLayout(false);
            this.Pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InstantCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SendToPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            this.Pnl_AllCategories.ResumeLayout(false);
            this.Pnl_TotalAmount.ResumeLayout(false);
            this.Pnl_TotalAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Actions;
        private System.Windows.Forms.Panel Pnl_Top;
        private System.Windows.Forms.Label lbl_customer;
        private Telerik.WinControls.RootRadElement object_5df848ca_f927_4389_812f_3545e39e23ab;
        public Telerik.WinControls.UI.RadButton btn_addCustomer;
        private System.Windows.Forms.ToolTip tooltip_Buttons;
        private System.Windows.Forms.Panel Pnl_ActionInner;
        public Telerik.WinControls.UI.RadButton btn_ConfirmPurchase;
        private System.Windows.Forms.Panel Pnl_ActionTitles;
        private System.Windows.Forms.Label lbl_ConfirmIvoiceTitle;
        private System.Windows.Forms.Label lbl_InAction_AddCustomer;
        private System.Windows.Forms.Panel Pnl_AllCategories;
        private System.Windows.Forms.Panel Pnl_TotalAmount;
        private System.Windows.Forms.Label lbl_dailyInvoice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbl_InvoiceDateTitle;
        private System.Windows.Forms.Timer TimerCurrentTime;
        private System.Windows.Forms.Label lbl_DiscountTitle;
        private System.Windows.Forms.Label lbl_totalTitle;
        private System.Windows.Forms.Label lbl_taxTitle;
        private System.Windows.Forms.Label lbl_ComplicationsTitle;
        private System.Windows.Forms.Label lbl_border1;
        private System.Windows.Forms.Label lbl_totalAfterTax;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Label lbl_taxAmount;
        private System.Windows.Forms.Label lbl_ComplictionsAmount;
        private System.Windows.Forms.Label lbl_DiscountAmount;
        public System.Windows.Forms.Label lbl_total;
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        public Telerik.WinControls.UI.RadButton btn_SendToPOS;
        public System.Windows.Forms.TextBox txt_CustomerName;
        public Telerik.WinControls.UI.RadButton btn_InstantCustomer;
    }
}