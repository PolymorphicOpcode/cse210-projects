using System;

class Program
{
    static void Main(string[] args)
    {
        var account = new Account();

        while(true) {
            Console.Write("Press 1 to deposit money, press 2 to print your balance, and any other key to exit: ");
            var input = Console.ReadLine() ?? "2";
            if (input == "1") {
                var amount = int.Parse(Console.ReadLine() ?? "");
                account.Deposit(amount);
            } else if (input == "2") {
                Console.WriteLine($"Balance: {account.GetBalance()}");
            } else {
                break;
            }
        }
    }
}