using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_1_
{
    public class Workingwithmethod1
    {

        public static int[] Reverse(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int len = result.Length;
            for(int i = numbers.Length - 1; i >= 0; i--)
            {
                result[len -1 - i] = numbers[i];
            }

            return result;
        } 

        public static void PrintNumbers(int[] numbers)
        {
            foreach(int num in numbers)
            {
                Console.Write(num);
                Console.Write(",");
            }
        }

        public static int[] GenerateNumbers()
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            for(int i = 0; i < numbers.Length; i++)
            {
               
                int number = rand.Next(0, 100);
                numbers[i] = number;

            }

            return numbers;
        }

        //static void Main(string[] args)
        //{
        //    int[] numbers = GenerateNumbers();
        //    Console.WriteLine("before reverse");
        //    PrintNumbers(numbers);
        //    numbers = Reverse(numbers);
        //    Console.WriteLine("After reverse");
        //    PrintNumbers(numbers);
        //}
    }
}
