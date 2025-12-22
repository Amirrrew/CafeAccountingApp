namespace CafeApplication.Forms.UserForms
{
    partial class EditUser
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
            System.Windows.Forms.Label passwordHashLabel;
            System.Windows.Forms.Label lbl_fullName;
            System.Windows.Forms.Label lbl_createdAt;
            System.Windows.Forms.Label lbl_Role;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.usersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.tbl_users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_ShowPass = new Telerik.WinControls.UI.RadButton();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.txt_Role = new System.Windows.Forms.TextBox();
            this.Chk_isActive = new System.Windows.Forms.CheckBox();
            this.Cmb_users = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.btn_save = new Telerik.WinControls.UI.RadButton();
            this.txt_HashedPass = new System.Windows.Forms.TextBox();
            this.btn_userUP = new Telerik.WinControls.UI.RadButton();
            this.btn_userDOWN = new Telerik.WinControls.UI.RadButton();
            passwordHashLabel = new System.Windows.Forms.Label();
            lbl_fullName = new System.Windows.Forms.Label();
            lbl_createdAt = new System.Windows.Forms.Label();
            lbl_Role = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userDOWN)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Location = new System.Drawing.Point(429, 87);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(60, 21);
            passwordHashLabel.TabIndex = 2;
            passwordHashLabel.Text = "رمز عبور";
            // 
            // lbl_fullName
            // 
            lbl_fullName.AutoSize = true;
            lbl_fullName.Location = new System.Drawing.Point(375, 161);
            lbl_fullName.Name = "lbl_fullName";
            lbl_fullName.Size = new System.Drawing.Size(114, 21);
            lbl_fullName.TabIndex = 16;
            lbl_fullName.Text = "نام کامل (اختیاری)";
            // 
            // lbl_createdAt
            // 
            lbl_createdAt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "CreatedAt", true));
            lbl_createdAt.Location = new System.Drawing.Point(339, 47);
            lbl_createdAt.Name = "lbl_createdAt";
            lbl_createdAt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_createdAt.Size = new System.Drawing.Size(150, 21);
            lbl_createdAt.TabIndex = 18;
            lbl_createdAt.Text = "----/--/--";
            lbl_createdAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Location = new System.Drawing.Point(350, 233);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new System.Drawing.Size(139, 21);
            lbl_Role.TabIndex = 22;
            lbl_Role.Text = "نقش کاربر (دسترسی)";
            // 
            // lbl_userName
            // 
            this.lbl_userName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.lbl_userName.Font = new System.Drawing.Font("RokhFaNum Normal", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_userName.ForeColor = System.Drawing.Color.Silver;
            this.lbl_userName.Location = new System.Drawing.Point(43, 9);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_userName.Size = new System.Drawing.Size(454, 47);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "نام کاربری";
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
            // tbl_users
            // 
            this.tbl_users.AutoGenerateColumns = false;
            this.tbl_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.tbl_users.DataSource = this.usersBindingSource;
            this.tbl_users.Enabled = false;
            this.tbl_users.Location = new System.Drawing.Point(517, 13);
            this.tbl_users.Name = "tbl_users";
            this.tbl_users.Size = new System.Drawing.Size(300, 220);
            this.tbl_users.TabIndex = 100000;
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
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Black;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(183, 111);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(306, 38);
            this.txt_password.TabIndex = 0;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPass.Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowPass.ForeColor = System.Drawing.Color.White;
            this.btn_ShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowPass.Image")));
            this.btn_ShowPass.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowPass.Location = new System.Drawing.Point(9, 111);
            this.btn_ShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_ShowPass.Size = new System.Drawing.Size(169, 38);
            this.btn_ShowPass.TabIndex = 1;
            this.btn_ShowPass.Text = "نمایش رمز";
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);
            // 
            // txt_fullName
            // 
            this.txt_fullName.BackColor = System.Drawing.Color.Black;
            this.txt_fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.txt_fullName.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_fullName.ForeColor = System.Drawing.Color.White;
            this.txt_fullName.Location = new System.Drawing.Point(7, 185);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_fullName.Size = new System.Drawing.Size(482, 38);
            this.txt_fullName.TabIndex = 2;
            // 
            // txt_Role
            // 
            this.txt_Role.BackColor = System.Drawing.Color.Black;
            this.txt_Role.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Role.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true));
            this.txt_Role.Enabled = false;
            this.txt_Role.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Role.ForeColor = System.Drawing.Color.White;
            this.txt_Role.Location = new System.Drawing.Point(517, 239);
            this.txt_Role.Name = "txt_Role";
            this.txt_Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Role.Size = new System.Drawing.Size(141, 38);
            this.txt_Role.TabIndex = 10000;
            // 
            // Chk_isActive
            // 
            this.Chk_isActive.AutoSize = true;
            this.Chk_isActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "IsActive", true));
            this.Chk_isActive.Font = new System.Drawing.Font("RokhFaNum Normal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Chk_isActive.Location = new System.Drawing.Point(174, 263);
            this.Chk_isActive.Name = "Chk_isActive";
            this.Chk_isActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Chk_isActive.Size = new System.Drawing.Size(96, 28);
            this.Chk_isActive.TabIndex = 4;
            this.Chk_isActive.Text = "کاربر فعال";
            this.Chk_isActive.UseVisualStyleBackColor = true;
            this.Chk_isActive.Click += new System.EventHandler(this.Chk_isActive_Click);
            // 
            // Cmb_users
            // 
            this.Cmb_users.BackColor = System.Drawing.Color.Black;
            this.Cmb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_users.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_users.ForeColor = System.Drawing.Color.White;
            this.Cmb_users.FormattingEnabled = true;
            this.Cmb_users.Items.AddRange(new object[] {
            "مدیر",
            "حسابدار",
            "فروشنده",
            "انباردار"});
            this.Cmb_users.Location = new System.Drawing.Point(291, 259);
            this.Cmb_users.Name = "Cmb_users";
            this.Cmb_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_users.Size = new System.Drawing.Size(198, 35);
            this.Cmb_users.TabIndex = 3;
            this.Cmb_users.SelectedIndexChanged += new System.EventHandler(this.Cmb_users_SelectedIndexChanged);
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
            this.btn_cancel.Location = new System.Drawing.Point(69, 307);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(57, 55);
            this.btn_cancel.TabIndex = 6;
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
            this.btn_save.Location = new System.Drawing.Point(7, 307);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 55);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "-";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_HashedPass
            // 
            this.txt_HashedPass.BackColor = System.Drawing.Color.Black;
            this.txt_HashedPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HashedPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "PasswordHash", true));
            this.txt_HashedPass.Enabled = false;
            this.txt_HashedPass.Font = new System.Drawing.Font("RokhFaNum Normal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_HashedPass.ForeColor = System.Drawing.Color.White;
            this.txt_HashedPass.Location = new System.Drawing.Point(517, 283);
            this.txt_HashedPass.Name = "txt_HashedPass";
            this.txt_HashedPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_HashedPass.Size = new System.Drawing.Size(300, 38);
            this.txt_HashedPass.TabIndex = 100000;
            // 
            // btn_userUP
            // 
            this.btn_userUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_userUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_userUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userUP.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_userUP.Image = ((System.Drawing.Image)(resources.GetObject("btn_userUP.Image")));
            this.btn_userUP.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_userUP.Location = new System.Drawing.Point(6, 6);
            this.btn_userUP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_userUP.Name = "btn_userUP";
            this.btn_userUP.Size = new System.Drawing.Size(30, 28);
            this.btn_userUP.TabIndex = 7;
            this.btn_userUP.Text = "-";
            this.btn_userUP.Visible = false;
            this.btn_userUP.Click += new System.EventHandler(this.btn_userUP_Click);
            // 
            // btn_userDOWN
            // 
            this.btn_userDOWN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_userDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_userDOWN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userDOWN.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_userDOWN.Image = ((System.Drawing.Image)(resources.GetObject("btn_userDOWN.Image")));
            this.btn_userDOWN.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_userDOWN.Location = new System.Drawing.Point(6, 39);
            this.btn_userDOWN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_userDOWN.Name = "btn_userDOWN";
            this.btn_userDOWN.Size = new System.Drawing.Size(30, 28);
            this.btn_userDOWN.TabIndex = 8;
            this.btn_userDOWN.Text = "-";
            this.btn_userDOWN.Visible = false;
            this.btn_userDOWN.Click += new System.EventHandler(this.btn_userDOWN_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(497, 370);
            this.Controls.Add(this.btn_userDOWN);
            this.Controls.Add(this.btn_userUP);
            this.Controls.Add(this.txt_HashedPass);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(lbl_Role);
            this.Controls.Add(this.Cmb_users);
            this.Controls.Add(this.Chk_isActive);
            this.Controls.Add(lbl_createdAt);
            this.Controls.Add(this.txt_Role);
            this.Controls.Add(lbl_fullName);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.btn_ShowPass);
            this.Controls.Add(passwordHashLabel);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.tbl_users);
            this.Controls.Add(this.lbl_userName);
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کاربر فعلی";
            this.Load += new System.EventHandler(this.ManageCurrentUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userDOWN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userName;
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.UsersTableAdapter usersTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txt_password;
        public Telerik.WinControls.UI.RadButton btn_ShowPass;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.TextBox txt_Role;
        private System.Windows.Forms.CheckBox Chk_isActive;
        public System.Windows.Forms.ComboBox Cmb_users;
        public Telerik.WinControls.UI.RadButton btn_cancel;
        public Telerik.WinControls.UI.RadButton btn_save;
        private System.Windows.Forms.TextBox txt_HashedPass;
        public Telerik.WinControls.UI.RadButton btn_userUP;
        public Telerik.WinControls.UI.RadButton btn_userDOWN;
    }
}