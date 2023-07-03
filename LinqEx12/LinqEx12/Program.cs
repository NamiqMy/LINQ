using System.Text.RegularExpressions;

namespace LinqEx12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("There you can find uppercase words in a string : ");
            Console.Write("\n----------------------------------------------\n");

            string upword;

            Console.Write("Input the string : \n");
            upword = Console.ReadLine();

            var ucWord = WordFilt(upword);
            Console.Write("\nThe UPPER CASE words are :\n ");
            foreach (string strRet in ucWord)
            {
                Console.WriteLine(strRet);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal));

            return upWord;


        }
    }
}