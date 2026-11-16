namespace Hoofdstuk_6._11;

class opdracht_11
{
    static void Main(string[] args)
    {
        Boolean run = true;
        Console.WriteLine("1 voor menu 1 \n2 voor menu 2 \n3 om het programma af te sluiten");
        while (run == true)
        {
            double input;
            ConsoleKeyInfo toets = Console.ReadKey();
            Console.WriteLine();
            input = char.GetNumericValue(toets.KeyChar);
            switch (input)
            {
                case 1:
                    Console.WriteLine("Menu 1");
                    break;
                case 2:
                    Console.WriteLine("Menu 2");
                    break;
                case 3:
                    run = false;
                    break;
                default:
                    Console.WriteLine("ongeldige keuze. Voer 1, 2 of 3 in");
                    break;
            }
        }
    }
}