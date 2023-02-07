using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi2
{
    public static class OptionsManager2
    {
        public static void ReverseArr(string[] words)
        {
            var result = words.Reverse().ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
        public static void Distinct(string[] words)
        {
            var result = words.Distinct();
            
        }
        public static void Replace(string[] words,string word)
        {
            
        }
    }
}
