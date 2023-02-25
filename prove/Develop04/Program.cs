using System;

class Program
    {
        // Above and beyond code is shown in a new way to write a simple if/else
        // Console.Write(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
        // This code is used in the breathing exercise

        static void Main(string[] args)
        {
            Menu menu = new Menu();    
            menu.ShowMenu();
        }
    }