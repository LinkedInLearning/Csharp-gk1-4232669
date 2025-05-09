using System.Globalization;

namespace Indexer
{

    class Tage
    {
        string[] tage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };

        public string this[int i]
        {
            get => tage[i];
            set => tage[i] = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var tage = new Tage();
            Console.WriteLine(tage[0]);
            tage[0] = "Monday";
            Console.WriteLine(tage[0]);
        }
    }
}
