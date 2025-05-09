namespace Nullable
{
    class TestClass
    {
        int? x;
        string? s;

        public void Foo()
        {
            if (x != null)
                Console.WriteLine(x.ToString());
            else
                Console.WriteLine("x hat keinen Wert");
            if (s != null)
                Console.WriteLine(s.ToString());
            else
                Console.WriteLine("s hat keinen Wert");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var tc = new TestClass();
            tc.Foo();
        }
    }
}
