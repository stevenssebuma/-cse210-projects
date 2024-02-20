public class Cycling : Activity
{
    public double Speed { get; private set; }

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * Duration / 60.0;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60.0 / Speed;
    }
}
