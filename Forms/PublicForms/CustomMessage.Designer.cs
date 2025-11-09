namespace CafeApplication.Forms.PublicForms
{
    partial class CustomMessage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.BtnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rokh", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(45, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(106, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "عنوان پیام";
            // 
            // lbltext
            // 
            this.lbltext.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(9, 61);
            this.lbltext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltext.Name = "lbltext";
            this.lbltext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltext.Size = new System.Drawing.Size(352, 82);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "متن پیام";
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnOK.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.BtnOK.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(5, 2);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(110, 36);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "بله";
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOK.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOK.GetChildAt(0))).Text = "بله";
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOK.GetChildAt(0))).Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.BtnOK.GetChildAt(0).GetChildAt(3))).Enabled = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnCancel.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(236, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "لغو";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNo.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnNo.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(120, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(110, 36);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "خیر";
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(7, 9);
            this.iconBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(34, 41);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 5;
            this.iconBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 43);
            this.panel1.TabIndex = 6;
            // 
            // CustomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 190);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessage";
            this.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیغام";
            this.Load += new System.EventHandler(this.CustomMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Panel panel1;
        public Telerik.WinControls.UI.RadButton BtnOK;
        public Telerik.WinControls.UI.RadButton btnCancel;
        public Telerik.WinControls.UI.RadButton btnNo;
    }
}