using System;

namespace Open_Lab_03._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();     
            string b = Console.ReadLine();
            

            MatchCaseInsensitive mci = new MatchCaseInsensitive();

            Console.WriteLine(mci.Match(a.ToLower(), b.ToLower()));
        }
    }
}
