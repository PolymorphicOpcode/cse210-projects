using System;

namespace ProjectFive {
    class Program {
        static void Main(string[] args){
            Menu menu = new Menu();
            menu.Display();
        }
    }
    class Menu {
        private List<string> _prompts = new List<string>() { "Create a new goal", "List goals", "Save goals to file", "Load goals from file", "Exit" };
        private int _choice;
    
        public Menu() {}
        
        public void Display() {
            while (_choice != 5){
                for (int i = 0; i < _prompts.Count; i++) {
                    Console.WriteLine($"{i + 1}. {_prompts[i]}");
                }
                _choice = int.Parse(Console.ReadLine());
            }
        }
    }
    class Handler {
        private List<Goal> _goals = new List<Goal>();
        private int _totalPoints;
        private string _fileName = "goals.txt";

        public void List() {}
        public void Save(string fileName) {
            fileName = _fileName;
        }
        public void Load(string fileName) {
            fileName = _fileName;
        }
    }

    class Goal {
        private int _points;
        private string _description;

        public Goal(){}
        public void GetGoals(){}
        public virtual void CreateGoal(string goal){}
    }

    class Simple : Goal{
        public Simple(){}

        public override void CreateGoal(string goal){
            base.CreateGoal(goal);
        }
    }
    class Eternal : Goal{
        public Eternal(){}

        public override void CreateGoal(string goal){
            base.CreateGoal(goal);
        }
    }
    class Checklist : Goal{
        private bool _completed;
        public Checklist(){}
        public override void CreateGoal(string goal){
            base.CreateGoal(goal);
        }
        public void Complete(){}

    }
}