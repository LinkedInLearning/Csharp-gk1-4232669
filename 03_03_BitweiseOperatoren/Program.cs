namespace BitweiseOperatoren
{
    internal class Program
    {
        class Mitarbeiter
        {
        }

        static void Main(string[] args)
        {
            int i = 10;
            var m = new Mitarbeiter();
            int[] x = new int[5];
            Console.WriteLine(i is Mitarbeiter);
            Console.WriteLine(m is Mitarbeiter);
        }
    }
}
