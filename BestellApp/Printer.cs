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
                string neueBestellung;
                if (storno)
                {
                    neueBestellung = "<<<<<<<  STORNO  >>>>>>>\r\n";
                }
                else
                {
                    neueBestellung = "<<<<  NEUE Bestellung  >>>>\r\n";
                }
                neueBestellung += "Produkt: " + produkt.Name + "\r\n";
                neueBestellung += "Tisch: " + tisch.Name + "\r\n";
                neueBestellung += "\r\nDatum: " + DateTime.Now.ToString("dd.MM.yyyy") + "\r\n";
                neueBestellung += "Uhrzeit: " + DateTime.Now.ToString("hhh:mm:ss") + "\r\n";
                neueBestellung += "\r\n_________________________\r\n\r\n";
                neueBestellung += this.txtBon.Text;
                this.txtBon.Text = neueBestellung;
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
                string text;
                if ((text = tabelle.GetPrintText()) == "\r\n")
                {
                    return false;
                }

                text = "<<<<<<  RECHNUNG  >>>>>\r\n" + "Tisch: " + tabelle.Name + text;
                text += "\r\nDatum:" + DateTime.Now.ToString("dd.MM.yyyy") + "\r\n";
                text += "Uhrzeit: " + DateTime.Now.ToString("hhh:mm:ss") + "\r\n";
                text += "\r\n_________________________\r\n\r\n";
                this.txtBon.Text = text + this.txtBon.Text;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
