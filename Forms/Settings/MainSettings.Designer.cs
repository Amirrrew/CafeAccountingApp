namespace CafeApplication.Forms.Settings
{
    partial class MainSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSettings));
            this.pnl_SettingsCategory = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87 = new Telerik.WinControls.RootRadElement();
            this.Tab_settings = new System.Windows.Forms.TabControl();
            this.tab_UserManage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_RoleManage = new Telerik.WinControls.UI.RadButton();
            this.btn_deleteUser = new Telerik.WinControls.UI.RadButton();
            this.btn_userInfo = new Telerik.WinControls.UI.RadButton();
            this.btn_editUser = new Telerik.WinControls.UI.RadButton();
            this.btn_AddUser = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.pnl_SettingsCategory.SuspendLayout();
            this.Tab_settings.SuspendLayout();
            this.tab_UserManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RoleManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_SettingsCategory
            // 
            this.pnl_SettingsCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pnl_SettingsCategory.Controls.Add(this.radButton1);
            this.pnl_SettingsCategory.Controls.Add(this.txt_Search);
            this.pnl_SettingsCategory.Controls.Add(this.label1);
            this.pnl_SettingsCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_SettingsCategory.Location = new System.Drawing.Point(746, 0);
            this.pnl_SettingsCategory.Name = "pnl_SettingsCategory";
            this.pnl_SettingsCategory.Size = new System.Drawing.Size(282, 588);
            this.pnl_SettingsCategory.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.Black;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("RokhFaNum Normal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Search.ForeColor = System.Drawing.Color.White;
            this.txt_Search.Location = new System.Drawing.Point(10, 53);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Search.Size = new System.Drawing.Size(263, 34);
            this.txt_Search.TabIndex = 14;
            this.txt_Search.Text = "جستجو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RokhFaNum Normal", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "تنظیمات";
            // 
            // object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87
            // 
            this.object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87.Name = "object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87";
            this.object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87.StretchHorizontally = true;
            this.object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87.StretchVertically = true;
            // 
            // Tab_settings
            // 
            this.Tab_settings.Controls.Add(this.tab_UserManage);
            this.Tab_settings.Controls.Add(this.tabPage2);
            this.Tab_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_settings.Location = new System.Drawing.Point(0, 0);
            this.Tab_settings.Name = "Tab_settings";
            this.Tab_settings.SelectedIndex = 0;
            this.Tab_settings.Size = new System.Drawing.Size(746, 588);
            this.Tab_settings.TabIndex = 1;
            // 
            // tab_UserManage
            // 
            this.tab_UserManage.BackColor = System.Drawing.Color.Black;
            this.tab_UserManage.Controls.Add(this.btn_RoleManage);
            this.tab_UserManage.Controls.Add(this.btn_deleteUser);
            this.tab_UserManage.Controls.Add(this.btn_userInfo);
            this.tab_UserManage.Controls.Add(this.btn_editUser);
            this.tab_UserManage.Controls.Add(this.btn_AddUser);
            this.tab_UserManage.Location = new System.Drawing.Point(4, 30);
            this.tab_UserManage.Name = "tab_UserManage";
            this.tab_UserManage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_UserManage.Size = new System.Drawing.Size(738, 554);
            this.tab_UserManage.TabIndex = 0;
            this.tab_UserManage.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_RoleManage
            // 
            this.btn_RoleManage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_RoleManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_RoleManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_RoleManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RoleManage.Font = new System.Drawing.Font("Rokh Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_RoleManage.ForeColor = System.Drawing.Color.White;
            this.btn_RoleManage.Image = ((System.Drawing.Image)(resources.GetObject("btn_RoleManage.Image")));
            this.btn_RoleManage.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RoleManage.Location = new System.Drawing.Point(7, 305);
            this.btn_RoleManage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RoleManage.Name = "btn_RoleManage";
            this.btn_RoleManage.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_RoleManage.Size = new System.Drawing.Size(724, 78);
            this.btn_RoleManage.TabIndex = 14;
            this.btn_RoleManage.Text = "مدیریت دسترسی برای نقش ها";
            this.btn_RoleManage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RoleManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteUser.Font = new System.Drawing.Font("Rokh Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteUser.Image")));
            this.btn_deleteUser.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteUser.Location = new System.Drawing.Point(7, 222);
            this.btn_deleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_deleteUser.Size = new System.Drawing.Size(724, 78);
            this.btn_deleteUser.TabIndex = 13;
            this.btn_deleteUser.Text = "حذف کاربر";
            this.btn_deleteUser.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btn_userInfo
            // 
            this.btn_userInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_userInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_userInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userInfo.Font = new System.Drawing.Font("Rokh Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_userInfo.ForeColor = System.Drawing.Color.White;
            this.btn_userInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_userInfo.Image")));
            this.btn_userInfo.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_userInfo.Location = new System.Drawing.Point(7, 139);
            this.btn_userInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_userInfo.Name = "btn_userInfo";
            this.btn_userInfo.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_userInfo.Size = new System.Drawing.Size(724, 78);
            this.btn_userInfo.TabIndex = 12;
            this.btn_userInfo.Text = "مشاهده مشخصات کاربران";
            this.btn_userInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_userInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btn_editUser
            // 
            this.btn_editUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_editUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editUser.Font = new System.Drawing.Font("Rokh Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_editUser.ForeColor = System.Drawing.Color.White;
            this.btn_editUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_editUser.Image")));
            this.btn_editUser.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editUser.Location = new System.Drawing.Point(7, 56);
            this.btn_editUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_editUser.Size = new System.Drawing.Size(724, 78);
            this.btn_editUser.TabIndex = 11;
            this.btn_editUser.Text = "ویرایش کاربر";
            this.btn_editUser.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUser.Font = new System.Drawing.Font("Rokh Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.btn_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddUser.Image")));
            this.btn_AddUser.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddUser.Location = new System.Drawing.Point(7, -27);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_AddUser.Size = new System.Drawing.Size(724, 78);
            this.btn_AddUser.TabIndex = 10;
            this.btn_AddUser.Text = "افزودن کاربر جدید";
            this.btn_AddUser.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radButton1.Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton1.ForeColor = System.Drawing.Color.White;
            this.radButton1.Image = ((System.Drawing.Image)(resources.GetObject("radButton1.Image")));
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton1.Location = new System.Drawing.Point(10, 94);
            this.radButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radButton1.Name = "radButton1";
            this.radButton1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            // 
            // 
            // 
            this.radButton1.RootElement.FocusBorderWidth = 0;
            this.radButton1.RootElement.Opacity = 1D;
            this.radButton1.Size = new System.Drawing.Size(263, 37);
            this.radButton1.TabIndex = 13;
            this.radButton1.Text = "مدیریت کاربران";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "مدیریت کاربران";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Rokh Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 588);
            this.Controls.Add(this.Tab_settings);
            this.Controls.Add(this.pnl_SettingsCategory);
            this.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainSettings";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.pnl_SettingsCategory.ResumeLayout(false);
            this.pnl_SettingsCategory.PerformLayout();
            this.Tab_settings.ResumeLayout(false);
            this.tab_UserManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_RoleManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_userInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SettingsCategory;
        private System.Windows.Forms.Label label1;
        public Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.RootRadElement object_02d7b4e7_c422_40dc_8cf7_43c97eab1e87;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TabControl Tab_settings;
        private System.Windows.Forms.TabPage tab_UserManage;
        private System.Windows.Forms.TabPage tabPage2;
        public Telerik.WinControls.UI.RadButton btn_AddUser;
        public Telerik.WinControls.UI.RadButton btn_editUser;
        public Telerik.WinControls.UI.RadButton btn_RoleManage;
        public Telerik.WinControls.UI.RadButton btn_deleteUser;
        public Telerik.WinControls.UI.RadButton btn_userInfo;
    }
}