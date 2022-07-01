using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_1_
{
    public class _2_Fibonacci
    {
        public static void Fib(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter fibonacci sequence length");
            int len = int.Parse(Console.ReadLine());
            Fib(len);
        }
    }
}
