namespace CafeApplication.Forms.UserForms
{
    partial class ViewUserDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_Users = new System.Windows.Forms.DataGridView();
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.UsersTableAdapter();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Users
            // 
            this.tbl_Users.AllowUserToAddRows = false;
            this.tbl_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tbl_Users.AutoGenerateColumns = false;
            this.tbl_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_Users.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tbl_Users.ColumnHeadersHeight = 40;
            this.tbl_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isActiveDataGridViewCheckBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.tbl_Users.DataSource = this.usersBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_Users.DefaultCellStyle = dataGridViewCellStyle8;
            this.tbl_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Users.EnableHeadersVisualStyles = false;
            this.tbl_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_Users.Location = new System.Drawing.Point(0, 0);
            this.tbl_Users.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbl_Users.MultiSelect = false;
            this.tbl_Users.Name = "tbl_Users";
            this.tbl_Users.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tbl_Users.RowHeadersWidth = 5;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Users.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tbl_Users.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tbl_Users.RowTemplate.Height = 35;
            this.tbl_Users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Users.Size = new System.Drawing.Size(849, 711);
            this.tbl_Users.TabIndex = 33;
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
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "فعال؟";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Width = 91;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "نقش / دسترسی";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 133;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام کامل";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "کد سیستمی";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 111;
            // 
            // ViewUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(849, 711);
            this.Controls.Add(this.tbl_Users);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "ViewUserDetails";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات کاربران";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView tbl_Users;
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}