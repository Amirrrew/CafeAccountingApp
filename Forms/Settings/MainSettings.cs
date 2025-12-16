using CafeApplication.Classes.PublicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Forms.Settings
{
    public partial class MainSettings : Form
    {
        public MainSettings()
        {
            InitializeComponent();
            blur.SetBlurBack(this);
            font.SetFont(this);
        }

        //--------------- import forms and classes ----
        BackBlur blur = new BackBlur();
        FontSet font = new FontSet();

        
    }
}
