using System;

class Program {
    static void Main(string[] args) {
        Console.Write("What is your first name? ");
        // Could use string? for ambiguous whether variable exists
        string FirstName = Console.ReadLine() ?? "";

        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine() ?? "";

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}