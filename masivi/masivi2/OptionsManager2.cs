using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi2
{
    public static class OptionsManager2
    {
        public static string[] ReverseArr(string[] words)
        {
            var result = words.Reverse().ToArray();
            return result;
            //Console.WriteLine(string.Join(", ", result));
        }
        public static string[] Distinct(string[] words)
        {
            var result = words.Distinct().ToArray();
            return result;
            
        }
        public static void Replace(string[] words, int index, string newWord)
        {
            words[index] = newWord;
        }
        public static void Print(string[] words, string symbol)
        {
            Console.WriteLine(string.Join(" ",words.Where(x => x.StartsWith(symbol))));
        }
    }
}
