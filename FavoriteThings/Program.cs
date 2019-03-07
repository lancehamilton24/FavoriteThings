using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var harryPotter = new Book("Harry Potter", "Fantasy");
            var green = new Color("blue", "Primary");

            Console.WriteLine(harryPotter.ToString());
            Console.WriteLine(green.FavColor());
            Console.ReadLine();
        }
    }
}
