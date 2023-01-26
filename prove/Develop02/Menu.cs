using System;

class Menu {
    public List<string> _prompts = new List<string>();
    Journal journal = new Journal();

    public Menu() {
        _prompts.Add("What did you do today?");
        _prompts.Add("How are you feeling?");
    }

    public void Run() {
        while(true) {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\n");
            Console.Write("What would you like to do? # ");

            string option = Console.ReadLine();
            int optint;

            int.TryParse(option, out optint);

            switch(optint) {
                case 1:
                    Random r = new Random();
                    int promptIndex = r.Next(0,_prompts.Count()-1);
                    Console.WriteLine("Prompt: " + _prompts[promptIndex]);
                    
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(_prompts[promptIndex], response);
                    break;

                case 2:
                    journal.DisplayJournal();
                    break;

                case 3:
                    Console.Write("Enter a filename: ");
                    string filename = Console.ReadLine();
                    journal.Load(filename);
                    break;

                case 4:
                    Console.Write("Enter a filename: ");
                    filename = Console.ReadLine();
                    journal.Save(filename);
                    break;

                case 5:
                    Console.Write("Quitting...");
                    break;
                default:
                    return;
            }

        }
    }
}