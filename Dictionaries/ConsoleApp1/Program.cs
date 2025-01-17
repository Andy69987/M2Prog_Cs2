using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        Dictionary<int, string> mijnDictionary = new Dictionary<int, string>();

        mijnDictionary.Add(1, "Jan");
        mijnDictionary.Add(2, "Piet");
        mijnDictionary.Add(3, "Klaas");

        string naam1 = mijnDictionary[1];
        string naam2 = mijnDictionary[2];
        Console.WriteLine(naam1);
        Console.WriteLine(naam2);

        Console.WriteLine("Itereren over de dictionary:");
        foreach (var item in mijnDictionary)
        {
            Console.WriteLine($"Sleutel: {item.Key}, Waarde: {item.Value}");
        }

        var sleutels = mijnDictionary.Keys;
        Console.WriteLine("Alle sleutels:");
        foreach (var sleutel in sleutels)
        {
            Console.WriteLine(sleutel);
        }

        var waarden = mijnDictionary.Values;
        Console.WriteLine("Alle waarden:");
        foreach (var waarde in waarden)
        {
            Console.WriteLine(waarde);
        }
    }
}
