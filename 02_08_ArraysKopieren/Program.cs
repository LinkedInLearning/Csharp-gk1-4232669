namespace ArraysKopieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //var arr2 = (int[])arr1.Clone();

            //for( int i = 0; i < arr2.Length ; i++ )
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            arr1.CopyTo(arr2, 5);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
