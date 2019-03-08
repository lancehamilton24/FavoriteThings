using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Car
    {
        //Properties
        public string Make { get;  }
        public CarType CarType { get; }

        //fields 

        //constructors
        public Car(string make, CarType cartype)
        {
            Make = make;
            CarType = cartype; 
        }

        //methods
        public string Offer()
        {
            return $"I want a {CarType} made by {Make}";
        }
        public string Rejection()
        {
            return $"I don't want your {Make}";
        }
    }

    internal enum CarType
    {
        Suv,
        Coupe,
        Hatchback,
        Truck,
        Semitruck,
    }
}
