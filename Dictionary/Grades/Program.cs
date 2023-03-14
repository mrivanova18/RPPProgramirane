using System;
using System.Linq;
using System.Collections.Generic;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                if (name.ToLower()=="finish")
                {
                    break;
                }
                double grade = double.Parse(input[1]);
                if (dic.ContainsKey(name))
                {
                    dic[name].Add(grade);
                }
                else
                {
                    dic.Add(name, new List<double>());
                    dic[name].Add(grade);
                }
            }            
            foreach (var item in dic.OrderByDescending(x => x.Value.Average()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} : {string.Join("->",item.Value)} Average grade:{item.Value.Average():f2}");
            }
        }
    }
}
