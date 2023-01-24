using System;

class Menu {
    public List<string> _prompts = new List<string>();

    public Menu() {
        _prompts.Add("What did you do today?");
        _prompts.Add("How are you feeling?");
    }

    public void Run() {
        while(true) {
            Console.Write("What would you like to do? # ");
            string option = Console.ReadLine();
            int optint;

            int.TryParse(option, out optint);

            switch(optint) {
                case 1:
                    Console.WriteLine("test");
                    break;
                case 2:
                    Console.WriteLine("test2");
                    break;
                default:
                    break;
            }

            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            Random r = new Random();
            Console.WriteLine(_prompts[r.Next(0,_prompts.Count()-1)]);
        }
    }
}