using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Classes.PublicClasses
{
    internal class NumberSeperate
    {
        public void Seperate(MaskedTextBox mask)
        {
            string input = mask.Text.Replace(",", "").Trim();

            if (long.TryParse(input, out long num))
            {
                mask.Text = string.Format("{0:n0}", num);
            }
        }
    }
}
