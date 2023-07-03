namespace LinqEx13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new string[4];
            
            words[0] = "My";
            words[1] = "name";
            words[2] = "is";
            words[3] = "Namiq";
            
            string res = string.Join(',',words);
            Console.WriteLine(res);
        }
    }
}