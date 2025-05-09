namespace Exceptions
{
    class MessageHandler
    {
        List<string> messages = new();

        public void WriteLine(string message)
        {
            messages.Add(message);
        }

        public void ToFile(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                foreach (var message in messages)
                {
                    sw.Write($"{DateTime.Now}: ");
                    sw.WriteLine(message);
                }
            }
        }
    }

    internal class Program
    {
        static int GetAValue()
        {
            bool b = true;
            if (!b)
                throw new Exception("In GetAValue läuft's nicht gut");

            return 55;
        }

        static void Main(string[] args)
        {
            try
            {
                int x = 222 / GetAValue();

                MessageHandler handler = new MessageHandler();
                handler.WriteLine("Hallo");
                handler.ToFile("C:\\lkjkjkjkjkj\\kljkjkj.txt");
            }
            catch (Exception ex)
            {
                // Logging -> E-Mail
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
