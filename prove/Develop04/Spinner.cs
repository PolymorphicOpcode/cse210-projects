public class Spinner {
        public static void Spin(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
            }
            Console.WriteLine();
        }
}