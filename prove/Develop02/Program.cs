using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Entry entry1 = new Entry();
        entry1._uid = "1";
        entry1._prompt = "Testing";
        entry1._content = "Testing";
        entry1._timestamp = "Test";

        entry1.Display(entry1._uid, entry1._timestamp, entry1._content, entry1._prompt);

        Menu menu = new Menu();
        menu.Run();
    }
}