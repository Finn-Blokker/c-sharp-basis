namespace Hoofdstuk_7._12;

class opdracht_12
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();  //maakt een nieuwe list
        for (int i = 1;
             i <= 5;
             i++)
        {
            Console.WriteLine($"naam {i}");
            string naam = Console.ReadLine();
            list.Add(naam);

        }
        String[] namen = list.ToArray();     //veranderd de list in een array

        Console.WriteLine("\nhier zijn alle namen: ");
        foreach (string naam in namen)       //print alle namen van de array uit
        {
            Console.WriteLine(naam);
        }
    }
}