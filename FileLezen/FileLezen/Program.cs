using System;
using System.IO;

class Program
{
    static void Main()
    {
        string bestandspad = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nos_artikel.txt");


        try
        {
            string inhoud = File.ReadAllText(bestandspad);
            Console.WriteLine("Inhoud van het NOS-artikel:");
            Console.WriteLine("----------------------------");
            Console.WriteLine(inhoud);
        }
        catch (Exception e)
        {
            Console.WriteLine("Er is een fout opgetreden bij het lezen van het bestand:");
            Console.WriteLine(e.Message);
        }
    }
}
