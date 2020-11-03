using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Color
    {

        int red = 60;
        int green = 20;
        int blue = 40;
        int alpha = 255;

        private Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public int GetColor()
        {
            return red;
        }

        public void SetColor(int red)
        {
            this.red = red;
        }




        static void Main(string[] args)
        {
                   
        }





   }


}
