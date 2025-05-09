namespace Operatoren1
{
    internal class Program
    {
        class Mitarbeiter
        {
            public string? Name { get; set; } = "Mirko Matytschak";

            public static Mitarbeiter? Create()
            {
                return new Mitarbeiter();
            }
        }

        static void Main(string[] args)
        {
            Mitarbeiter? m = Mitarbeiter.Create();
            
            var name = m?.Name?.ToString() ?? "Undefiniert";
            Console.WriteLine(name);
        }
    }
}
