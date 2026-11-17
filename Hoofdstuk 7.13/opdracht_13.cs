namespace Hoofdstuk_7._13;

class opdracht_13
{
    static void Main(string[] args)
    {
        int result;
        List<string> list = new List<string>();  //maakt een nieuwe list
        for (int i = 1;
             i <= 5;)
        {
            Console.WriteLine($"getal {i}:");
            string invoer = Console.ReadLine();
            bool getal = int.TryParse(invoer, out result);
            if (getal)
            {
                Console.WriteLine("dit is een getal");
                string isgetal = invoer.ToString();
                list.Add(isgetal);
                i++;
            }
            else if (!getal)
            {
                Console.WriteLine("dit is geen getal");
            }
        }
        
        String[] getallen = list.ToArray();     //veranderd de list in een array

        Console.WriteLine("\nhier zijn alle getallen: ");
        foreach (string nummers in getallen)       //print alle namen van de array uit
        {
            Console.WriteLine(nummers);
        }
    }
}