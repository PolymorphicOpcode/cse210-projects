class Eternal : Goal {
    public Eternal(string type) : base(type) {}

    public override void CreateGoals() {
        var name = GetInput("What is the name of the goal: ");
        Name = name;

        var description = GetInput("What is a short description of the goal: ");
        Description = description;

        var points = GetInput("How many points are associated with the goal: ");
        Points = ParseInt(points);
    }

    public override void SetComplete(Handler handler, int goalNum) {
        GetHandler(handler);
        complete = true;
        Console.WriteLine($"\nCongrats You earned {Points} points!!\n");
        handler.AddPointTotal(Points);
    }

    private string GetInput(string prompt) {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    private int ParseInt(string input) {
        int.TryParse(input, out int value);
        return value;
    }
}