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
            Console.WriteLine($"How many seconds do you want to do your {_name} activity?");
            _duration = int.Parse(Console.ReadLine());
        }

        public void EndActivity() {
            Console.WriteLine($"Good job! You did {_name} activity for {_duration} seconds!");
        }
    }