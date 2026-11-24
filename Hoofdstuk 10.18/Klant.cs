namespace Hoofdstuk_10._18
{
    internal class Klant
    {
        private int id;
        private string naam;
        private int telefoonnummer;

        public Klant(int id, string naam, int telefoonnummer)
        {
            this.id = id;
            this.naam = naam;
            this.telefoonnummer = telefoonnummer;
        }

        public static List<Klant> Initialiseer()
        {
            List<Klant> klanten = new List<Klant>();
            klanten.Add(new Klant(1, "Marijke", 612345678));
            klanten.Add(new Klant(2, "Jan", 612345677));
            klanten.Add(new Klant(3, "Tim", 612345666));
            klanten.Add(new Klant(4, "Matt", 612345555));
            klanten.Add(new Klant(5, "Jeff", 612344444));

            return klanten;
        }

        public void ToonGegevens()
        {
            Console.WriteLine($"Klant ID: {id}");
            Console.WriteLine($"Naam: {naam}");
            Console.WriteLine($"Telefoonnummer: {telefoonnummer}");
        }
    }
}