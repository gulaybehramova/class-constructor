using System;

namespace Class_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitab sayini daxil edin: ");
            string countStr = Console.ReadLine();

            int count = Convert.ToInt32(countStr);

            if (count > 0)
            {
                Book[] books = new Book[count];

                for (int i = 0; i <books.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"(i+1)-ci kitabin melumatlarini daxil edin");
                    Console.WriteLine();


                }
                string filter;
                do
                {
                    Console.WriteLine("Filterlemek Isteyirsiniz? y/n");
                    filter = Console.ReadLine();
                }
                while (filter != "y" && filter != "n");
                if (filter == "y")
                {
                    string choose1;
                    Console.WriteLine("1.Genre adina gore");
                    Console.WriteLine("2.Qiymet intervalina gore");
                    choose1 = Console.ReadLine();

                    if (choose1 == "1")
                    {
                        string genre;
                        Console.WriteLine("Janrin adini daxil edin: ");
                        genre = Console.ReadLine();
                    }

                    if (choose1 == "2")
                    {
                        Console.WriteLine("Min Price Daxil Edin: ");
                        string minprice = Console.ReadLine();
                        int minint = Convert.ToInt32(minprice);

                        Console.WriteLine("Max price daxil edin");
                        string maxprice = Console.ReadLine();
                        int maxint = Convert.ToInt32(maxprice);

                        var filterforprice = Library.GetFilteredBooks(Library.Books, minint, maxint);
                        Console.WriteLine("Kitablarin Siyahisi: ");
                       
                    }
                }

            }
        }
    }
}
