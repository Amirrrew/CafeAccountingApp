namespace CafeApplication.Forms.UserForms
{
    partial class addUser
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
            System.Windows.Forms.Label lbl_UserName;
            System.Windows.Forms.Label lbl_Password;
            System.Windows.Forms.Label lbl_FullName;
            System.Windows.Forms.Label lbl_Role;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_userPassword = new System.Windows.Forms.TextBox();
            this.txt_salt = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_UserRole = new System.Windows.Forms.TextBox();
            this.lbl_CreatedAt = new System.Windows.Forms.Label();
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.txt_NoneHashedPass = new System.Windows.Forms.TextBox();
            this.btn_ShowPass = new Telerik.WinControls.UI.RadButton();
            this.Cmb_Roles = new System.Windows.Forms.ComboBox();
            this.Chk_isActive = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.btn_save = new Telerik.WinControls.UI.RadButton();
            this.tbl_Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.txt_CreatedAt = new System.Windows.Forms.TextBox();
            lbl_UserName = new System.Windows.Forms.Label();
            lbl_Password = new System.Windows.Forms.Label();
            lbl_FullName = new System.Windows.Forms.Label();
            lbl_Role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new System.Drawing.Point(372, 104);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new System.Drawing.Size(66, 21);
            lbl_UserName.TabIndex = 3;
            lbl_UserName.Text = "نام کاربری";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new System.Drawing.Point(379, 185);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new System.Drawing.Size(60, 21);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "رمز عبور";
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Location = new System.Drawing.Point(128, 104);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new System.Drawing.Size(114, 21);
            lbl_FullName.TabIndex = 9;
            lbl_FullName.Text = "نام کامل (اختیاری)";
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Location = new System.Drawing.Point(299, 264);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new System.Drawing.Size(139, 21);
            lbl_Role.TabIndex = 24;
            lbl_Role.Text = "نقش کاربر (دسترسی)";
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.Color.Black;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserID", true));
            this.txt_userID.Enabled = false;
            this.txt_userID.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_userID.ForeColor = System.Drawing.Color.White;
            this.txt_userID.Location = new System.Drawing.Point(708, 278);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(88, 34);
            this.txt_userID.TabIndex = 40000;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsCafe;
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.Black;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.txt_UserName.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserName.ForeColor = System.Drawing.Color.White;
            this.txt_UserName.Location = new System.Drawing.Point(248, 128);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_UserName.Size = new System.Drawing.Size(190, 34);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_userPassword
            // 
            this.txt_userPassword.BackColor = System.Drawing.Color.Black;
            this.txt_userPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "PasswordHash", true));
            this.txt_userPassword.Enabled = false;
            this.txt_userPassword.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_userPassword.ForeColor = System.Drawing.Color.White;
            this.txt_userPassword.Location = new System.Drawing.Point(496, 238);
            this.txt_userPassword.Name = "txt_userPassword";
            this.txt_userPassword.Size = new System.Drawing.Size(300, 34);
            this.txt_userPassword.TabIndex = 10000;
            // 
            // txt_salt
            // 
            this.txt_salt.BackColor = System.Drawing.Color.Black;
            this.txt_salt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_salt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Salt", true));
            this.txt_salt.Enabled = false;
            this.txt_salt.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_salt.ForeColor = System.Drawing.Color.White;
            this.txt_salt.Location = new System.Drawing.Point(602, 278);
            this.txt_salt.Name = "txt_salt";
            this.txt_salt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_salt.Size = new System.Drawing.Size(100, 34);
            this.txt_salt.TabIndex = 30000;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BackColor = System.Drawing.Color.Black;
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.txt_FullName.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FullName.ForeColor = System.Drawing.Color.White;
            this.txt_FullName.Location = new System.Drawing.Point(8, 128);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_FullName.Size = new System.Drawing.Size(234, 34);
            this.txt_FullName.TabIndex = 1;
            // 
            // txt_UserRole
            // 
            this.txt_UserRole.BackColor = System.Drawing.Color.Black;
            this.txt_UserRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true));
            this.txt_UserRole.Enabled = false;
            this.txt_UserRole.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserRole.ForeColor = System.Drawing.Color.White;
            this.txt_UserRole.Location = new System.Drawing.Point(496, 278);
            this.txt_UserRole.Name = "txt_UserRole";
            this.txt_UserRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_UserRole.Size = new System.Drawing.Size(100, 34);
            this.txt_UserRole.TabIndex = 20000;
            // 
            // lbl_CreatedAt
            // 
            this.lbl_CreatedAt.Location = new System.Drawing.Point(212, 51);
            this.lbl_CreatedAt.Name = "lbl_CreatedAt";
            this.lbl_CreatedAt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CreatedAt.Size = new System.Drawing.Size(227, 23);
            this.lbl_CreatedAt.TabIndex = 14;
            this.lbl_CreatedAt.Text = "----/--/--";
            this.lbl_CreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.AutoSize = true;
            this.lbl_addUser.Font = new System.Drawing.Font("RokhFaNum Normal", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_addUser.Location = new System.Drawing.Point(204, 9);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(247, 45);
            this.lbl_addUser.TabIndex = 17;
            this.lbl_addUser.Text = "افزودن کاربر جدید";
            this.lbl_addUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_NoneHashedPass
            // 
            this.txt_NoneHashedPass.BackColor = System.Drawing.Color.Black;
            this.txt_NoneHashedPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NoneHashedPass.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_NoneHashedPass.ForeColor = System.Drawing.Color.White;
            this.txt_NoneHashedPass.Location = new System.Drawing.Point(171, 209);
            this.txt_NoneHashedPass.Name = "txt_NoneHashedPass";
            this.txt_NoneHashedPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NoneHashedPass.Size = new System.Drawing.Size(267, 34);
            this.txt_NoneHashedPass.TabIndex = 2;
            this.txt_NoneHashedPass.TextChanged += new System.EventHandler(this.txt_NoneHashedPass_TextChanged);
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPass.Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowPass.ForeColor = System.Drawing.Color.White;
            this.btn_ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowPass.Image")));
            this.btn_ShowPass.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowPass.Location = new System.Drawing.Point(8, 209);
            this.btn_ShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_ShowPass.Size = new System.Drawing.Size(156, 34);
            this.btn_ShowPass.TabIndex = 3;
            this.btn_ShowPass.Text = "نمایش رمز";
            // 
            // Cmb_Roles
            // 
            this.Cmb_Roles.BackColor = System.Drawing.Color.Black;
            this.Cmb_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_Roles.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_Roles.ForeColor = System.Drawing.Color.White;
            this.Cmb_Roles.FormattingEnabled = true;
            this.Cmb_Roles.Items.AddRange(new object[] {
            "مدیر",
            "حسابدار",
            "فروشنده",
            "انباردار"});
            this.Cmb_Roles.Location = new System.Drawing.Point(240, 290);
            this.Cmb_Roles.Name = "Cmb_Roles";
            this.Cmb_Roles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Roles.Size = new System.Drawing.Size(198, 35);
            this.Cmb_Roles.TabIndex = 4;
            this.Cmb_Roles.SelectedIndexChanged += new System.EventHandler(this.Cmb_Roles_SelectedIndexChanged);
            // 
            // Chk_isActive
            // 
            this.Chk_isActive.AutoSize = true;
            this.Chk_isActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "IsActive", true));
            this.Chk_isActive.Font = new System.Drawing.Font("RokhFaNum Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Chk_isActive.Location = new System.Drawing.Point(123, 294);
            this.Chk_isActive.Name = "Chk_isActive";
            this.Chk_isActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Chk_isActive.Size = new System.Drawing.Size(96, 28);
            this.Chk_isActive.TabIndex = 5;
            this.Chk_isActive.Text = "کاربر فعال";
            this.Chk_isActive.UseVisualStyleBackColor = true;
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
            this.btn_cancel.Location = new System.Drawing.Point(70, 352);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(57, 55);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "-";
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
            this.btn_save.Location = new System.Drawing.Point(8, 352);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 55);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "-";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbl_Users
            // 
            this.tbl_Users.AutoGenerateColumns = false;
            this.tbl_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.tbl_Users.DataSource = this.usersBindingSource;
            this.tbl_Users.Enabled = false;
            this.tbl_Users.Location = new System.Drawing.Point(496, 9);
            this.tbl_Users.Name = "tbl_Users";
            this.tbl_Users.Size = new System.Drawing.Size(300, 220);
            this.tbl_Users.TabIndex = 10000;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordHash";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordHash";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn6.HeaderText = "Role";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn7.HeaderText = "CreatedAt";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // txt_CreatedAt
            // 
            this.txt_CreatedAt.BackColor = System.Drawing.Color.Black;
            this.txt_CreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CreatedAt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "CreatedAt", true));
            this.txt_CreatedAt.Enabled = false;
            this.txt_CreatedAt.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CreatedAt.ForeColor = System.Drawing.Color.White;
            this.txt_CreatedAt.Location = new System.Drawing.Point(496, 318);
            this.txt_CreatedAt.Name = "txt_CreatedAt";
            this.txt_CreatedAt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CreatedAt.Size = new System.Drawing.Size(100, 34);
            this.txt_CreatedAt.TabIndex = 40001;
            // 
            // addUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(446, 416);
            this.Controls.Add(this.txt_CreatedAt);
            this.Controls.Add(this.tbl_Users);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Chk_isActive);
            this.Controls.Add(lbl_Role);
            this.Controls.Add(this.Cmb_Roles);
            this.Controls.Add(this.btn_ShowPass);
            this.Controls.Add(this.txt_NoneHashedPass);
            this.Controls.Add(this.lbl_addUser);
            this.Controls.Add(this.lbl_CreatedAt);
            this.Controls.Add(this.txt_UserRole);
            this.Controls.Add(lbl_FullName);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.txt_salt);
            this.Controls.Add(lbl_Password);
            this.Controls.Add(this.txt_userPassword);
            this.Controls.Add(lbl_UserName);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_userID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "addUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن کاربر جدید";
            this.Load += new System.EventHandler(this.addUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.UsersTableAdapter usersTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_userPassword;
        private System.Windows.Forms.TextBox txt_salt;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.TextBox txt_UserRole;
        private System.Windows.Forms.Label lbl_CreatedAt;
        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.TextBox txt_NoneHashedPass;
        public Telerik.WinControls.UI.RadButton btn_ShowPass;
        public System.Windows.Forms.ComboBox Cmb_Roles;
        private System.Windows.Forms.CheckBox Chk_isActive;
        public Telerik.WinControls.UI.RadButton btn_cancel;
        public Telerik.WinControls.UI.RadButton btn_save;
        private System.Windows.Forms.DataGridView tbl_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txt_CreatedAt;
    }
}