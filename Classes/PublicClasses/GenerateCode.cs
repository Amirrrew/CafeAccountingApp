using CafeApplication.Data.DataSet;
using CafeApplication.Data.DataSet.DsCafeTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Classes.PublicClasses
{
    internal class GenerateCode
    {
        public long Barcode(string text)
        {
            long FinalCode = 0;
            ProductsTableAdapter prdtbl = new ProductsTableAdapter();
            DsCafe ds = new DsCafe();
            Int32 doesExist = prdtbl.FillBy_code_user(ds.Products, text);
            Random rnd = new Random();

            if (doesExist != 1)
            {
                FinalCode = rnd.Next(100000000,1000000000);
            }
            return FinalCode; 
        }
    }
}
