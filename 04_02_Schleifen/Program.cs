using System.Collections;

namespace Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            //for (int j = 0; j < arr.Length; j++)
            //{
            //    if (j > 5)
            //        break;
            //    Console.WriteLine(arr[j]);
            //}

            //int j = 0;
            //while (j < arr.Length)
            //{
            //    Console.WriteLine(arr[j]);
            //    j++;
            //}

            //int j = 0;
            //do
            //{
            //    Console.WriteLine(arr[j]);
            //    j++;
            //} while (j < arr.Length);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine(arr is IEnumerable);
        }
    }
}
