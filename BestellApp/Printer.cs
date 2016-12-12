using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestellApp
{
    public partial class Printer : UserControl
    {
        public Printer()
        {
            InitializeComponent();
        }

        public bool Print(Product produkt, bool storno)
        {
            try
            {
                if(storno)
                {
                    this.txtBon.Text = "==== STORNO ====/r/n";
                }

                this.txtBon.Text = produkt.Name;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Print(Table tabelle)
        {
            try
            {
                this.txtBon.Text = tabelle.GetPrintText();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
