using System;

class Program {
    static void Main(string[] args)
    {
        Reference myreference = new Reference("John", 3, 16);
        Scripture myscripture = new Scripture(myreference, "For God so loved the world, that he gave his only begotten Son; that whosover believes in him should not perish but have eternal life.");
        Console.WriteLine("Memorize the following scripture:");
        myscripture.Display();
        while(!myscripture.IsCompletelyHidden()) {
            myscripture.HideWords();
            Console.Clear();
            Console.WriteLine("Memorize then press enter");
            myscripture.Display();
            Console.ReadLine();
        }
    }
    }
