using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class question3
    {

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int index = 0;
            int ctr;
            int[] result = new int[endNum - startNum];
            for (int i = startNum; i <= endNum; i++)
            {
                ctr = 0;
                for (int j = 2; j < i/2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                       
                }
                if(ctr == 0 && i != 1)
                {
                    result[index] = i;
                    index++;
                }
               
            }

            return result;

        }

    }
}
