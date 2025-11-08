using CafeApplication.Classes.PublicClasses;
using CafeApplication.Data.DataSet;
using CafeApplication.Data.DataSet.DsCafeTableAdapters;
using CafeApplication.Forms.DailyFactor;
using CafeApplication.Forms.PublicForms;
using Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CafeApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetPanelBackColor(); //----- sets mainpanel background
            blur.SetBlurBack(this); //-----> sets a blurry background
            fontSet.SetFont(this); //----> sets font of the form
            SetCurrentTime(); //------> sets current time for mainform labels
            CheckSetupDone(); // -----> checks if first time setup is done
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.setupTableAdapter.Fill(this.dsCafe.Setup);
        }

        

        //--------------- importing classes and needed files ----------------- 
        GetTime gt = new GetTime();
        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();
        CustomMessage msg = new CustomMessage();


        //-------------- import forms ---------------
        DailyInvoice DailyInvoice = new DailyInvoice();

        public void CheckSetupDone()
        {
            //int issetupdone = setupTableAdapter.IsSetupDone(dsCafe.Setup ,true);
            //if (issetupdone == 1)
            //{
            //    msg.NewMessage("ستاپ اولیه", "برای اولین استفاده نیاز دارید که تنظیماتی را انجام دهید.", "Y", "error", "small");
            //}
            //else
            //{
            //    MessageBox.Show("khodafez");
            //}
        }


        public void SetPanelBackColor()
        {
            MainPanel.BackColor = Color.FromArgb(30, 0, 0, 1);
            UserPanel.BackColor = Color.FromArgb(30,0,0,1);
        }
        public void ExpandMainPanel()
        {
            if (MainPanel.Width < 700)
            {
                MainPanel.Size = new Size(742, 729);
            } else
            {
                MainPanel.Size = new Size(368, 729);
            }
        }
        



        //---------------------- Timing classes and Events ---------------
        public void SetCurrentTime()
        {
            lblCurrentTime.Text = gt.GetTimeNow();
            lblDate.Text = $"{gt.GetYear()}/{gt.GetMonth()}/{gt.GetDay()}";
            lblDayTitle.Text = gt.GetDayTitle();
        }

        private void TimerTimeUpdate_Tick(object sender, EventArgs e)
        {
            SetCurrentTime();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //msg.BtnOK.Text = "بله";
            //msg.NewMessage("خروج؟", "آیا واقعا میخواهید از برنامه خارج شوید؟", "YN", "info", "small", YesClick: () => this.Hide() ,NoClick: ()=> e.Cancel = true);
        }

        private void setupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.setupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);
        }




        //--------------------------- Opening menu events -------------------
        private void btn_DailyFactor_Click(object sender, EventArgs e)
        {
            DailyInvoice.ShowDialog();
        } //--------------- open Daily factor

        private void btn_ConfirmDaily_Click(object sender, EventArgs e)
        {

        } //--------------- open confiramtion for daily factors

        private void btn_CustomerManage_Click(object sender, EventArgs e)
        {

        } //--------------- open customer management tabs

        private void btn_warehouse_Click(object sender, EventArgs e)
        {

        } //--------------- open warehouse tools tabs

        private void btn_reports_Click(object sender, EventArgs e)
        {

        } //-------------- open accounting reports tabs

        private void btn_deals_Click(object sender, EventArgs e)
        {

        } //------------- open dealers and signing purchase invoices tabs

        private void btn_products_Click(object sender, EventArgs e)
        {

        } //------------- open product management form

        private void btn_employee_Click(object sender, EventArgs e)
        {

        } //------------- open employee manage tabs

        private void btn_transaction_Click(object sender, EventArgs e)
        {

        } //------------- open transactions tabs
    }
}

