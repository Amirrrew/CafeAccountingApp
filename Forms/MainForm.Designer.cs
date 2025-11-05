namespace CafeApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.InnerPanel = new System.Windows.Forms.Panel();
            this.Pnl_DailtyFactor = new System.Windows.Forms.Panel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.TimerTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDayTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            this.Pnl_DailtyFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.InnerPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainPanel.Location = new System.Drawing.Point(1129, 10);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainPanel.Size = new System.Drawing.Size(368, 737);
            this.MainPanel.TabIndex = 0;
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.Transparent;
            this.InnerPanel.Controls.Add(this.Pnl_DailtyFactor);
            this.InnerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InnerPanel.Font = new System.Drawing.Font("Rokh Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InnerPanel.Location = new System.Drawing.Point(12, 10);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Size = new System.Drawing.Size(346, 717);
            this.InnerPanel.TabIndex = 1;
            // 
            // Pnl_DailtyFactor
            // 
            this.Pnl_DailtyFactor.Controls.Add(this.radButton1);
            this.Pnl_DailtyFactor.Controls.Add(this.label1);
            this.Pnl_DailtyFactor.Location = new System.Drawing.Point(0, 3);
            this.Pnl_DailtyFactor.Name = "Pnl_DailtyFactor";
            this.Pnl_DailtyFactor.Size = new System.Drawing.Size(346, 71);
            this.Pnl_DailtyFactor.TabIndex = 8;
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radButton1.BackgroundImage")));
            this.radButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(20, 23);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(27, 24);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "radButton1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "صدور فاکتور فروش روزانه";
            // 
            // UserPanel
            // 
            this.UserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserPanel.BackColor = System.Drawing.Color.Black;
            this.UserPanel.Location = new System.Drawing.Point(11, 434);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(411, 303);
            this.UserPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rokh SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "PanelTester";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("RokhFaNum Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCurrentTime.Location = new System.Drawing.Point(-1, 28);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(159, 61);
            this.lblCurrentTime.TabIndex = 3;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // TimerTimeUpdate
            // 
            this.TimerTimeUpdate.Enabled = true;
            this.TimerTimeUpdate.Interval = 1000;
            this.TimerTimeUpdate.Tick += new System.EventHandler(this.TimerTimeUpdate_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("RokhFaNum Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(7, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "----/--/--";
            // 
            // lblDayTitle
            // 
            this.lblDayTitle.AutoSize = true;
            this.lblDayTitle.Font = new System.Drawing.Font("Rokh Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayTitle.Location = new System.Drawing.Point(86, 71);
            this.lblDayTitle.Name = "lblDayTitle";
            this.lblDayTitle.Size = new System.Drawing.Size(46, 21);
            this.lblDayTitle.TabIndex = 5;
            this.lblDayTitle.Text = "شنبه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rokh Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "- امروز -----------------";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rokh SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(13, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Message Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1507, 757);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDayTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rokh Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1525, 796);
            this.MinimumSize = new System.Drawing.Size(1170, 796);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salam";
            this.MainPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            this.Pnl_DailtyFactor.ResumeLayout(false);
            this.Pnl_DailtyFactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel InnerPanel;
        private System.Windows.Forms.Label lblCurrentTime;
        public System.Windows.Forms.Timer TimerTimeUpdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDayTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Pnl_DailtyFactor;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

