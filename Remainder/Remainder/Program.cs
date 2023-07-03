namespace Remainder
{
    internal class Program
    {
        static void Main()
        {            
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };                  

            var number = numbers.Where(x => x % 2 == 0);                      

            Console.Write("\nAsagida gosterilen ededler 2-e bolunen zaman qaliq 0 alinir : \n");

            foreach (int numb in number)
            {
                Console.Write("{0} ", numb);
            }
            Console.Write("\n\n");
        }
    }
}