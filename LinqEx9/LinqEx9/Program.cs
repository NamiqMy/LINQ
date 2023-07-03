namespace LinqEx9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 40, 60, 80, 100, 120, 140 };

            Console.WriteLine("There are the numbers of an array are shown below: \n");
            Console.WriteLine("40, 60, 80, 100, 120, 140");
            Console.WriteLine("_________________________");

            var number = numbers.Where(x => x > 80);

            foreach (var numb in number)
            {
                Console.WriteLine(numb);
            }

            Console.ReadLine();
        }
    }
}