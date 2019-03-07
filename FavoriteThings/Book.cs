using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Book
    {
        //Properties
        public string Name { get; }
        public string Genre { get; }

        //Fields
   
        //Constructor
        public Book(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        //Methods
        public override string ToString()
        {
            return $"{Name} is my favorite book and it is in the {Genre} genre";
        }
    }
}
