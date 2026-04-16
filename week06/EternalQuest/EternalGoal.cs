namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int _timesCompleted = 0;

        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            _timesCompleted++;
            Console.WriteLine($"Progreso eterno: {_shortName} (+{_points} puntos) - Veces: {_timesCompleted}");
        }

        public override bool IsComplete() => false;

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{_shortName},{_description},{_points},{_timesCompleted}";
        }

        public override string GetDetailsString()  
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}