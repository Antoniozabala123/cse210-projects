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

        public void Start()// main  Starts the program and displays the menu
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
                    CreateGoal(); // created new goal
                }
                else if (choice == "2")
                {
                    ListGoalDetails(); // check all goal
                }
                else if (choice == "3")
                {
                    SaveGoals("goals.txt"); // save goal in txt
                }
                else if (choice == "4")// load goal in txt
                {
                    LoadGoals();
                }
                else if (choice == "5") //Record that a goal was completed
                {
                    RecordEvent();
                }
            }
        }
        public void DisplayPlayerInfo()

        {
            Console.WriteLine($"\nYou have {_score} points."); // show points to the user
        }
        public void ListGoalName() // this part check new goal if there are not resgiterd
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("You currently have no registered goals.");
                return;
            }

            Console.WriteLine("\nThe goals are:"); //Here the objectives are recorded and numbered.
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
            }
        }

        public void CreateGoal() // created goal also check list goal Show available goal types.
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string type = Console.ReadLine()?.Trim();

            if (type != "1" && type != "2" && type != "3")
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            if (!int.TryParse(Console.ReadLine(), out int points))
            {
                Console.WriteLine("Invalid points value.");
                return;
            }

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
                if (!int.TryParse(Console.ReadLine(), out int target)) return;

                Console.Write("What is the bonus points for accomplishing this goal? ");
                if (!int.TryParse(Console.ReadLine(), out int bonus)) return;

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("Goal created successfully!");
            }
        }
        public void ListGoalDetails()
        {
            foreach (var goal in _goals) Console.WriteLine(goal.GetDetailsString());
        }
        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record. Please create or load goals first.");
                return;
            }

            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }

            Console.Write("\nWhich goal did you accomplish? ");

            
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int choice))
            {
                
                if (choice > 0 && choice <= _goals.Count)
                {
                    int index = choice - 1;
                    Goal goal = _goals[index];

                    
                    goal.RecordEvent();

                    
                    int pointsEarned = goal.GetPoints();
                    _score += pointsEarned;

                    Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
                else
                {
                    Console.WriteLine("Invalid selection. That goal number does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        public void SaveGoals(string file = "goals.txt")
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine(_score);
                    foreach (Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
                Console.WriteLine($"\nYour file has been successfully saved {Path.GetFullPath(file)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError file not has saved  {ex.Message}");
            }
        }

        public void LoadGoals()
        {
            string filename = "goals.txt";

            if (!File.Exists(filename))
            {
                Console.WriteLine("\nerror The file does not exist. Create goals and use 'Save' first.");
                return;
            }

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);
                _goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] mainParts = line.Split(":");
                    if (mainParts.Length < 2) continue;

                    string type = mainParts[0];
                    string[] parts = mainParts[1].Split(",");

                    if (type == "SimpleGoal")
                    {
                        SimpleGoal sg = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                        
                        if (parts[3] == "True")
                        {
                            
                        }
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
                Console.WriteLine("\n sucess Goals loaded correctly.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nLoad failed:error {ex.Message}");
            }
        }
    }
}

