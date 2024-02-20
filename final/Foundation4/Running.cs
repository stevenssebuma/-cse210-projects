public class Running : Activity
{
    public double Distance { get; private set; }

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Duration) * 60.0;
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }
}

