using System;
using System.Collections.Generic;
using System.Linq;

namespace NegativeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums.RemoveAll(x => x < 0);
            if (nums.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();
                Console.WriteLine(string.Join(" ",nums));
            }
        }
    }
}
