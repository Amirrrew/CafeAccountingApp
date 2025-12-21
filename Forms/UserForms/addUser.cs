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
        bool AddingCondition = false;

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCafe);
        }

        public void LoadNew()
        {
            usersTableAdapter.Fill(dsCafe.Users);
            tbl_Users.Refresh();
            txt_UserName.ResetText();
            txt_userPassword.ResetText();
            txt_NoneHashedPass.ResetText();
            txt_FullName.ResetText();
            txt_UserRole.ResetText();
            Cmb_Roles.SelectedIndex = 0;
            usersBindingSource.AddNew();
            int NewID = usersTableAdapter.SetMaxID().GetValueOrDefault() + 1;
            txt_userID.Text = NewID.ToString();
            txt_salt.Text = "SALT";
            txt_UserRole.Text = Cmb_Roles.Text;
            txt_UserName.Focus();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCafe.Users);
            lbl_CreatedAt.Text = gt.generateFullDate();
            LoadNew();
        }

        public bool checkAddingCondition()
        {
            if (txt_UserName.Text == string.Empty)
            {
                msg.NewMessage("افزودن کاربر", "نام کاربری وارد نشده!", "Y", "warning", null, YesClick: () => msg.Close());
                AddingCondition = false;
            }
            else if (txt_NoneHashedPass.Text == string.Empty || txt_NoneHashedPass.Text.Length < 4)
            {
                msg.NewMessage("افزودن کاربر", "برای افزودن کاربر باید رمز عبور تعیین گردد و رمز باید حداقل شامل 4 کارکتر باشد.", "Y", "warning", null, YesClick: () => msg.Close());
                AddingCondition = false;
            }
            else if (usersTableAdapter.CheckForUserName(txt_UserName.Text).GetValueOrDefault() > 0)
            {
                msg.NewMessage("افزودن کاربر", $"یک کاربر با نام کاربری {txt_UserName.Text} ثبت شده.\nلطفا نام کاربری دیگری وارد کنید.", "Y", "warning", null, YesClick: () => msg.Close());
                AddingCondition = false;
            }
            else
            {
                AddingCondition = true;
            }
                return AddingCondition;
        }

        public void AddUser()
        {
            try
            {
                bool FinalAddCondition = checkAddingCondition();
                if (FinalAddCondition == true)
                {
                    usersBindingSource.EndEdit();
                    int isUpdated = usersTableAdapter.Update(dsCafe.Users);
                    if (isUpdated > 0)
                    {
                        msg.NewMessage("افزودن کاربر", "کاربر جدید با موفقیت افزوده شد.", "Y", "success", null, YesClick: () => msg.Close());
                        LoadNew();
                    }
                    else
                    {
                        msg.NewMessage("افزودن کاربر", "در افزودن کاربر جدید مشکلی پیش آمده!", "Y", "error", null, YesClick: () => msg.Close());
                    }
                }
            }
            catch
            {
                msg.NewMessage("افزودن کاربر", "در افزودن کاربر جدید مشکلی پیش آمده! اگر با باز و بسته کردن فرم مشکل پابرجا ماند با پشتیبانی تماس حاصل کنید.", "Y", "error", null, YesClick: () => msg.Close());
            }

        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void Cmb_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_UserRole.Text = Cmb_Roles.Text;
        }

        private void txt_NoneHashedPass_TextChanged(object sender, EventArgs e)
        {
            txt_userPassword.Text = BCrypt.Net.BCrypt.HashPassword(txt_NoneHashedPass.Text);
        }
    }
}
