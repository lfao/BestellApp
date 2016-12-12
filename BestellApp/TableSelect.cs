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
    public partial class TableSelect : UserControl
    {
        public int index;
        public Form1 thehome;
        public TableSelect(int index)
        {
            InitializeComponent();
            this.lstProducts.Items.Clear();
            foreach(Table tab in Globals.Tables)
            {
                this.lstProducts.Items.Add((Table)tab);
            }
            this.index = index;
        }

        private void butOrder_Click(object sender, EventArgs e)
        {
            thehome.ShowOrder(index, (Table)lstProducts.SelectedItem);
        }

        public void SetHome(Form1 form)
        {
            this.thehome = form;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstProducts.SelectedIndex>=0)
            {
                butOrder.Enabled = true;
                butBill.Enabled = true;
            }
        }

        private void butBill_Click(object sender, EventArgs e)
        {
            Globals.printer[1].Print((Table)lstProducts.SelectedItem);
        }
    }
}
