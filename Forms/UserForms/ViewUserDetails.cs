using CafeApplication.Classes.PublicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Forms.UserForms
{
    public partial class ViewUserDetails : Form
    {
        public ViewUserDetails()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            fontSet.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();

        private void ViewUserDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCafe.Users);

        }
    }
}
