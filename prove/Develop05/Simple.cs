class Simple : Goal {
    public Simple(string type) : base(type) { }

    public override void CreateGoals() {
        var name = PromptInput("What is the name of the goal: ");
        var description = PromptInput("What is a short description of the goal: ");
        var points = PromptInt("How many points are associated with the goal: ");
        Name = name;
        Description = description;
        Points = points;
    }
    
    private static string PromptInput(string prompt) {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    
    private static int PromptInt(string prompt) {
        Console.Write(prompt);
        int.TryParse(Console.ReadLine(), out int result);
        return result;
    }
}