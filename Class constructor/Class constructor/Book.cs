using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor
{
    class Book: Product
    {
        public string Genre;

        public Book(string genre,double price):base(price)
        {
            this Genre = genre;
        }
        public string Genre;
    }
}
