using System;
using System.Collections.Generic;
using System.Linq;

namespace ListMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            List<string> input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Reverse();
            for (int i = 0; i < input.Count; i++)
            {
                int[] nums = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < nums.Length; j++)
                {
                    result.Add(nums[j]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
