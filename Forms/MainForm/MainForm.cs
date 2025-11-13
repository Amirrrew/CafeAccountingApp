using CafeApplication.Classes.PublicClasses;
using CafeApplication.Data.DataSet;
using CafeApplication.Data.DataSet.DsCafeTableAdapters;
using CafeApplication.Forms.DailyFactor;
using CafeApplication.Forms.PublicForms;
using Calendar;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

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
        string ProdIconPath = Application.StartupPath + @"/Assets/Icons/Mainmenu/Products/";


        //-------------- import forms ---------------


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

        public void ExpandMainPanel(string PnlTitle, RadButton btn, int LblCount)
        {
            string openPath = Application.StartupPath + @"/Assets/Icons/chevron-left (2).png";
            string closePath = Application.StartupPath + @"/Assets/Icons/Public/chevron-right (2).png";

            if (MainPanel.Width < 700)
            {
                MainPanel.Size = new Size(742, 729);
                btn.Image = Image.FromFile(closePath);
            }
            else
            {
                MainPanel.Size = new Size(368, 729);
                btn.Image = Image.FromFile(openPath);
            }

            lbl_OptionsTitle.Text = PnlTitle;

            bool[] isEnabled = new bool[15];
            for (int i = 0; i <= LblCount; i++)
            {
                isEnabled[i] = true;
            }

            lbl_Option1.Visible = isEnabled[1];
            lbl_Option2.Visible = isEnabled[2];
            lbl_Option3.Visible = isEnabled[3];
            lbl_Option4.Visible = isEnabled[4];
            lbl_Option5.Visible = isEnabled[5];
            lbl_Option6.Visible = isEnabled[6];
            lbl_Option7.Visible = isEnabled[7];
            lbl_Option8.Visible = isEnabled[8];
            lbl_Option9.Visible = isEnabled[9];
            lbl_Option10.Visible = isEnabled[10];
            lbl_Option11.Visible = isEnabled[11];
            lbl_Option12.Visible = isEnabled[12];
            lbl_Option13.Visible = isEnabled[13];
            lbl_Option14.Visible = isEnabled[14];
        }

        private void LabelFunc(Label lbl ,Action func)
        {
            lbl.Click += (sender, e) => func();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            DailyInvoice DailyInvoice = new DailyInvoice();
            DailyInvoice.Show();
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


            ExpandMainPanel(lbl_products.Text ,btn_products ,2);

            lbl_Option2.Text = "مدیریت کالا ها";
            lbl_Option2.Image = Image.FromFile(ProdIconPath + @"manageProducts-Icon.png");

            lbl_Option1.Text = "مدیریت خدمات";
            lbl_Option1.Image = Image.FromFile(ProdIconPath + @"service-Icon.png");

        } //------------- open product management form

        private void btn_employee_Click(object sender, EventArgs e)
        {

        } //------------- open employee manage tabs

        private void btn_transaction_Click(object sender, EventArgs e)
        {

        } //------------- open transactions tabs

    }
}

