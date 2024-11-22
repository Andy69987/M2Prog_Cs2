namespace Functions
{
    internal class Program
    {
        static void Main(string[] args) // De functie heet Main returntype: void
        {
            Program program = new Program(); // Hier wordt de constructor Program() gebruikt returntype: Program
            program.Run(); // De functie heet Run returntype: void
        }

        // Hier is me functie
        internal void Run() // De functie heet Run returntype: void
        {
            Console.WriteLine("Dit is nu de start van mijn programma"); // Geeft een boodschap weer
        }
    }
}
