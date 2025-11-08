namespace CafeApplication.Forms.DailyInvoice
{
    partial class ConfirmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPurchase));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_totalLabel = new System.Windows.Forms.Label();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.lbl_TitlePayment = new System.Windows.Forms.Label();
            this.txt_Cash = new System.Windows.Forms.TextBox();
            this.lbl_Cash = new System.Windows.Forms.Label();
            this.txt_POS = new System.Windows.Forms.TextBox();
            this.btn_SendToPOS = new Telerik.WinControls.UI.RadButton();
            this.lbl_POS = new System.Windows.Forms.Label();
            this.lbl_border = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_FinalPrice = new System.Windows.Forms.Label();
            this.txt_finalPrice = new System.Windows.Forms.Label();
            this.lbl_IRRIAL = new System.Windows.Forms.Label();
            this.txt_Credit = new System.Windows.Forms.TextBox();
            this.lbl_Credit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SendToPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Rokh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Title.Location = new System.Drawing.Point(280, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(214, 41);
            this.lbl_Title.TabIndex = 13;
            this.lbl_Title.Text = "ثبت نهایی فاکتور";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totalLabel
            // 
            this.lbl_totalLabel.AutoSize = true;
            this.lbl_totalLabel.Location = new System.Drawing.Point(392, 68);
            this.lbl_totalLabel.Name = "lbl_totalLabel";
            this.lbl_totalLabel.Size = new System.Drawing.Size(96, 21);
            this.lbl_totalLabel.TabIndex = 14;
            this.lbl_totalLabel.Text = "مجموع فاکتور";
            this.lbl_totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.BackColor = System.Drawing.Color.Black;
            this.txt_TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalPrice.Font = new System.Drawing.Font("RokhFaNum Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_TotalPrice.ForeColor = System.Drawing.Color.White;
            this.txt_TotalPrice.Location = new System.Drawing.Point(265, 92);
            this.txt_TotalPrice.MaxLength = 10;
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.Size = new System.Drawing.Size(222, 45);
            this.txt_TotalPrice.TabIndex = 15;
            this.txt_TotalPrice.Text = "1000000";
            this.txt_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TitlePayment
            // 
            this.lbl_TitlePayment.AutoSize = true;
            this.lbl_TitlePayment.Font = new System.Drawing.Font("Rokh Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_TitlePayment.Location = new System.Drawing.Point(360, 172);
            this.lbl_TitlePayment.Name = "lbl_TitlePayment";
            this.lbl_TitlePayment.Size = new System.Drawing.Size(127, 31);
            this.lbl_TitlePayment.TabIndex = 17;
            this.lbl_TitlePayment.Text = "روش پرداخت";
            this.lbl_TitlePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Cash
            // 
            this.txt_Cash.BackColor = System.Drawing.Color.Black;
            this.txt_Cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cash.Font = new System.Drawing.Font("RokhFaNum Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Cash.ForeColor = System.Drawing.Color.White;
            this.txt_Cash.Location = new System.Drawing.Point(340, 297);
            this.txt_Cash.MaxLength = 10;
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.ReadOnly = true;
            this.txt_Cash.Size = new System.Drawing.Size(145, 45);
            this.txt_Cash.TabIndex = 18;
            this.txt_Cash.Text = "1000000";
            this.txt_Cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Cash
            // 
            this.lbl_Cash.AutoSize = true;
            this.lbl_Cash.Location = new System.Drawing.Point(451, 273);
            this.lbl_Cash.Name = "lbl_Cash";
            this.lbl_Cash.Size = new System.Drawing.Size(34, 21);
            this.lbl_Cash.TabIndex = 19;
            this.lbl_Cash.Text = "نقد";
            this.lbl_Cash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_POS
            // 
            this.txt_POS.BackColor = System.Drawing.Color.Black;
            this.txt_POS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_POS.Font = new System.Drawing.Font("RokhFaNum Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_POS.ForeColor = System.Drawing.Color.White;
            this.txt_POS.Location = new System.Drawing.Point(160, 297);
            this.txt_POS.MaxLength = 10;
            this.txt_POS.Name = "txt_POS";
            this.txt_POS.ReadOnly = true;
            this.txt_POS.Size = new System.Drawing.Size(174, 45);
            this.txt_POS.TabIndex = 20;
            this.txt_POS.Text = "1000000";
            this.txt_POS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SendToPOS
            // 
            this.btn_SendToPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_SendToPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SendToPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SendToPOS.Font = new System.Drawing.Font("Rokh", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SendToPOS.ForeColor = System.Drawing.Color.White;
            this.btn_SendToPOS.Image = ((System.Drawing.Image)(resources.GetObject("btn_SendToPOS.Image")));
            this.btn_SendToPOS.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SendToPOS.Location = new System.Drawing.Point(13, 297);
            this.btn_SendToPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendToPOS.Name = "btn_SendToPOS";
            this.btn_SendToPOS.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_SendToPOS.Size = new System.Drawing.Size(140, 45);
            this.btn_SendToPOS.TabIndex = 21;
            this.btn_SendToPOS.Text = "ارسال به پوز";
            // 
            // lbl_POS
            // 
            this.lbl_POS.AutoSize = true;
            this.lbl_POS.Location = new System.Drawing.Point(274, 273);
            this.lbl_POS.Name = "lbl_POS";
            this.lbl_POS.Size = new System.Drawing.Size(61, 21);
            this.lbl_POS.TabIndex = 22;
            this.lbl_POS.Text = "کارتخوان";
            this.lbl_POS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_border
            // 
            this.lbl_border.AutoSize = true;
            this.lbl_border.Font = new System.Drawing.Font("Rokh Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_border.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_border.Location = new System.Drawing.Point(7, 172);
            this.lbl_border.Name = "lbl_border";
            this.lbl_border.Size = new System.Drawing.Size(357, 31);
            this.lbl_border.TabIndex = 23;
            this.lbl_border.Text = "-------------------------------------------------";
            this.lbl_border.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Discount
            // 
            this.txt_Discount.BackColor = System.Drawing.Color.Black;
            this.txt_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Discount.Font = new System.Drawing.Font("RokhFaNum Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Discount.ForeColor = System.Drawing.Color.White;
            this.txt_Discount.Location = new System.Drawing.Point(132, 92);
            this.txt_Discount.MaxLength = 10;
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.ReadOnly = true;
            this.txt_Discount.Size = new System.Drawing.Size(127, 45);
            this.txt_Discount.TabIndex = 24;
            this.txt_Discount.Text = "1000000";
            this.txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Location = new System.Drawing.Point(204, 68);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(55, 21);
            this.lbl_Discount.TabIndex = 25;
            this.lbl_Discount.Text = "تخفیف";
            this.lbl_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_FinalPrice
            // 
            this.lbl_FinalPrice.AutoSize = true;
            this.lbl_FinalPrice.Location = new System.Drawing.Point(409, 223);
            this.lbl_FinalPrice.Name = "lbl_FinalPrice";
            this.lbl_FinalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_FinalPrice.Size = new System.Drawing.Size(78, 21);
            this.lbl_FinalPrice.TabIndex = 26;
            this.lbl_FinalPrice.Text = "مبلغ نهایی:";
            this.lbl_FinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_finalPrice
            // 
            this.txt_finalPrice.AutoSize = true;
            this.txt_finalPrice.Font = new System.Drawing.Font("RokhFaNum", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_finalPrice.Location = new System.Drawing.Point(278, 214);
            this.txt_finalPrice.Name = "txt_finalPrice";
            this.txt_finalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_finalPrice.Size = new System.Drawing.Size(127, 35);
            this.txt_finalPrice.TabIndex = 27;
            this.txt_finalPrice.Text = "----------------";
            this.txt_finalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IRRIAL
            // 
            this.lbl_IRRIAL.AutoSize = true;
            this.lbl_IRRIAL.Font = new System.Drawing.Font("RokhFaNum SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_IRRIAL.Location = new System.Drawing.Point(235, 220);
            this.lbl_IRRIAL.Name = "lbl_IRRIAL";
            this.lbl_IRRIAL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_IRRIAL.Size = new System.Drawing.Size(37, 24);
            this.lbl_IRRIAL.TabIndex = 28;
            this.lbl_IRRIAL.Text = "ریال";
            this.lbl_IRRIAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Credit
            // 
            this.txt_Credit.BackColor = System.Drawing.Color.Black;
            this.txt_Credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Credit.Font = new System.Drawing.Font("RokhFaNum Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Credit.ForeColor = System.Drawing.Color.White;
            this.txt_Credit.Location = new System.Drawing.Point(13, 371);
            this.txt_Credit.MaxLength = 10;
            this.txt_Credit.Name = "txt_Credit";
            this.txt_Credit.ReadOnly = true;
            this.txt_Credit.Size = new System.Drawing.Size(470, 45);
            this.txt_Credit.TabIndex = 29;
            this.txt_Credit.Text = "1000000";
            this.txt_Credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.AutoSize = true;
            this.lbl_Credit.Location = new System.Drawing.Point(443, 349);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(44, 21);
            this.lbl_Credit.TabIndex = 30;
            this.lbl_Credit.Text = "نسیه";
            this.lbl_Credit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConfirmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.lbl_Credit);
            this.Controls.Add(this.txt_Credit);
            this.Controls.Add(this.lbl_IRRIAL);
            this.Controls.Add(this.txt_finalPrice);
            this.Controls.Add(this.lbl_FinalPrice);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.lbl_border);
            this.Controls.Add(this.lbl_POS);
            this.Controls.Add(this.btn_SendToPOS);
            this.Controls.Add(this.txt_POS);
            this.Controls.Add(this.lbl_Cash);
            this.Controls.Add(this.txt_Cash);
            this.Controls.Add(this.lbl_TitlePayment);
            this.Controls.Add(this.txt_TotalPrice);
            this.Controls.Add(this.lbl_totalLabel);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Rokh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ConfirmPurchase";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت فاکتور";
            this.Load += new System.EventHandler(this.ConfirmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_SendToPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_totalLabel;
        public System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.Label lbl_TitlePayment;
        public System.Windows.Forms.TextBox txt_Cash;
        private System.Windows.Forms.Label lbl_Cash;
        public System.Windows.Forms.TextBox txt_POS;
        public Telerik.WinControls.UI.RadButton btn_SendToPOS;
        private System.Windows.Forms.Label lbl_POS;
        private System.Windows.Forms.Label lbl_border;
        public System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_FinalPrice;
        private System.Windows.Forms.Label txt_finalPrice;
        private System.Windows.Forms.Label lbl_IRRIAL;
        public System.Windows.Forms.TextBox txt_Credit;
        private System.Windows.Forms.Label lbl_Credit;
    }
}