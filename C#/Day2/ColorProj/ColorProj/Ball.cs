using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorProj
{
    public class Ball
    {
        private int size;
        public int Size { get { return size; } set { size = value; } }

        private Color color;
        public Color Color {  get { return color; } set { color = value; } }

        private int timesThrown;
        public int TimesThrown { get { return timesThrown; } set { timesThrown = value; } }
        public Ball(int size, Color color, int timesThrown)
        {
            Size = size;
            Color = color;
            TimesThrown = timesThrown;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if(Size == 0)
            {
                TimesThrown += 1;
            }
            
        }


        public int times()
        {
            return TimesThrown;
        }

        //Color color = new Color(12, 13, 14);

     
    }
}
