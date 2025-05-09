namespace KonversionZahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            float f = x;
            Console.WriteLine(x);
            //Console.WriteLine(f);

            long x2 = long.MaxValue;
            Console.WriteLine(x2);

            x = (uint)x2;
            Console.WriteLine(x);
        }
    }
}
