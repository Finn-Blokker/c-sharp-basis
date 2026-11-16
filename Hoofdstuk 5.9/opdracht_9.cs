namespace Hoofdstuk_5._9;

class opdracht_9
{
    static void Main(string[] args)
    {
        Console.WriteLine("kies 1/small, 2/medium, of 3/large: ");
        string keuze = Console.ReadLine();
        keuze = keuze.ToLower();

        switch (keuze)
        {
            case "1" or "small":
                Console.WriteLine("€ 2,00");
                break;
            case "2" or "medium":
                Console.WriteLine("€ 2,50");
                break;
            case "3" or "large":
                Console.WriteLine("€ 3,00");
                break;
            default:
                Console.WriteLine("ongeldige keuze");
                break;
        }
        Console.ReadLine();
    }
}