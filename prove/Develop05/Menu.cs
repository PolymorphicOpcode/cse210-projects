using System;
using System.Collections.Generic;
using System.Linq;

class Menu {
    private readonly List<string> _prompts = new List<string> {
        "1. Create new goal",
        "2. List goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };
    private readonly List<Goal> _goals = new List<Goal>();
    private readonly Handler _handler = new Handler();

    public void Display() {
        var quit = false;

        while (!quit) {
            foreach (var prompt in _prompts) {
                Console.WriteLine(prompt);
            }
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            int.TryParse(choice, out int choiceInt);

            switch (choiceInt) {
                case 1:
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple");
                    Console.WriteLine("2. Eternal");
                    Console.WriteLine("3. Checklist");
                    Console.Write("What type of goal would you like to Create: ");
                    string type = Console.ReadLine();
                    int.TryParse(type, out int typeInt);
                    switch (typeInt) {
                        case 1:
                            Simple simple = new Simple("simple");
                            _goals.Add(simple);
                            break;
                        case 2:
                            Eternal eternal = new Eternal("eternal");
                            _goals.Add(eternal);
                            break;
                        case 3:
                            Checklist checklist = new Checklist("checklist");
                            _goals.Add(checklist);
                            break;
                        default:
                            break;
                    }
                    _goals.ForEach(goal => {
                        goal.CreateGoals();
                        _handler.AddGoal(goal);
                    });
                    _goals.RemoveAt(0);
                    break;
                case 2:
                    Console.WriteLine("The goals are:");
                    _handler.List();
                    Console.WriteLine();
                    Console.WriteLine($"You have {_handler.GetPointTotal()} points");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("What is the name of the file? ");
                    string saveFilename = Console.ReadLine();
                    _handler.SaveGoals(saveFilename);
                    break;
                case 4:
                    Console.WriteLine("What is the name of the file? ");
                    string loadFilename = Console.ReadLine();
                    _handler.LoadGoals(loadFilename);
                    break;
                case 5:
                    Console.WriteLine("The goals are:");
                    _handler.Record();
                    Console.Write("What goal did you accomplish? ");
                    string goal = Console.ReadLine();
                    int.TryParse(goal, out int goalInt);
                    _handler.IsComplete(goalInt, _handler);
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}
