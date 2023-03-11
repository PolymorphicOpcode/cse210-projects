using System.IO;
class Handler{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    private string _filename = "goals.txt";


    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        int number = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.Name} ({goal.Description})");
            number++;
        }
    }

    public void List() {
        int number = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.Name}");
            number++;
        }
    }
    public void Record(){
        int number = 0;
        foreach(var goal in _goals){
            number += 1;
            Console.WriteLine($"{number}. {goal.Name}");
        }
    }
    public int GetPointTotal(){
        return _totalPoints;
    }
    public void AddPointTotal(int points){
        _totalPoints += points;
    }
    public void IsComplete(int goalNum, Handler handler){
        var goal = _goals[goalNum-1];
        goal.SetComplete(handler, goalNum-1);
    
    }
    public void RemoveGoal(int goalNum){
        _goals.RemoveAt(goalNum);
    }
    public void SaveGoals(string filename)
{
    if (filename != "")
    {
        _filename = filename;
    }
    else
    {
        _filename = "goals.txt";
    }

    using (StreamWriter outputFile = new StreamWriter(_filename))
    {
        outputFile.WriteLine($"{_totalPoints}");

        foreach (var goal in _goals)
        {
            if (goal.Type == "checklist")
            {
                outputFile.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.Type},{goal.BonusAmount},{goal.BonusTimes},{goal.TimesTillBonus}");
            }
            else
            {
                outputFile.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.Type}");
            }
        }
    }
}
    public void LoadGoals(string filename)
{
    _goals.Clear();
    _filename = string.IsNullOrWhiteSpace(filename) ? "goals.txt" : filename;
    
    string[] lines = File.ReadAllLines(_filename);
    foreach (string line in lines)
    {
        if (!line.Contains(","))
        {
            if (int.TryParse(line, out int pointsInt))
            {
                _totalPoints = pointsInt;
            }
        }
        else
        {
            string[] parts = line.Split(",");
            string type = parts[3];
            
            switch (type)
            {
                case "simple":
                    Simple simpleGoal = new Simple(type)
                    {
                        Name = parts[0],
                        Description = parts[1],
                        Points = int.Parse(parts[2])
                    };
                    _goals.Add(simpleGoal);
                    break;
                case "eternal":
                    Eternal eternalGoal = new Eternal(type)
                    {
                        Name = parts[0],
                        Description = parts[1],
                        Points = int.Parse(parts[2])
                    };
                    _goals.Add(eternalGoal);
                    break;
                case "checklist":
                    Checklist checklistGoal = new Checklist(type)
                    {
                        Name = parts[0],
                        Description = parts[1],
                        Points = int.Parse(parts[2]),
                        BonusAmount = int.Parse(parts[4]),
                        BonusTimes = int.Parse(parts[5]),
                        TimesTillBonus = int.Parse(parts[6])
                    };
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }
}
}