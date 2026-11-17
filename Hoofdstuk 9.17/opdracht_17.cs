namespace Hoofdstuk_9._17;

class opdracht_17
{
    static void Main(string[] args)
    {
        string[] namen = {"Abel", "Bram", "Cornelius", "Daniel", "Eduard", "Finn", "Geert", "Hugo", "Ivan", "joost", "Kalvijn" }; //11 namen
        Console.WriteLine("Voer een geheel getal in:");
        string invoer = Console.ReadLine();
        
        try
        {
            int waarde = int.Parse(invoer);
            if (0 < waarde && waarde < 12)
                for (int i = 0;
                     i <= waarde -1;)
                {
                    Console.WriteLine(namen[i]);
                    i++;
                }
            else
            {
                {
                    Console.WriteLine("voer een geheel positief getal onder de 11 in");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Dat is geen geldig getal.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Dat getal is te groot of te klein.");
        }
        catch (Exception)
        {
            Console.WriteLine("Er ging iets anders mis.");
        }
        Console.ReadLine();
    }
}