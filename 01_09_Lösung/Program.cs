using System.Text;

namespace Kreisfläche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            using (StreamWriter sw = new StreamWriter("Challenge01.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Radius;Fläche");

                double radius = 5;
                double fläche = radius * radius * pi;
                sw.WriteLine($"{radius};{fläche}");

                radius = 10;
                fläche = radius * radius * pi;
                sw.WriteLine($"{radius};{fläche}");

                radius = 15;
                fläche = radius * radius * pi;
                sw.WriteLine($"{radius};{fläche}");
            }
        }
    }
}
