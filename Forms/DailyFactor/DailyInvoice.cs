using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
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
    }
}
