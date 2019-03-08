using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Shoes
    {
        //properties
        public string Size { get;  }
        public Brand Brand { get; }
        
        //fields

        //constructors
        public Shoes(string size, Brand brand)
        {
            Size = size;
            Brand = brand;
        }

        //methods
        public string BuyShoes()
        {
            return $"I need {Brand} shoes in size {Size}";
        }
        
    }


    internal enum Brand
    {
        Nike,
        Addidas,
        Vans,
        LouisVitton,
    }
}
