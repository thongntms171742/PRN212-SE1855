using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQ2Object2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity {  get; set; }
        public double Price { get; set; }

        override public string ToString()
        {
            return $"{Id}\t{Name}\t{Quantity}\t{Price}";
        }
        public Product clone()
        {
            return MemberwiseClone() as Product;
        }
    }
}
