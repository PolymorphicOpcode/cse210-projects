using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        bool guessed = false;
        while (!guessed) {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine() ?? "";
            int randomuser;
            int.TryParse(input, out randomuser);
            if (randomuser == number) {
                Console.WriteLine("Nice! You got it!");
                guessed = true;
                }
            else if (randomuser > number) {
                Console.WriteLine("Lower");
            }
            else if (randomuser < number) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("Error");
            }
        }
    }
}