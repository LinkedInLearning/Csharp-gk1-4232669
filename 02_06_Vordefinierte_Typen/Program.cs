namespace _02_06_Vordefinierte_Typen
{
    internal class Program
    {
        int x = 5;
        static void Main(string[] args)
        {
            //checked
            //{
                var x = int.MaxValue;
                x = x + 1;
                Console.WriteLine(x);
            //}
        }
    }
}
