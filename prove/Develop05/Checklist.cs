class Checklist : Goal
{
    private int bonusTimes;
    private int bonusAmount;
    private int timeTillBonus;

    public Checklist(string type) : base(type)
    {
        bonusTimes = 0;
    }

    public int BonusAmount
    {
        get => bonusAmount;
        set => bonusAmount = value;
    }

    public int BonusTimes
    {
        get => bonusTimes;
        set => bonusTimes = value;
    }

    public int TimesTillBonus
    {
        get => timeTillBonus;
        set => timeTillBonus = value;
    }

    public override void CreateGoals()
    {
        Console.Write("What is the name of the goal: ");
        string name = Console.ReadLine();
        Name = name;
        Console.Write("What is a short description of the goal: ");
        string description = Console.ReadLine();
        Description = description;
        Console.Write("How many points are associated with the goal: ");
        string points = Console.ReadLine();
        int.TryParse(points, out int pointsInt);
        Points = pointsInt;
        Console.Write("How many times does this Goal need to be accomplished till a bonus? ");
        int.TryParse(Console.ReadLine(), out int bonusTimes);
        TimesTillBonus = bonusTimes;
        Console.Write("What is the bonus points? ");
        int.TryParse(Console.ReadLine(), out int bonus);
        BonusAmount = bonus;
    }

    public override void SetComplete(Handler handler, int goalNum)
    {
        GetHandler(handler);
        complete = true;
        BonusTimes += 1;

        Console.WriteLine($"{BonusTimes} / {TimesTillBonus} times completed.");

        if (BonusTimes == TimesTillBonus)
        {
            BonusAmount += Points;
            Console.WriteLine($"\nCongrats, You earned {BonusAmount} points!\n");
            handler.AddPointTotal(BonusAmount);
            handler.RemoveGoal(goalNum);
        }
        else
        {
            Console.WriteLine($"\nCongrats, You earned {Points} points!\n");
            handler.AddPointTotal(Points);
        }
    }
}