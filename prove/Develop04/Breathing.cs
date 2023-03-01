public class Breathing : Activity
    {
        public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){}

        public new void StartActivity()
        {
            base.StartActivity();
            for (int i = 0; i < _duration / 4; i++)
            {
                Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
                Spinner.Spin(4);
            }
            base.EndActivity();
        }
    }