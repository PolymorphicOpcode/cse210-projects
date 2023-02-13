using System;

class Program {
    
    // This program exceeds the requirements by not only fulfilling them, but being optimized code. I asked an AI to improve it, so I learned how string
    // constructors worked, and how the random function works.
    public static string userOpt = "";

    static void Main(string[] args)
    {
        Reference myreference = new Reference("John", 3, 16);
        Scripture myscripture = new Scripture(myreference, "For God so loved the world, that he gave his only begotten Son; that whosover believes in him should not perish but have eternal life.");
        Console.WriteLine("Memorize then press enter");
        myscripture.Display();
        userOpt = Console.ReadLine() ?? "";
        
        while(!myscripture.IsCompletelyHidden() && userOpt != "quit") {
            myscripture.HideWords();
            Console.Clear();
            Console.WriteLine("Memorize then press enter");
            myscripture.Display();
            userOpt = Console.ReadLine() ?? "";
        }
    }
    }
