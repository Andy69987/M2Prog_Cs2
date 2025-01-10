using System;
using System.Collections.Generic;

namespace RemoveOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> characters = new List<string>
            {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
            };

            characters.Remove("Crash Bandicoot");

            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i]);
            }
        }
    }
}
