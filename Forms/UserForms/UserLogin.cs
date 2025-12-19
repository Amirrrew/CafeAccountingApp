using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Forms.UserForms
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
            Attemps();
        }

        // --------------- importing classes
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        CustomMessage msg = new CustomMessage();
        UserWork usrwrk = new UserWork();
        int remainingAttemps = 9;
        string password;
        int FindUser;

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dsCafe.Sales);
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill_ActiveUsers(this.dsCafe.Users);
            Cmb_users.DisplayMember = "Username";
            Cmb_users.ValueMember = "Username";
        }


        public void Attemps()
        {
            if (remainingAttemps >= 1)
            {
                if (remainingAttemps <= 5)
                {
                    string RemainText = " بار تلاش تا قفل شدن نرم افزار";
                    lbl_ForgotPass.Visible = true;
                    lbl_ForgotPass.Text = remainingAttemps.ToString() + RemainText;
                }
                else
                {
                    lbl_ForgotPass.Visible = false;
                }
            }
        }

        public void LoginAttemp()
        {
            if (remainingAttemps >= 1)
            {
                string userPassowrd = GetPass();

                if (txt_password.Text == userPassowrd)
                {
                    MainForm mf = new MainForm();
                    mf.Username = Cmb_users.Text;
                    mf.UserRole = txt_userrole.Text;
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    msg.NewMessage("ورود", "رمز عبور اشتباه است. دوباره تلاش کنید.", "warning", "Y", null, YesClick: () => msg.Close());
                    remainingAttemps -= 1;
                    Attemps();
                }
            }
            else
            {
                msg.NewMessage("ورود", "نرم افزار به دلیل ورود رمز اشتباه مکرر قفل شد!\n برای فعالسازی و ورود نیاز است شماره سریال آن را وارد کنید.", "error", "Y", null, YesClick: () => msg.Close());
                lbl_ForgotPass.Text = "نرم افزار ققل شد!";
                btn_Login.Enabled = false;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string GetPass()
        {
            FindUser = usersTableAdapter.GetUsername(dsCafe.Users, Cmb_users.Text);
            if (FindUser != 0)
            {
                password = usersTableAdapter.GetPassword(Cmb_users.Text.ToString());
            }
            else
            {
                msg.NewMessage("ورود", "کاربری انتخاب نشده.", "warning", "Y", null, YesClick: () => msg.Close());
            }
            return password;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginAttemp();

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == string.Empty)
            {
                btn_Login.Enabled = false;
            }
            else
            {
                btn_Login.Enabled = true;
            }
        }

        private void Cmb_users_Click(object sender, EventArgs e)
        {

        }

        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            usrwrk.ShowHidePass(txt_password, btn_ShowPass);
        }

        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            usrwrk.ShowHidePass(txt_password, btn_ShowPass);
        }
    }
}
