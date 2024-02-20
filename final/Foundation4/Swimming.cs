public class Swimming : Activity
{
    public int Laps { get; private set; }

    public Swimming(DateTime date, int duration, int laps): base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60.0;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}
