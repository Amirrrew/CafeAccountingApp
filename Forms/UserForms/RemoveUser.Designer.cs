namespace CafeApplication.Forms.UserForms
{
    partial class RemoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Remove = new Telerik.WinControls.UI.RadButton();
            this.tbl_Users = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCafe = new CafeApplication.Data.DataSet.DsCafe();
            this.usersTableAdapter = new CafeApplication.Data.DataSet.DsCafeTableAdapters.UsersTableAdapter();
            this.lbl_titele = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_Remove.Image")));
            this.btn_Remove.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Remove.Location = new System.Drawing.Point(5, 6);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(44, 37);
            this.btn_Remove.TabIndex = 33;
            this.btn_Remove.Text = "-";
            this.btn_Remove.Click += new System.EventHandler(this.btn_delete_coustomer_Click);
            // 
            // tbl_Users
            // 
            this.tbl_Users.AllowUserToAddRows = false;
            this.tbl_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_Users.AutoGenerateColumns = false;
            this.tbl_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_Users.BackgroundColor = System.Drawing.Color.Black;
            this.tbl_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_Users.ColumnHeadersHeight = 40;
            this.tbl_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbl_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn});
            this.tbl_Users.DataSource = this.usersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_Users.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbl_Users.EnableHeadersVisualStyles = false;
            this.tbl_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_Users.Location = new System.Drawing.Point(5, 50);
            this.tbl_Users.MultiSelect = false;
            this.tbl_Users.Name = "tbl_Users";
            this.tbl_Users.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tbl_Users.RowHeadersWidth = 5;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.tbl_Users.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tbl_Users.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tbl_Users.RowTemplate.Height = 35;
            this.tbl_Users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Users.Size = new System.Drawing.Size(344, 397);
            this.tbl_Users.TabIndex = 32;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "نام کاربران";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_titele
            // 
            this.lbl_titele.AutoSize = true;
            this.lbl_titele.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_titele.ForeColor = System.Drawing.Color.Gray;
            this.lbl_titele.Location = new System.Drawing.Point(221, 6);
            this.lbl_titele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titele.Name = "lbl_titele";
            this.lbl_titele.Size = new System.Drawing.Size(134, 41);
            this.lbl_titele.TabIndex = 34;
            this.lbl_titele.Text = "حذف کاربر";
            this.lbl_titele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.lbl_titele);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.tbl_Users);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف کاربر";
            this.Load += new System.EventHandler(this.RemoveUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadButton btn_Remove;
        public System.Windows.Forms.DataGridView tbl_Users;
        private Data.DataSet.DsCafe dsCafe;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Data.DataSet.DsCafeTableAdapters.UsersTableAdapter usersTableAdapter;
        public System.Windows.Forms.Label lbl_titele;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}