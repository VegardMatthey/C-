using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    
    public class Color
    {

        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = red;  // [0..255]
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public int Red {get ; set;}
        public int Green {get ; set;}
        public int Blue {get ; set;}
        public int Alpha {get ; set;}

        public int GetGrayScale(int grayScale)
        {
            return (Red + Green + Blue) / 3;
        }



    }


}
