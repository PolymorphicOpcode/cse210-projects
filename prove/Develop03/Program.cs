using System;

class Program {
    
    private string _useropt;
    
    static void Main(string[] args)
    {
        Reference myreference = new Reference("John", 3, 16);
        Scripture myscripture = new Scripture(myreference, "For God so loved the world, that he gave his only begotten Son; that whosover believes in him should not perish but have eternal life.");
        Console.WriteLine("Memorize then press enter");
        myscripture.Display();
        _useropt = Console.ReadLine();
        
        while(!myscripture.IsCompletelyHidden() && useropt != "quit") {
            myscripture.HideWords();
            Console.Clear();
            Console.WriteLine("Memorize then press enter");
            myscripture.Display();
            _useropt = Console.ReadLine();
        }
    }
    }
