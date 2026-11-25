namespace Hoofdstuk_10._18
{
internal class Program
{
    static void Main(string[] args)
    {
        List<Klant> klanten = Klant.Initialiseer();

        foreach (Klant klant in klanten)
        {
            klant.ToonGegevens();
            Console.WriteLine();
        }
    }
}
}