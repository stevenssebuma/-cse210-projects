public abstract class Activity
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }

    public abstract void Complete();
    public abstract string GetStatus();
}
