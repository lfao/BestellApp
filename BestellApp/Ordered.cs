using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellApp
{
    public class Ordered
    {
        private Product prod;
        public Product Prod
        {
            get { return prod; }
        }
        public int count;
        public Ordered(Product produ)
        {
            this.prod = produ;
        }
    }
}
