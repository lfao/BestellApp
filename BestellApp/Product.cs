using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellApp
{
    public class Product
    {
        public Product(string name, int count)
        {
            this.id = 0;
            this.name = name;
            this.count = count;
        }
        private int id;
        private int count;
        private string name;

        public string Name
        {
            get { return this.name; }
        }

        public bool IsAvailable
        {
            get
            {
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public int Available
        {
            get { return count; }
        }

        public override string ToString()
        {
            return name;
        }
        public void Order()
        {
            this.count--;
        }
        public void DeleteOne()
        {
            this.count++;
        }
    }
}
