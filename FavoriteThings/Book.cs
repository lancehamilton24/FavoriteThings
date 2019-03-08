using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Book
    {
        //Properties
        public string BookName { get; }
        public string Genre { get; }

        //Fields
   
        //Constructor
        public Book(string name, string genre)
        {
            BookName = name;
            Genre = genre;
        }

        //Methods
        public string ToString()
        {
            return $"{BookName} is my favorite book and it is in the {Genre} genre";
        }
    }
}
