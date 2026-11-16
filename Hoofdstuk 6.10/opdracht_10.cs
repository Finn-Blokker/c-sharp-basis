namespace Hoofdstuk_6._10;

class opdracht_10
{
    static void Main(string[] args)
    {
        for (int getal = 1;
        getal <= 10; getal++)
        {
            if (getal == 4)
            {
                continue;
            }
            if (getal != 4)
            {
                Console.WriteLine($"{getal}");
            }
             
        }
    }
}