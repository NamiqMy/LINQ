using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqEx11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(66);
            numbers.Add(54);
            numbers.Add(48);
            numbers.Add(9);
            numbers.Add(23);
            numbers.Add(78);
            numbers.Add(96);
            numbers.Add(63);

            Console.WriteLine("There ara the numbers: ");
            Console.WriteLine("_________________________");

            foreach (int numb in numbers)
            {
                Console.WriteLine(numb + " ");
            }
            Console.WriteLine("Please write the number of record you want to display: \n");
            int num = Convert.ToInt32(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            Console.Write("\nThe top {0} records from the list are: \n", num);

            foreach (int numb in numbers.Take(num))
            {
                Console.WriteLine(numb);  
            }
            Console.ReadLine();
        }
    }
}