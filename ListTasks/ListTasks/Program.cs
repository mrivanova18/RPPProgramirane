using System;
using System.Collections.Generic;
using System.Linq;

namespace ListTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

        }
    }
}
