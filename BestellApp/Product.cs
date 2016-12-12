using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellApp
{
    public class Product
    {
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
            return "[" + id.ToString() + "] " + name;
        }
    }
}
