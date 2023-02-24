public class Menu
    {
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to your activity session");
                Console.WriteLine("Please select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Breathing breathing = new Breathing();
                    breathing.StartActivity();
                }
                else if (input == "2")
                {
                    Reflection reflection = new Reflection();
                    reflection.StartActivity();
                }
                else if (input == "3")
                {
                    Listing listing = new Listing();
                    listing.StartActivity();
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again.");
                }
            }
        }
    }
