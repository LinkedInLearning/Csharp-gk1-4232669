
namespace EnumBeispiel
{
    enum Bestellstatus
    {
        Offen = 1,
        InBearbeitung = 2,
        Versendet = 4,
        Geliefert = 8,
        Storniert = 16,
        PreVersand = Offen | InBearbeitung
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bestellstatus b = Bestellstatus.Geliefert;
            if ((b & Bestellstatus.PreVersand) != 0)
                Console.WriteLine("PreVersand");
            else
                Console.WriteLine("PostVersand");
        }
    }
}
