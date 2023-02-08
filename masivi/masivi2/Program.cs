using System;
using System.Linq;

namespace masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var method = Console.ReadLine();
                if (method=="Distinct")
                {
                    OptionsManager2.Distinct(words);
                }
                else if (method=="Reverse")
                {
                    OptionsManager2.ReverseArr(words);
                }
                else if (method=="Print t")
                {
                    OptionsManager2.Print(words);
                }
            }
        }
    }
}
