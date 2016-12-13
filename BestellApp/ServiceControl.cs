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
    public partial class ServiceControl : UserControl
    {
        public ServiceControl()
        {
            InitializeComponent();
            this.lstProducts.Items.Clear();
            foreach(Product prod in Globals.Products)
            {
                this.lstProducts.Items.Add((Product)prod);
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstProducts.SelectedItem != null)
            {
                numericUpDown1.Value = ((Product)this.lstProducts.SelectedItem).Available;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            while(this.numericUpDown1.Value > ((Product)this.lstProducts.SelectedItem).Available)
                {
                ((Product)this.lstProducts.SelectedItem).DeleteOne();
            }
            while (this.numericUpDown1.Value < ((Product)this.lstProducts.SelectedItem).Available)
            {
                ((Product)this.lstProducts.SelectedItem).Order();
            }
        }
    }
}
