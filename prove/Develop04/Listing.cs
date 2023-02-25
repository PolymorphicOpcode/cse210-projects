public class Listing : Activity
    {
        string[] _prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?",
            "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

        public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {

        }

        public new void StartActivity()
        {
            base.StartActivity();
            int randomIndex = new Random().Next(0, _prompts.Length);
            Console.WriteLine(_prompts[randomIndex]);
            Spinner.Spin(3);
            int counter = 0;
            for (int i = 0; i < _duration; i++)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    counter++;
                }
            }
            Console.WriteLine($"You listed {counter} items.");
            base.EndActivity();
        }
    }