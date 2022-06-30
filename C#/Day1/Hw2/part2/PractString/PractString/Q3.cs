using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Q3
{

    public static bool Pal(string str)
    {
        int end = str.Length - 1;

        for (int i = 0, j = end; i < end; i++, j--)
        {
            char frontLetter = str[i];  //Char.ToLower(str[i]);
            char endLetter = str[j];    //Char.ToLower(str[i]);

            if (frontLetter != endLetter) return false;
        }
        return true;
    }

}

