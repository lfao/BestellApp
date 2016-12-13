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
    public partial class MobilePhone : UserControl
    {
        private int index;
        private Table actTable;
        private Form1 thehome;
        public MobilePhone(Table table, int index, Form1 home)
        {
            InitializeComponent();
            this.actTable = table;
            this.lstProducts.Items.Clear();
            foreach (Product prod in Globals.Products)
            {
                this.lstProducts.Items.Add((Product)prod);
            }
            this.index = index;
            this.thehome = home;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (!actTable.Delete((Product)this.lstProducts.SelectedItem))
            {
                thehome.ShowError((Product)this.lstProducts.SelectedItem, 1);
            }
            this.update();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (!actTable.order((Product)this.lstProducts.SelectedItem))
            {
                thehome.ShowError((Product)this.lstProducts.SelectedItem, 0);
            }
            this.update();
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.update();
        }
        private void update()
        {
            if (this.lstProducts.SelectedItem != null)
            {
                this.txtAvail.Text = ((Product)this.lstProducts.SelectedItem).Available.ToString();
                this.txtOrdered.Text = actTable.GetOrdered((Product)this.lstProducts.SelectedItem).ToString();
                this.butAdd.Enabled = ((Product)this.lstProducts.SelectedItem).IsAvailable;
                this.butDelete.Enabled = actTable.GetOrdered((Product)this.lstProducts.SelectedItem) > 0 ? true : false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.tableselect[index].Show();
            Globals.mobilephones[index].Hide();
        }
    }
}
