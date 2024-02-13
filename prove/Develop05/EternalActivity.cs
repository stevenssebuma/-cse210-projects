public class EternalActivity : Activity
{
    public EternalActivity(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void Complete()
    {
        Console.WriteLine($"{Name} activity recorded. You gained {Points} points!");
    }

    public override string GetStatus()
    {
        return "Recorded";
    }
}
