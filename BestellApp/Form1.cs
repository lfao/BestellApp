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
        public TableSelect[] tableselect = new TableSelect[2];
        public Form1()
        {
            InitializeComponent();
            this.tableselect[0] = new TableSelect();
            this.Controls.Add(this.tableselect[0]);
            this.tableselect[0].Location = new Point(10, 10);
            this.tableselect[0].Show();
            this.tableselect[1] = new TableSelect();
            this.Controls.Add(this.tableselect[1]);
            this.tableselect[1].Location = new Point(400, 10);
            this.tableselect[1].Show();
        }
    }
}
