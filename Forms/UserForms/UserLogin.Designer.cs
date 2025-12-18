namespace CafeApplication.Forms.UserForms
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CafeApplication.Data.DataSet.DsCafeTableAdapters.TableAdapterManager();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new Telerik.WinControls.UI.RadButton();
            this.btn_Exit = new Telerik.WinControls.UI.RadButton();
            this.Pic_password = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ForgotPass = new System.Windows.Forms.Label();
            this.salesTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.SalesTableAdapter();
            this.Cmb_users = new System.Windows.Forms.ComboBox();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_users = new System.Windows.Forms.DataGridView();
            this.txt_userrole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_users)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCafe
            // 
            this.dsCafe.DataSetName = "DsCafe";
            this.dsCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsCafe;
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("RokhFaNum Normal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_title.Location = new System.Drawing.Point(342, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(120, 37);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "ورود کاربر";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_userName.Location = new System.Drawing.Point(370, 67);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(66, 21);
            this.lbl_userName.TabIndex = 4;
            this.lbl_userName.Text = "نام کاربری";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_password.Location = new System.Drawing.Point(376, 147);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(60, 21);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "رمز عبور";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Black;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("RokhFaNum Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(13, 172);
            this.txt_password.Name = "txt_password";
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(449, 42);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(13, 230);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_Login.Size = new System.Drawing.Size(216, 49);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "ورود";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(237, 230);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_Exit.Size = new System.Drawing.Size(224, 49);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "انصراف و خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Pic_password
            // 
            this.Pic_password.Image = ((System.Drawing.Image)(resources.GetObject("Pic_password.Image")));
            this.Pic_password.Location = new System.Drawing.Point(437, 146);
            this.Pic_password.Name = "Pic_password";
            this.Pic_password.Size = new System.Drawing.Size(20, 20);
            this.Pic_password.TabIndex = 15;
            this.Pic_password.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(438, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ForgotPass
            // 
            this.lbl_ForgotPass.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ForgotPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_ForgotPass.Location = new System.Drawing.Point(14, 145);
            this.lbl_ForgotPass.Name = "lbl_ForgotPass";
            this.lbl_ForgotPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ForgotPass.Size = new System.Drawing.Size(356, 21);
            this.lbl_ForgotPass.TabIndex = 17;
            this.lbl_ForgotPass.Text = "- بار تلاش تا قفل شدن نرم افزار";
            this.lbl_ForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ForgotPass.Visible = false;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // Cmb_users
            // 
            this.Cmb_users.BackColor = System.Drawing.Color.Black;
            this.Cmb_users.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.Cmb_users.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.usersBindingSource, "Username", true));
            this.Cmb_users.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Username", true));
            this.Cmb_users.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.usersBindingSource, "Username", true));
            this.Cmb_users.DataSource = this.usersBindingSource;
            this.Cmb_users.DisplayMember = "Username";
            this.Cmb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_users.Font = new System.Drawing.Font("RokhFaNum Normal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_users.ForeColor = System.Drawing.Color.White;
            this.Cmb_users.FormattingEnabled = true;
            this.Cmb_users.Location = new System.Drawing.Point(14, 93);
            this.Cmb_users.Name = "Cmb_users";
            this.Cmb_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_users.Size = new System.Drawing.Size(447, 43);
            this.Cmb_users.TabIndex = 0;
            this.Cmb_users.ValueMember = "Username";
            this.Cmb_users.SelectedIndexChanged += new System.EventHandler(this.Cmb_users_SelectedIndexChanged_1);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn7.HeaderText = "CreatedAt";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn6.HeaderText = "Role";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordHash";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordHash";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.tbl_users.Location = new System.Drawing.Point(480, 12);
            this.tbl_users.MultiSelect = false;
            this.tbl_users.Name = "tbl_users";
            this.tbl_users.ReadOnly = true;
            this.tbl_users.Size = new System.Drawing.Size(300, 220);
            this.tbl_users.TabIndex = 1000;
            // 
            // txt_userrole
            // 
            this.txt_userrole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true));
            this.txt_userrole.Location = new System.Drawing.Point(480, 238);
            this.txt_userrole.Name = "txt_userrole";
            this.txt_userrole.Size = new System.Drawing.Size(100, 28);
            this.txt_userrole.TabIndex = 18;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(473, 292);
            this.Controls.Add(this.Cmb_users);
            this.Controls.Add(this.tbl_users);
            this.Controls.Add(this.txt_userrole);
            this.Controls.Add(this.lbl_ForgotPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pic_password);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.UsersTableAdapter usersTableAdapter;
        private Data.DataSet.DsCafeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        public Telerik.WinControls.UI.RadButton btn_Login;
        public Telerik.WinControls.UI.RadButton btn_Exit;
        private System.Windows.Forms.PictureBox Pic_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ForgotPass;
        private Data.DataSet.DsCafeTableAdapters.SalesTableAdapter salesTableAdapter;
        public System.Windows.Forms.ComboBox Cmb_users;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView tbl_users;
        private System.Windows.Forms.TextBox txt_userrole;
    }
}