using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade as a percentage: ");
        string Grade = Console.ReadLine();
        int GradeAsInt = int.Parse(Grade);
        char LetterGrade = ' ';
        bool Passed = true;
        if (GradeAsInt >= 90) {
            LetterGrade = 'A';
        }
        else if (GradeAsInt >= 80) {
            LetterGrade = 'B';
        }
        else if (GradeAsInt >= 70) {
            LetterGrade = 'C';
        }
        else if (GradeAsInt >= 60) {
            LetterGrade = 'D';
        }
        else if (GradeAsInt < 60) {
            LetterGrade = 'F';
            Passed = false;
        }
        else {
            Console.WriteLine("An error has occured.");
            Passed = false;
        }
        if (Passed) {
            Console.WriteLine("Congratulations! You Passed.");
        }
        else {
            Console.WriteLine("Better luck next time. Tutoring hours are 5pm-7pm");
        }
        Console.WriteLine($"Your grade as a letter is {LetterGrade}");
    }
}