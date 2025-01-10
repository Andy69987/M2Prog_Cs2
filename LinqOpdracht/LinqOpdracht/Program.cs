using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace"
            };

            var namesStartingWithA = names.Where(name => name.StartsWith("A"));
            var sortedNames = names.OrderBy(name => name);
            var nameLengths = names.Select(name => name.Length);

            Console.WriteLine("Names starting with A:");
            foreach (var name in namesStartingWithA)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nSorted names:");
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nName lengths:");
            foreach (var length in nameLengths)
            {
                Console.WriteLine(length);
            }
        }
    }
}
