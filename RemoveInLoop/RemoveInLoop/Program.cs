using System;
using System.Collections.Generic;

namespace RemoveInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>
            {
                "hond", "kat", "uil", "kraai", "hond", "papegaai", "hond"
            };

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] == "hond")
                {
                    animals.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i]);
            }
        }
    }
}
