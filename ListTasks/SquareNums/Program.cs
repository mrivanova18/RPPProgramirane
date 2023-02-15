using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNums
{
    class Program
    {       
        static void Main(string[] args)
        {          
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                List<int> result = new List<int>();
                nums.Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x));
                result.Add(nums[i]);
                Console.WriteLine(string.Join(" ", result));
            }
            /*int num = int.Parse(Console.ReadLine());
            if (Math.Sqrt(num) == (int)Math.Sqrt(num))
            {
                nums.Add(num);
                List<int> result = new List<int>();
                result.Add(num);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                nums.Add(num);
            }*/                                      
        }        
    }
}
