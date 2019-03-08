using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var harryPotter = new Book("Harry Potter", "Fantasy");
            var blue = new Color("blue", "Primary");
            var green = new Color("green", "primary");
            var newCar = new Car("Toyota", CarType.Suv);
            var newShoes = new Shoes("11", Brand.Nike);

            Console.WriteLine(harryPotter.ToString());
            Console.WriteLine(blue.FavColor());
            Console.WriteLine(green.Paint());
            Console.WriteLine(newCar.Offer());
            Console.WriteLine(newCar.Rejection());
            Console.WriteLine(newShoes.BuyShoes());
            Console.ReadLine();
        }
    }
}
