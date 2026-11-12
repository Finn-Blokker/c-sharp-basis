namespace Hoofdstuk_4._5;

class Program
{
    static void Main(string[] args)
    {
        string hoogte;
        string breedte;
        double resultaat;
        string resultaat_string;

        Console.WriteLine("Welkom bij de lengte berekenaar");

        Console.WriteLine("breedte: ");
        breedte = Console.ReadLine();

        Console.WriteLine("hoogte: ");
        hoogte = Console.ReadLine();

        resultaat = double.Parse(hoogte) * double.Parse(breedte);
        resultaat_string = string.Format("{0:F2}", resultaat);  //reader klopt niet

        Console.WriteLine($"De oppervlakte is {resultaat_string} !");
        Console.ReadLine();
    }
}