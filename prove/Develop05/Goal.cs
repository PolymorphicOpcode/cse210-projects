class Goal {
    private int points;
    private string description;
    private string name;
    protected bool complete = false;
    private Handler handler = new Handler();
    private string type;

    public Goal(string type) {
        this.type = type;
    }

    public void GetHandler(Handler handler) {
        this.handler = handler;
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public int Points {
        get { return points; }
        set { points = value; }
    }

    public string Description {
        get { return description; }
        set { description = value; }
    }

    public bool Complete {
        get { return complete; }
        set { complete = value; }
    }

    public virtual void SetComplete(Handler handler, int goalNum) {
        GetHandler(handler);
        complete = true;
        Console.WriteLine($"\nCongrats, You earned {points} points!\n");
        handler.AddPointTotal(points);
        handler.RemoveGoal(goalNum);
    }

    public virtual void CreateGoals() {}

    public string Type {
        get { return type; }
    }

    public virtual int BonusAmount {
        get { return 0; }
    }

    public virtual int BonusTimes {
        get { return 0; }
    }

    public virtual int TimesTillBonus {
        get { return 0; }
    }
}