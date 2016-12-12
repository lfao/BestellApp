using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestellApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Ersetzen durch Datei

            Globals.Products.Add(new Product("Schweinebraten", 5));
            Globals.Products.Add(new Product("saueres Lüngerl", 3));
            Globals.Products.Add(new Product("Weissbier", 50));

            // --------------------

            for (int i = 1; i < 6; i++)
            {
                Table tab = new Table(i - 1, "Tab" + i.ToString());
                Globals.Tables.Add(tab);
            }

            Globals.tableselect[0] = new TableSelect(0);
            this.Controls.Add(Globals.tableselect[0]);
            Globals.tableselect[0].Location = new Point(10, 10);
            Globals.tableselect[0].SetHome(this);
            Globals.tableselect[0].Show();

            Globals.tableselect[1] = new TableSelect(1);
            this.Controls.Add(Globals.tableselect[1]);
            Globals.tableselect[1].Location = new Point(400, 10);
            Globals.tableselect[1].SetHome(this);
            Globals.tableselect[1].Show();

            Globals.printer[0] = new Printer("Products");
            this.Controls.Add(Globals.printer[0]);
            Globals.printer[0].Location = new Point(10, 350);
            Globals.printer[0].Show();

            Globals.printer[1] = new Printer("Bill");
            this.Controls.Add(Globals.printer[1]);
            Globals.printer[1].Location = new Point(400, 350);
            Globals.printer[1].Show();
        }

        public void ShowOrder(int index, Table table)
        {
            Globals.mobilephones[index] = new MobilePhone(table, index, this);
            this.Controls.Add(Globals.mobilephones[index]);
            Globals.mobilephones[index].Location = new Point(390 * index + 10, 10);
            Globals.tableselect[index].Visible = false;
            Globals.mobilephones[index].Show();
        }
        public void ShowError(Product prod, int type)
        {
            switch (type)
            {
                case 0:
                    MessageBox.Show(prod.Name + " not available", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("No " + prod.Name + " was ordered", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
