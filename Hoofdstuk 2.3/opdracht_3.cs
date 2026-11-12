internal class Program
{
    static void Main(string[] args)
    {
        string invoer = "42";                               // 42 wordt als string genaamd invoer verklaard
        int getal = int.Parse(invoer);                      // 42 wordt vernaderd naar een int genaamd `getal`
        int resultaat = getal * 2;                          // getal wordt x2 gedaan en is nu een int genaamd resultaat
        Console.WriteLine("Het dubbele is: " + resultaat);  // de tekst "Het dubbele is: 84" wordt geprint
        Console.ReadLine();                                 // de tekst wordt in het programma geschreven
    }
}