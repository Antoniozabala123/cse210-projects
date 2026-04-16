using System;
namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
        }
        public override double GetDistance()
        {
            
            return (_speed * _minutes) / 60.0;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            // Ritmo = 60 / velocidad
            return 60.0 / _speed;
        }
    }
}