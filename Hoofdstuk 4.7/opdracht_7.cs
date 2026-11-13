namespace Hoofdstuk_4._7;

class opdracht_7
{
    static void Main(string[] args)
    {
        double input;
        
        ConsoleKeyInfo toets = Console.ReadKey();
        Console.WriteLine();
        
        input = char.GetNumericValue(toets.KeyChar);
        
        if (input == 5)
        {
            Console.WriteLine("Correct! Mijn geluksgetal is 5!");
            Console.ReadLine();
        }   
        if (input == -1)
        {
            Console.WriteLine($"{toets.Key} is niet juist. Voer een cijfer in");
            Console.ReadLine();
        }
        if (5 < input && input > 5)
        {
            Console.WriteLine($"{input} is niet juist!");
            Console.ReadLine();
        }
        
    }
}