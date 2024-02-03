
public abstract class Activity
{
    private string _name { get; set; }
    private string _description { get; set; }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage(int duration)
    {
        Console.WriteLine($"\nStarting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {duration} seconds.");
        Console.Write("Prepare to begin");
        Console.Write(".");
        ShowSpinner();
        
    }

    public void DisplayEndingMessage(int duration)
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"You have spent {duration} seconds on {_name}.");
        Console.WriteLine("Pause for a moment...");
        ShowSpinner();
        
    }

    public void ShowSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
       
    }

    public void ShowCountDown()
    {
        for (int i = 4; i > 0; i--)        
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public abstract void StartActivity(int duration);
}
