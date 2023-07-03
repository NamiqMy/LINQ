namespace PositiveNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, -5, 6, -7, 8, 9, -10, 11 };



            var number =
            from num in numbers
            where num > 0
            where num < 12
            select num;



            Console.Write("\nMusbet edeler asagidakilardir: \n");
            foreach (var numb in number)
            {
                Console.Write("{0}  ", numb);
            }
            Console.WriteLine("\n\n");
        }
    }
}