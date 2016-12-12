using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellApp
{
    public class Table
    {
        private int id;
        private string name;

        public string Name
        {
            get { return name; }
        }

        public int GetOrdered(Product prod)
        {
            return -1;
        }

        public string GetPrintText()
        {
            return "DEAD";
        }
    }
}
