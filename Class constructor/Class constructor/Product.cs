using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor
{
    class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;

        public Product(int No, string Name, double Price)
        {
            this.No = No;
            this.Name = Name;
            this.Price = Price;
        }
        
    }
}
