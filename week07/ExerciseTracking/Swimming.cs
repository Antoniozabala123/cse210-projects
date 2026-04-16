using System;
namespace ExerciseTracking
{
    public class Swimming : Activity
{
    private double _laps;

        public Swimming(DateTime date, int minutes, double laps) : base(date, minutes)
    {
            _laps = laps;
    }
    public override double GetDistance()
    {
        
        return _laps * 50.0 / 1000.0;
        }

    public override double GetSpeed()
    {
        return _laps;
    }

    public override double GetPace()
    {
        
        return 60.0 / _laps;
    }
}
}