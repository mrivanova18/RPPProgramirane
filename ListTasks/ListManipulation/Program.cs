using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command=="print")
                {
                    break;
                }
                switch (command)
                {
                    case "add": var index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        Console.WriteLine(command);
                        break;
                    case "contains":
                        break;
                    case "remove":
                        break;
                    case "shift":
                        break;
                    case "sumPairs":
                        break;    
                        
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",nums));            
        }
    }
}
