public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
    public override string GetSummary()
    {
        double speed = GetSpeed();
        double pace = GetPace();
        return $"{_date} Running ({_minutes} min) Distance: {_distance}km; Speed: {speed}kph; Pace: {pace} min per km.";
    }
}
