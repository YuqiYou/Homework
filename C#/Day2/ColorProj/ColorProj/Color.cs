using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorProj
{
    public class Color
    {
        private int red;
        public int Red { get { return red; } set { red = value; } }

        private int green;
        public int Green { get { return green; } set { green = value; } }

        private int blue;
        public int Blue { get { return blue; } set { blue = value; } }
        

        private int alpha;
        public int Alpha { get { return alpha; } set { alpha = value; } }



        public Color(int red, int green, int blue, int alpha  = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public int getGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
