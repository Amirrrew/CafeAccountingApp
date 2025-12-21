using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CafeApplication.Forms.UserForms
{
    public partial class ManageCurrentUser : Form
    {
        public ManageCurrentUser()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            fontSet.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();
        UserWork usrwrk = new UserWork();
        CustomMessage msg = new CustomMessage();
        bool EditCondition = false;
        public string CurrentUser { get; set; }

        private void ManageCurrentUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCafe.Users);
            LoadCurrnetUserDetails();
            usrwrk.SetCmbRole(Cmb_users ,txt_Role);
        }

        public void LoadCurrnetUserDetails()
        {
            lbl_userName.Text = CurrentUser;
            usersTableAdapter.GetUsername(dsCafe.Users, lbl_userName.Text);
            txt_password.ResetText();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }

        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            usrwrk.ShowHidePass(txt_password, btn_ShowPass);
        }

        public void IsConditionTrue()
        {
            if (txt_password.Text.Length < 4)
            {
                msg.NewMessage("ویرایش کاربر", "رمز عبور باید حداقل شامل 4 کارکتر باشد.", "Y", "warning", null, YesClick: () => { msg.Close(); });

            }
            else
            {
                EditCondition = true;
            }
        }

        public void ExecuteEdit()
        {
            if (EditCondition == true)
            {
                usersBindingSource.EndEdit();
                int isUpdated = usersTableAdapter.Update(dsCafe.Users);
                if (isUpdated > 0)
                {
                    msg.NewMessage("ویرایش کاربر", "تغییرات با موفقیت دخیره شد.", "Y", "success", null, YesClick: () => { msg.Close(); this.Close(); });
                }
                else
                {
                    msg.NewMessage("ویرایش کاربر", "در اعمال تغییرات مشکلی پیش آمده!", "Y", "error", null, YesClick: () => { msg.Close(); });
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            IsConditionTrue();
            ExecuteEdit();
        }

        private void Cmb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Role.Text = Cmb_users.Text;
        }

        private int GetActiveUsers()
        {
            using (SqlConnection con = new SqlConnection(usersTableAdapter.Connection.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE IsActive = 1", con))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void Chk_isActive_Click(object sender, EventArgs e)
        {
            int activeUser = GetActiveUsers();
            if (activeUser < 2)
            {   
                msg.NewMessage("ویرایش کاربر", "تعداد کاربران فعال نمیتواند کمتر از یک کاربر باشد.", "Y", "error", null, YesClick: () => { msg.Close(); });
                Chk_isActive.Checked = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_HashedPass.Text = BCrypt.Net.BCrypt.HashPassword(txt_password.Text);
        }
    }
}
