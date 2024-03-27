using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Product
    {
        private double Price;
        private int Count;
        public string No {  get; set; }
        public string Name { get; set; }
        public double _price
        {
            get { return Price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int _count
        {
            get { return Count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }
    }
}
