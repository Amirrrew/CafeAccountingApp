using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Classes.PublicClasses
{
    internal class FontSet
    {
        PrivateFontCollection pf = new PrivateFontCollection();
        public void SetFont(Form form)
        {
            pf.AddFontFile(Application.StartupPath + @"/Assets/Fonts/Rokh-Normal.ttf");

            FontFamily ff = pf.Families[0];
            Font rokh = new Font(ff, 12, FontStyle.Regular);

            form.Font = rokh;
        }
    }
}
