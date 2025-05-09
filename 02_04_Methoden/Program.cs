namespace Klassen
{
    class Mitarbeiter
    {
        string vorname = "";
        string nachname = "";
        double gehalt;

        int Add(int a, int b)
        {
            return a + b;
        }

        public Mitarbeiter(string vorname, string nachname, double gehalt)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.gehalt = gehalt;
        }

        public void Print()
        {
            Console.WriteLine($"{vorname} {nachname}: {gehalt}");
        }

        void Foo()
        {
            // Tu etwas
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m1 = new Mitarbeiter("Mirko", "Matytschak", 50000);
            Mitarbeiter m2 = new Mitarbeiter("Hans", "Huber", 10000);
            m1.Print();
            m2.Print();
        }
    }
}
