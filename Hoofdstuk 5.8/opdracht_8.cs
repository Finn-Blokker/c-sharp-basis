namespace Hoofdstuk_5._8;

class opdracht_8
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the lucky word: ");
        string invoer = Console.ReadLine();

        invoer = invoer.ToUpper();

        string resultaat = (invoer == "LUCKY")
            ? $"Je typte {invoer} en dat is... Correct!"
            : $"Je typte {invoer} en dat is... Fout!";
        Console.WriteLine(resultaat);
    }
}