namespace LinqEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chName = "codeacademy";
            Console.WriteLine("The frequency of each character of codeacademy are shown below: \n");
            var frequency = chName.GroupBy(x => x)
                .Select(x => new { Character = x.Key, Count = x.Count() });
            
            foreach ( var frequencyItem in frequency)
            {
                Console.WriteLine(frequencyItem);
            }
                
        }
    }
}