namespace Klassen
{
    class Mitarbeiter
    {
        string vorname = "";
        string nachname = "";
        static double gehalt;

        public void Initialize(string vorname, string nachname, double gehalt)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            Mitarbeiter.gehalt = gehalt;
        }

        public void Print()
        {
            Console.WriteLine($"{vorname} {nachname}: {gehalt}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m1 = new Mitarbeiter();
            m1.Initialize("Mirko", "Matytschak", 50000);
            Mitarbeiter m2 = new Mitarbeiter();
            m2.Initialize("Hans", "Huber", 10000);
            m1.Print();
            m2.Print();
        }
    }
}
