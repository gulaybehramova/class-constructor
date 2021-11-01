using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor
{
    class Library
    {
        public Book[] Books;
        public void AddBook(Book book)
        {
            var temp = this.Books;
            Book[] NewBook = new Book[temp.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = NewBook[i];
            }
            book = NewBook[NewBook.Length - 1];
            this.Books = NewBook;
        }
        public Book[] GetFilteredBooks(string genre)
        {
            int say = 0;
            foreach (var item in Books)
            {
                if (item.Genre == genre)
                    say++;
            }
            Book[] filtered = new Book[say]; int index = 0;
            foreach (var item in Books)
            {
                if (item.Genre == genre)
                {
                    filtered[index] = item;
                    index++;
                }
            }
            return filtered;
        }
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            int i = 0;
            foreach (var item in Books)
            {
                if (minPrice<item.Price && maxPrice>item.Price)
                    i++;
            }
            Book[] fltrdint = new Book[i]; int count = 0;
            foreach (var item in Books)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                {
                    fltrdint[count] = item;
                    count++;
                }
            }
            return fltrdint;
        }
    }
}
