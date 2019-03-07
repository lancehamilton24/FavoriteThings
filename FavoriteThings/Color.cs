using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Color
    {
        //properties
        public string ColorName { get;  }
        public string ColorClass { get;  }

        //fields

        // constructors
        public Color(string colorname, string colorclass)
        {
            ColorName = colorname;
            ColorClass = colorclass;
        }

        //Methods
        public string FavColor()
        {
            return $"My favorite color is {ColorName} and it is a {ColorClass} color";
        }
    }
}
