namespace LinqEx10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int members, n, m;
            List<int> templist = new List<int>();
            Console.Write("Accept the members of a list and display the members more than a specific value : ");
            Console.Write("\n----------------------------------------------------------------------------------------\n");

            Console.Write("Input the number of members on the List : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Member {0} : ", i);
                members = Convert.ToInt32(Console.ReadLine());
                templist.Add(members);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            m = Convert.ToInt32(Console.ReadLine());

            List<int> member = templist.FindAll(x => x > m ? true : false);
            Console.WriteLine("The numbers greater than {0} are : ", m);
            foreach (var num in member)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}