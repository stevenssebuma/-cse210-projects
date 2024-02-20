
public class Activity
{
    public DateTime Date { get; private set; }
    public int Duration { get; private set; }

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        if (this is Running)
        {
            return $"{Date.ToString("dd MMM yyyy")} Running ({Duration} min) - Distance: {distance:f1} miles, Speed: {speed:f1} mph, Pace: {pace:f1} min per mile";
        }
        else if (this is Cycling)
        {
            return $"{Date.ToString("dd MMM yyyy")} Cycling ({Duration} min) - Distance: {distance:f1} km, Speed: {speed:f1} kph, Pace: {pace:f2} min per km";
        }
        else if (this is Swimming)
        {
            return $"{Date.ToString("dd MMM yyyy")} Swimming ({Duration} min) - Distance: {distance:f1} km, Speed: {speed:f1} kph, Pace: {pace:f2} min per km";
        }

        return "";
    }
}
