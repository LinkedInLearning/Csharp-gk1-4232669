namespace _02_04_Properties
{
    internal class Program
    {
        class Mitarbeiter
        {
            string vorname;
            public Mitarbeiter(string vorname, string nachname)
            {
                this.vorname = vorname;
                this.Nachname = nachname;
            }

            public string Name => $"{vorname} {Nachname}";

            public string Nachname { get; set; }
        }

        static void Main(string[] args)
        {
            Mitarbeiter m1 = new Mitarbeiter("Mirko", "Matytschak");
            Console.WriteLine(m1.Name);
//...
            m1.Nachname = "Müller";

            Console.WriteLine(m1.Name);

        }
    }
}
