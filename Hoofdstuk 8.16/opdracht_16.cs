namespace Hoofdstuk_8._16;

class Opdracht16
{
    static void Main(string[] args)
    {
        float result;
        int uitvoer = 0;
        int[,] tabel = { };
        List<string> list = new List<string>();
        for (int i = 1;
             i <= 2;)
        {
            Console.WriteLine($"getal {i}:");
            string invoer = Console.ReadLine();
            bool isgetal = Single.TryParse(invoer, out result);
            if (isgetal)
            {
                string getal = result.ToString();
                list.Add(getal);
                i++;
            }
            else if (!isgetal)
            {
                Console.WriteLine("dit is geen getal");
            }
        }

        String[] getallen = list.ToArray();
        float getal1 = float.Parse(getallen[0]);
        float getal2 = float.Parse(getallen[1]);

        Console.WriteLine("1 - optellen\n2 - aftrekken\n3 - vermenigvuldigen\n4 - delen");
        string keuze = Console.ReadLine();

        switch (keuze)
        {
            case "1":
                Optellen plusnummer = new Optellen();
                plusnummer.Teller(getal1, getal2);
                break;
            case "2":
                Aftrekken minnummer = new Aftrekken();
                minnummer.Teller(getal1, getal2);
                break;
            case "3":
                Vermenigvuldigen keernummer = new Vermenigvuldigen();
                keernummer.Teller(getal1, getal2);
                break;
            case "4":
                Delen deelnummer = new Delen();
                deelnummer.Teller(getal1, getal2);
                break;
        }
    }
}

class Optellen
{
    public void Teller(float getal1, float getal2)
    {
        Console.WriteLine(getal1 + getal2);
    }
}

class Aftrekken
{
    public void Teller(float getal1, float getal2)
    {
        Console.WriteLine(getal1 - getal2);
    }
}

class Vermenigvuldigen
{
    public void Teller(float getal1, float getal2)
    {
        Console.WriteLine(getal1 * getal2);
    }
}

class Delen
{
    public void Teller(float getal1, float getal2)
    {
        Console.WriteLine(getal1 / getal2);
    }
}