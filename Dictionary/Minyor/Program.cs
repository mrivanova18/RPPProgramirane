using System;
using System.Linq;
using System.Collections.Generic;

namespace Minyor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var resources = Console.ReadLine();           
            while (resources!="stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(resources))
                {
                    dict[resources] += quantity;
                }
                else
                {
                    dict.Add(resources, quantity);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            }
            
        }
    }
}
