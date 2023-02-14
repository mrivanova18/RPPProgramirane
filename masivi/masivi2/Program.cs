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
                var input = Console.ReadLine().Split().ToArray();
                var method = words[0];
                if (method=="Distinct")
                {
                    words = OptionsManager2.Distinct(words);
                }
                else if (method=="Reverse")
                {
                    words = OptionsManager2.ReverseArr(words);
                }
                else if (method=="Print")
                {
                    OptionsManager2.Print(words,input[1]);
                }
                else if (method=="Replace")
                {

                    OptionsManager2.Replace(words,int.Parse(input[1]),input[2]);
                }
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
