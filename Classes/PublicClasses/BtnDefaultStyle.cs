using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace CafeApplication.Classes.PublicClasses
{
    internal class BtnDefaultStyle
    {
        public void SetBtnColor(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is RadButton btn)
                {
                    btn.BackColor = Color.FromArgb(20,0,0,1);
                }

                if (control.HasChildren)
                {
                    SetBtnColor(control);
                }
            }
        }
    }
}
