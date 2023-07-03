namespace LinqEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satruday", "Sunday" };

            var day = from weekday in weekdays
                      select weekday;

            Console.WriteLine("There ara days of the Week: \n");

            foreach (var weekday in weekdays)
            {
                Console.WriteLine(weekday);

            }
            Console.ReadLine();
        }
    }
}