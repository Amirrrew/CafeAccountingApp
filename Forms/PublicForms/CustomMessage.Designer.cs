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
            ((System.ComponentModel.ISupportInitialize)(this.BtnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rokh Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(64, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(109, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "عنوان پیام";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Rokh Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(13, 58);
            this.lbltext.Name = "lbltext";
            this.lbltext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltext.Size = new System.Drawing.Size(65, 21);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "متن پیام";
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnOK.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.BtnOK.Font = new System.Drawing.Font("Rokh Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(13, 141);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(110, 36);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "بله";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnCancel.Font = new System.Drawing.Font("Rokh Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(245, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "لغو";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNo.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnNo.Font = new System.Drawing.Font("Rokh Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(129, 141);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(110, 36);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "خیر";
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(10, 9);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(49, 39);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 5;
            this.iconBox.TabStop = false;
            // 
            // CustomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 190);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rokh Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیغام";
            ((System.ComponentModel.ISupportInitialize)(this.BtnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton BtnOK;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lbltext;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnNo;
        private System.Windows.Forms.PictureBox iconBox;
    }
}