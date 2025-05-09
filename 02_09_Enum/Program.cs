
namespace EnumBeispiel
{
    enum Bestellstatus
    {
        Offen,
        InBearbeitung,
        Versendet,
        Geliefert,
        Storniert
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bestellstatus b = Bestellstatus.InBearbeitung;

            switch (b)
            {
                case Bestellstatus.Offen:
                    Console.WriteLine("Bearbeite offen");
                    break;
                case Bestellstatus.InBearbeitung:
                    Console.WriteLine("In Bearbeitung");
                    break;
            }
        }
    }
}
