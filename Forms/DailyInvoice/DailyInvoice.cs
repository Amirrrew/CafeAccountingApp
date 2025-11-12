using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.DailyInvoice;
using CafeApplication.Forms.PublicForms;
using Calendar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeApplication.Forms.DailyFactor
{
    public partial class DailyInvoice : Form
    {
        public DailyInvoice()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            fontSet.SetFont(this);
            tooltip_Buttons.SetToolTip(btn_addCustomer, "افزودن مشتری جدید");
            lblDate.Text = $"{gt.GetYear()}/{gt.GetMonth()}/{gt.GetDay()}";
        }
        //-------------- load classes ---------
        GetTime gt = new GetTime();
        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();
        CustomMessage msg = new CustomMessage();
        string defaultCustomer = "مشتری نقدی";

        private void DailyInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsCafe.Customers);
            // TODO: This line of code loads data into the 'dsCafe.Sales' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dsCafe.Customers' table. You can move, or remove it, as needed.
        }



        //-------------- action buttons events ---------------
        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void btn_ConfirmPurchase_Click(object sender, EventArgs e)
        {
            ConfirmPurchase confirmPurchase = new ConfirmPurchase();
            confirmPurchase.ShowDialog();
        }

        private void Pnl_Actions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_ActionTitles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_ActionInner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cmb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void customersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {

        }

        private void fKSalesCustomerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tooltip_AddCustomer_Popup(object sender, PopupEventArgs e)
        {

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }

        private void Pnl_ActionInner_MouseHover(object sender, EventArgs e)
        {
            Pnl_Actions.Width += 150;
        }

        private void Pnl_ActionInner_MouseLeave(object sender, EventArgs e)
        {
            Pnl_Actions.Width = 76;
        }

        private void btn_SendToPOS_Click(object sender, EventArgs e)
        {


            using (SearchCustomer search = new SearchCustomer())
            {
                if (search.ShowDialog() == DialogResult.OK)
                {
                    txt_CustomerName.Text = search.SelectedValue;
                }
            }

            //SearchCustomer search = new SearchCustomer();
            //search.ShowDialog();
        }

        private void txt_CustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txt_CustomerName.Text != defaultCustomer)
            {
                btn_InstantCustomer.Visible = true;
            }
            else
            {
                btn_InstantCustomer.Visible = false;
            }
        }

        private void btn_InstantCustomer_Click(object sender, EventArgs e)
        {
            txt_CustomerName.Text = defaultCustomer;
        }
    }
}
