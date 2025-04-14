public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }
        public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }
    public override double GetSpeed()
    {
        return ((_laps * 50 / 1000) / _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes/((_laps * 50) / 1000);
    }
    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"{_date} Swimming ({_minutes} min) Distance: {distance}km; Speed: {speed}kph; Pace: {pace} min per km.";
    }
    
}