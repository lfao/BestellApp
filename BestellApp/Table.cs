using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellApp
{
    public class Table
    {
        public Table(int id, string name)
        {
            this.id = id;
            this.name = name;
            foreach (Product prod in Globals.Products)
            {
                orderedProducts.Add(new BestellApp.Ordered(prod));
            }
        }
        private int id;
        private string name;
        private List<Ordered> orderedProducts = new List<Ordered>();
        public string Name
        {
            get { return name; }
        }

        public int GetOrdered(Product prod)
        {
            foreach (Ordered ord in this.orderedProducts)
            {
                if (ord.Prod == prod)
                {
                    return ord.count;
                }
            }
            return 0;
        }

        public string GetPrintText()
        {
            string text = "\r\n";
            foreach(Ordered ord in orderedProducts)
            {
                if(ord.count>0)
                {
                    text += ord.count + "x " + ord.Prod + "\r\n";
                }
            }

            foreach(Ordered ord in orderedProducts)
            {
                ord.count = 0;
            }
            return text;
        }
        public override string ToString()
        {
            return this.name;
        }

        public bool order(Product prod)
        {
            if (prod.IsAvailable)
            {
                prod.Order();
                foreach (Ordered ord in this.orderedProducts)
                {
                    if (ord.Prod == prod)
                    {
                        ord.count++;
                        break;
                    }
                }
                Globals.printer[0].Print(prod, false, this);
                return true;
            }

            return false;
        }
        public bool Delete(Product prod)
        {
            bool vorhanden = false;
            foreach (Ordered ord in this.orderedProducts)
            {
                if (ord.Prod == prod)
                {
                    if (ord.count > 0)
                        vorhanden = true;
                    break;
                }
            }
            if (vorhanden)
            {
                prod.DeleteOne();
                foreach (Ordered ord in this.orderedProducts)
                {
                    if (ord.Prod == prod)
                    {
                        ord.count--;
                        break;
                    }
                }
                Globals.printer[0].Print(prod, true, this);
                return true;
            }
            return false;
        }
    }
}
