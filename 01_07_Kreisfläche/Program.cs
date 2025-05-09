namespace Kreisfläche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 12.0;
            double pi = 3.14159;
            double fläche = radius * radius * pi;
            Console.WriteLine($"Die Fläche eines Kreises mit Radius {radius} mm ist {fläche} mm^2.");
        }
    }
}
