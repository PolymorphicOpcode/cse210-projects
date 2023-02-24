public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void StartActivity()
        {
            Console.WriteLine($"Starting {_name} Activity");
            Console.WriteLine(_description);
            Console.WriteLine("How many seconds do you want to do this activity?");
            _duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Get ready...");
            Spinner.Spin(_duration);

            Console.WriteLine("Good job!");
            Console.WriteLine($"You just completed the {_name} activity for {_duration} seconds.");
            Spinner.Spin(3);
        }
    }