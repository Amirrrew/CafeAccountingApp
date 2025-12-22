using CafeApplication.Classes.PublicClasses;
using CafeApplication.Data.DataSet.DsCafeTableAdapters;
using CafeApplication.Forms.PublicForms;
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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            fontSet.SetFont(this);
        }

        BackBlur blur = new BackBlur();
        FontSet fontSet = new FontSet();
        CustomMessage msg = new CustomMessage();

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCafe.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsCafe.Users);

        }

        private DialogResult msg_Question()
        {
            msg.NewMessage("هشدار", "آیا از حذف کاربر انتخاب شده مطمئن هستید؟", "YN", "warning", null);
            return msg.DialogResult;
        }

        private void btn_delete_coustomer_Click(object sender, EventArgs e)
        {
            if (tbl_Users.Rows.Count > 1)
            {
                if (msg_Question() == DialogResult.OK)
                {
                    usersBindingSource.RemoveAt(tbl_Users.CurrentRow.Index);
                    usersBindingSource.EndEdit();
                    usersTableAdapter.Update(dsCafe.Users);
                    msg.NewMessage("حذف", "کاربر با موفقیت حذف شد.", "Y", "info", null);
                }
            }
            else
            {
                msg.NewMessage("حذف", "نمیتوانید تنها کاربر ثبت شده را حذف کنید.\nبرای استفاده از نرم افزار باید حداقل یک کاربر ثبت شده باشد.", "Y", "error", null);
            }

        }
    }
}
