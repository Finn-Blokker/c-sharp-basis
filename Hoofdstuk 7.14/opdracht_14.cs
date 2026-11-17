namespace Hoofdstuk_7._14;

class opdracht_14
{
    static void Main(string[] args)
    {
        Console.WriteLine("maakt een array genaamd tabel.\n" +
                          "console.writeline(tabel[2, 1]); print 60 uit\n" +
                          "console.writeline(tabel[0 ,0]) + tabel[1, 1]); print 50 uit. 0, 0 is 10 en 1,1 is 40");
        int[,] tabel = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
        Console.WriteLine(tabel[2, 1]);
        Console.WriteLine(tabel[0, 0] + tabel[1, 1]);
    }
}