using System.Text;

namespace Challenge_Solution
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
            // Achtung: GetHashCode erzeugt bei jedem Programmstart einen neuen Code.
            // Speichern Sie diese HashCodes nie ab.

            Console.WriteLine($"Der Hashcode von '{s}' ist {h}");

            var stringBytes = Encoding.UTF8.GetBytes(s);
            var hashBytes = GetBytes(h);

            var combined = new byte[stringBytes.Length + 4];

            hashBytes.CopyTo( combined, 0 );
            stringBytes.CopyTo( combined, 4 );

            ReadBytes( combined );
        }

        static void ReadBytes( byte[] combined )
        {
            var hashBytes = new Byte[4];
            var stringBytes = new Byte[combined.Length - 4];

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
