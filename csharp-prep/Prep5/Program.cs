using System;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUsername() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? "";
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int numberInt;
        int.TryParse(favoriteNumber, out numberInt);
        return numberInt;
    }

    static int SquareNumber(int num) {
        return (num * num);
    }
    
    static void DisplayResult(string username, int number) {
        Console.WriteLine($"{username}, the square of your number is {number}");
    }

    static void Main(string[] args) {
        DisplayWelcome();
        string user = PromptUsername();
        int number = PromptUserNumber();
        DisplayResult(user, SquareNumber(number));
    }
}