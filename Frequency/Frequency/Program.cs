using System;
using System.Globalization;

namespace Frequency
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 2, 5, 8, 10, 9, 1 };
            Console.WriteLine("The numbers in array are below: \n");
            Console.WriteLine("1, 2, 3, 4, 2, 5, 8, 10, 9, 1 \n");
            Console.WriteLine("________________________________");
            Console.WriteLine("");
            var number = from x in numbers
                         group x by x into y
                         select y;

            Console.WriteLine("The numbers and the frequencies are: \n");

            foreach (var numb in number)
            {
                Console.WriteLine("Number " + numb.Key + " appears " + numb.Count() + " times");
            }

            Console.ReadLine();
        }
    }
}