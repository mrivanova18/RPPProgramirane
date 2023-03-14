using System;
using System.Linq;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            var input = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                var word = input[i].ToLower();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word]++;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            }
        }
    }
}
