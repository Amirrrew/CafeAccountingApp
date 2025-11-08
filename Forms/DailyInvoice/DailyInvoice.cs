using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.DailyInvoice;
using CafeApplication.Forms.PublicForms;
using System.IO;
using Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            tooltip_AddCustomer.SetToolTip(btn_addCustomer , "افزودن مشتری جدید");
        }

        //-------------- load classes ---------
        GetTime gt = new GetTime();
        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();
        CustomMessage msg = new CustomMessage();

        private void DailyInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dsCafe.Sales);
            // TODO: This line of code loads data into the 'dsCafe.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsCafe.Customers);

        }


        private void btn_DailyInvoice_Click(object sender, EventArgs e)
        {

            if (Pnl_Actions.Width < 100)
            {
                Pnl_Actions.Width += 150;
                btn_ExpandPanel.Location = new Point(1047, 354);
                btn_ExpandPanel.Image = Image.FromFile(Application.StartupPath + @"/Assets/Icons/Public/chevron-right.png");
            }
            else
            {
                Pnl_Actions.Width = 76;
                btn_ExpandPanel.Location = new Point(1197, 354);
                btn_ExpandPanel.Image = Image.FromFile(Application.StartupPath + @"/Assets/Icons/Public/chevron-left.png");
            }
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
    }
}
