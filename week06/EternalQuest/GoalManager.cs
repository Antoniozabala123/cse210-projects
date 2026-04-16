using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
        public void Start()
        {
            string choice = "";
            while (choice != "6")
            {
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();


                if (choice == "1")
                {
                    CreateGoal();
                }
                else if (choice == "2")
                {
                    ListGoalDetails();
                }
                else if (choice == "3")
                {
                    SaveGoals("goals.txt");
                }
                else if (choice == "4")
                {
                    LoadGoals();
                }
                else if (choice == "5")
                {
                    RecordEvent();
                }
            }
        }
        public void DisplayPlayerInfo()

        {
            Console.WriteLine($"\nYou have {_score} points.");
        }
        public void ListGoalName()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("You currently have no registered goals.");
                return;
            }

            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
            }
        }
    
        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string type = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;

            if (type == "1")
            {
                newGoal = new SimpleGoal(name, description, points);
            }
            else if (type == "2")
            {
                newGoal = new EternalGoal(name, description, points);
            }
            else if (type == "3")
            {
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus points for accomplishing this goal? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);

                if (newGoal != null)
                {
                    _goals.Add(newGoal);
                    Console.WriteLine("Goal created successfully!");
                }
            }
        }
        
        public void ListGoalDetails()
        {
            foreach (var goal in _goals) Console.WriteLine(goal.GetDetailsString());
        }
        public void RecordEvent()
        {

            Console.Write("\nWhich goal did you accomplish? (enter the number) ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (_goals[index].IsComplete() || _goals[index] is EternalGoal || _goals[index] is ChecklistGoal)
            {
                _score += _goals[index].GetHashCode();
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
        public void SaveGoals(string file)
        {
            using (StreamWriter writer = new StreamWriter(file))

            {
                writer.WriteLine(_score);

                foreach (Goal goal in _goals)

                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved successfully to {file}");
        }
        public void LoadGoals()

        {
            string filename = "goals.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

           
            _score = int.Parse(lines[0]);

            _goals.Clear();

           
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] mainParts = line.Split(":");
                string type = mainParts[0];
                string details = mainParts[1];

                
                string[] parts = details.Split(",");

                
                if (type == "SimpleGoal")
                {
                    
                    SimpleGoal sg = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                    if (parts[3] == "True") sg.RecordEvent();
                    _goals.Add(sg);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[3])));
                }
            }
        }
    }
}


