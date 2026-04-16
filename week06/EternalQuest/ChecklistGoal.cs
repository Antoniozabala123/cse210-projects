namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted = 0;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            if (_amountCompleted < _target)
                _amountCompleted++;

            Console.WriteLine($"Progreso checklist: {_amountCompleted}/{_target}");
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
        }

        public override string GetDetailsString()  
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {_shortName} ({_description}) -- Completado {_amountCompleted}/{_target} again";
        }
    }
}