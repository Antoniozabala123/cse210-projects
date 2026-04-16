using System;
namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete = false;

        public SimpleGoal(
            string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"¡Goal completed! +{_points} Points");
        }

        public override bool IsComplete() => _isComplete;

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        }

        public override string GetDetailsString()  
        {
            string status = _isComplete ? "[X]" : "[ ]";
            return $"{status} {_shortName} ({_description})";
        }
    }
}