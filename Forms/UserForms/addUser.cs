using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;
using CafeApplication.Classes.PublicClasses;
using CafeApplication.Forms.PublicForms;
using Calendar;

namespace CafeApplication.Forms.UserForms
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();
        CustomMessage msg = new CustomMessage();
        GetTime gt = new GetTime();
        bool AddCondition = false;

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);

        }

        private void addUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCafe.Users);
            lbl_CreatedAt.Text = gt.generateFullDate();
            LoadNewData();
        }

        public void LoadNewData()
        {
            txt_UserName.ResetText();
            txt_userPassword.ResetText();
            txt_NoneHashedPass.ResetText();
            txt_UserRole.ResetText();
            txt_FullName.ResetText();
            Cmb_Roles.SelectedIndex = 0;
            usersBindingSource.AddNew();
            txt_userID.Text = (usersTableAdapter.SetMaxID().GetValueOrDefault() + 1).ToString();
            Chk_isActive.Checked = true;
            txt_salt.Text = "SALT";
            txt_UserRole.Text = Cmb_Roles.Text;
            txt_UserName.Focus();
        }

        public void CheckAddCondition()
        {
            //if (txt_UserName.Text != string.Empty && txt_NoneHashedPass.Text != string.Empty && txt_NoneHashedPass.Text.Length <= 4)
            //{
            //    AddCondition = true;
            //}
            //else
            //{
            //    AddCondition = false;
            //}
            AddCondition = true;
        }

        public void AddNewUser()
        {
            CheckAddCondition();
            int DoesUserExist = usersTableAdapter.GetUsername(dsCafe.Users, txt_UserName.Text);
            if (AddCondition == false)
            {
                msg.NewMessage("افزودن کاربر جدید", "باید نام کاربری و رمز عبور وارد گردد.\nهمچنین رمز عبور باید حداقل شامل 4 کارکتر باشد.", "Y", "warning", null, YesClick: () => { msg.Close(); });
            }
            else if (DoesUserExist == 1)
            {
                msg.NewMessage("افزودن کاربر جدید", $"کاربری با نام {txt_UserName.Text} وجود دارد.\nاز نام دیگری استفاده کنید.", "Y", "warning", null, YesClick: () => { msg.Close(); });

            }
            else
            {
                usersBindingSource.EndEdit();
                int isUpdated = usersTableAdapter.Update(dsCafe.Users);
                if (isUpdated > 0)
                {
                    msg.NewMessage("افزودن کاربر جدید", $"کاربر جدید با موقفیت افزوده شد.", "Y", "success", null, YesClick: () => { msg.Close(); });
                }
                else
                {
                    msg.NewMessage("افزودن کاربر جدید", $"در افزودن کاربر جدید مشکلی پیش آمده.", "Y", "error", null, YesClick: () => { msg.Close(); });
                }
            }
            LoadNewData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void Cmb_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_UserRole.Text = Cmb_Roles.Text;
        }

        private void txt_NoneHashedPass_TextChanged(object sender, EventArgs e)
        {
            txt_userPassword.Text = txt_NoneHashedPass.Text;
        }
    }
}
