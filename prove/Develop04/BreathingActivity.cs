

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises")
    {
    }

    public override void StartActivity(int duration)
    {
        DisplayStartingMessage(duration);
        Console.WriteLine("\nLet's begin...");
        int counter = 0;
        while (counter < duration)
        {
            foreach (var message in new[] { "Breathe in", "Breathe out" })
            {
                Console.WriteLine(message);
                // ShowSpinner();
                ShowCountDown();
                Thread.Sleep(1000); // Pause for 1 second
                counter++;
                if (counter >= duration)
                    break;
            }
        }
        DisplayEndingMessage(duration);
    }
}
