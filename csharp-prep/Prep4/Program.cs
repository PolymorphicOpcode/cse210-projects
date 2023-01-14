using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numList = new List<int>();

        while (true) {
            Console.Write("Enter a number: ");

            string input = Console.ReadLine() ?? "";
            int numToAppend;
            int.TryParse(input, out numToAppend);

            if (numToAppend == 0) {break;}

            numList.Add(numToAppend);

            //List<int> numbers = new List<int> {1,2,3};

            }

        float sum = numList.Sum();
        float average = sum/numList.Count;         
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numList.Max()}");
    }
}