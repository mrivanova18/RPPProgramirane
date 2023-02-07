using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi
{
    public static class OptionsManager
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }
        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        public static void EvenNum(int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
        public static int SumEven(int[] arr)
        {
            return arr.Where(x=>x%2==0).Sum();
        }
        public static int CountEven(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).Count();
        }
        public static void ReverseArr(int[] arr)
        {
            var result = arr.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", result));
        }

        public static void PrintArr(int[] arr)
        {
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
