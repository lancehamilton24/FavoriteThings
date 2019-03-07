using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var favBook = new Book("Harry Potter", "Fantasy");

            var openBook = new Book(4);

            Console.WriteLine(favBook.ToString());
            Console.ReadLine();
        }
    }
}
