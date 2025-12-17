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
    public partial class ManageCurrentUser : Form
    {
        public ManageCurrentUser()
        {
            InitializeComponent();
            
        }

        public string CurrentUser { get; set; }

        private void ManageCurrentUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCafe.Users);
            LoadCurrnetUserDetails();
        }

        public void LoadCurrnetUserDetails()
        {
            lbl_userName.Text = CurrentUser;
            usersTableAdapter.GetUsername(dsCafe.Users, lbl_userName.Text);
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }
    }
}
