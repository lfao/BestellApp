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
        public Printer(string Name)
        {
            InitializeComponent();
            this.lblName.Text = Name;
        }

        public bool Print(Product produkt, bool storno, Table tisch)
        {
            try
            {
                if (storno)
                {
                    this.txtBon.Text = "==== STORNO ====\r\n";
                }
                else
                {
                    this.txtBon.Text = "<< NEUE Bestellung >>\r\n";
                }
                this.txtBon.Text += "Produkt: " + produkt.Name + "\r\n";
                this.txtBon.Text += "Tisch: " + tisch.Name + "\r\n";
                this.txtBon.Text += "\r\n" + DateTime.Now.ToString("dd.MM.yyyy") + "\r\n";
                this.txtBon.Text += DateTime.Now.ToString("h:mm:ss") + "\r\n";
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
                this.txtBon.Text = "=== RECHNUNG ===\r\n";
                this.txtBon.Text += "Tisch: " + tabelle.Name;
                this.txtBon.Text += tabelle.GetPrintText();
                this.txtBon.Text += "\r\n" + DateTime.Now.ToString("dd.MM.yyyy") + "\r\n";
                this.txtBon.Text += DateTime.Now.ToString("h:mm:ss") + "\r\n";
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
