namespace OperatorReihenfolge
{

    class MyMath
    {
        int status = 0;
        public int f(int i) { status += i; return status; }
        public int g(int i) { status -= i; return status; }
        public int h(int i) { status *= i; return status; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var i = 12;
            var j = 10;
            int k = 9;

            int[] arr = new[] { 1, 2, 3 };

            int s = i + j * ++arr[1];

            int b = 1;
            int c = 2;
            int d = 3;
            var v = b & (c | d);
            MyMath myMath = new MyMath();

            var x = myMath.g(b) + myMath.f(c) + myMath.h(d);

            int e;
            int f;

            int g = e = f = b;

        }
    }
}
