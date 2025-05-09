namespace Klassen
{
    class Vector
    {
        int x;
        int y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine($"x={x}, y={y}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(1, 2);
            v.Print();
            Vector v2 = new Vector(3, 4);
            v2.Print();
        }
    }
}
