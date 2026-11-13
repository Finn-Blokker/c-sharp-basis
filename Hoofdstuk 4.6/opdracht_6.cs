using System.Runtime.InteropServices.JavaScript;

namespace Hoofdstuk_4._6;

class opdracht_6
{
    static void Main(string[] args)
    {
        string geboortejaar;
        int jaar;
        int leeftijd;
        
        Console.WriteLine("in welk jaar ben jij geboren?");
        geboortejaar = Console.ReadLine();

        jaar = DateTime.Now.Year;

        leeftijd = jaar - int.Parse(geboortejaar);
        
        Console.WriteLine($"Jij bent {leeftijd} jaar oud.");
    }
}