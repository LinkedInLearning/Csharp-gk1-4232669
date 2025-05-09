using System;
using System.IO;

namespace Dateiausgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("Test.txt"))
            {
                sw.WriteLine("Hello, World!");
            }            
        }
    }
}
