using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Classes.PublicClasses
{
    internal class Number_decimal_format
    {
        public string decimal_format(string number)
        {
            decimal prise;
            string fainal;
            prise = decimal.Parse(number, System.Globalization.NumberStyles.Currency);
            fainal = prise.ToString("#,#");
            return fainal;
        }

        
    }
}
