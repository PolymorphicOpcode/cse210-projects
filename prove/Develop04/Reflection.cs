public class Reflection : Activity
    {
        string[] _prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        string[][] _questions = {
            new string[] { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"},
            new string[] { "Why was this experience difficult for you?", "Have you ever been in a situation like this before?", "How did you prepare for this experience?",
                "How did you feel when it was complete?", 
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?", "How can you apply this experience in the future?"},
            new string[] { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you decide to help this person?",
                "How did you feel when it was complete?", "What made this time different than other times when you have not been as successful in helping others?",
                "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"},
            new string[] { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you start to do something selfless?",
                "How did you feel when it was complete?", "What made this time different than other times when you werenot as successful in being selfless?",
                "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?", "How can you apply this experience in the future?"}
        };

        public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){}

        public new void StartActivity()
        {
            base.StartActivity();
            int randomIndex = new Random().Next(0, _prompts.Length);
            Console.WriteLine(_prompts[randomIndex]);
            Spinner.Spin(3);
            for (int i = 0; i < _questions[randomIndex].Length; i++)
            {
                Console.WriteLine(_questions[randomIndex][i]);
                Spinner.Spin(3);
            }
        }
    }