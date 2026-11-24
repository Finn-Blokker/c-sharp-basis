namespace Hoofdstuk_10._18;

class Auto
{
    private int id;
    public string merk;
    double prijs; // standaard private, ook zonder het woord "private"

    public void ToonMerk()
    {
        Console.WriteLine("Merk: " + merk);
    }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}

