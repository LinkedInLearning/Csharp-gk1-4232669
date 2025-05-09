using System.Text;

namespace Challenge
{
    internal class Program
    {
        static byte[] GetBytes(int i)
        {
            return BitConverter.GetBytes( i );
        }
        static int GetInt( byte[] bytes)
        {
            return BitConverter.ToInt32( bytes );
        }


        static void Main(string[] args)
        {
            var s = "Dies ist ein String.";
            var h = s.GetHashCode();

            Console.WriteLine($"Der Hashcode von '{s}' ist {h}");

            var stringBytes = Encoding.UTF8.GetBytes(s);
            var hashBytes = GetBytes(h);

            var combined = ??

            ReadBytes( combined );
        }

        static void ReadBytes( byte[] combined )
        {
            var hashBytes = new byte[4];
            var stringBytes = new byte[combined.Length - 4];

            int i;
            for (i = 0; i < 4; i++)
                hashBytes[i] = combined[i];

            int j = 0;

            for (; i < combined.Length; i++)
                stringBytes[j++] = combined[i];

            var s = Encoding.UTF8.GetString(stringBytes);
            var h = GetInt(hashBytes);

            Console.WriteLine( $"Der Hashcode von '{s}' ist {h}" );
        }
    }
}
