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
        private Table actTable;
        public MobilePhone()
        {
            InitializeComponent();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtAvail.Text = ((Product)this.lstProducts.SelectedItem).Available.ToString();
            this.txtOrdered.Text = actTable.GetOrdered((Product)this.lstProducts.SelectedItem).ToString();
            this.butAdd.Enabled = ((Product)this.lstProducts.SelectedItem).IsAvailable;
            this.butDelete.Enabled = actTable.GetOrdered((Product)this.lstProducts.SelectedItem) > 0 ? true : false;
        }
    }
}
