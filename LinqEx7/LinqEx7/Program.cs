namespace LinqEx7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            Console.WriteLine("The numbers of an array are below: \n");
            Console.WriteLine("5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2");
            Console.WriteLine("______________________________________________");

            var number = from x in numbers
                         group x by x into y
                         select y;

            foreach (var numb in number)
            {
                Console.WriteLine(numb.Key + "\t" + numb.Sum() + "\t" + numb.Count());

            }
        }
    }
}