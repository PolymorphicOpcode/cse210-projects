using System;

class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();    
            menu.ShowMenu();
        }
    }
    public class Spinner
    {
        public static void Spin(int seconds)
        {
            int delay = 100;
            for (int i = 0; i < seconds * 1000 / delay; i++)
            {
                Console.Write("\\");
                Console.Write("\b|");
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }