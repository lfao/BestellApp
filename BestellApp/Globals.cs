using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellApp
{
    public static class Globals
    {
        public static List<Product> Products = new List<Product>();
        public static TableSelect[] tableselect = new TableSelect[2];
        public static Printer[] printer = new Printer[2];
        public static MobilePhone[] mobilephones = new MobilePhone[2];
        public static List<Table> Tables = new List<Table>();

    }
}
