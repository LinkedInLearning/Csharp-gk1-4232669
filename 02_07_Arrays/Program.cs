namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];

            a[0] = 12;
            a[7] = 13;

            a = new[] { 1, 2, 3 };

            int[,] b;
            int[,,] c;

            b = new int[2, 3];

            int[][] d = new int[7][];  // jagged Array.
            d[0] = new int[6];
            d[1] = new int[9];


        }
    }
}
