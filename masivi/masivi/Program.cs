using System;
using System.Linq;

namespace masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(OptionsManager.CountLess100(arr));
            Console.WriteLine(OptionsManager.MaxNum(arr));
            OptionsManager.EvenNum(arr);
            Console.WriteLine(OptionsManager.SumEven(arr));
            Console.WriteLine(OptionsManager.CountEven(arr));
            OptionsManager.ReverseArr(arr);
        }
    }
}
