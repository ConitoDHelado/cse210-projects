public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _minutes;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        double distance = GetDistance();
        double pace = GetPace();
        return $"{_date} Cycling ({_minutes} min) Distance: {distance}km; Speed: {_speed}kph; Pace: {pace} min per km.";
    }
}