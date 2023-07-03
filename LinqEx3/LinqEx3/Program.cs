namespace LinqEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 4, 7, 8, 3, 11, 22 };

            Console.Write("\nFind the number and its square of an array which is more than 20 : ");
            Console.Write("\n------------------------------------------------------------------------\n");

            var sqNo = from int number in numbers
                       let SqrNo = number * number
                       select new { number, SqrNo };

            foreach (var numb in sqNo)  
                Console.WriteLine(numb);

            Console.ReadLine();
        }
    }
}