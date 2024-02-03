public class ReflectionActivity : Activity
{
    private readonly Random random;
    private readonly string[] prompts;
    private readonly string[] questions;

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on your experiences and personal growth")
    {
        random = new Random();
        prompts = new[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        questions = new[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void StartActivity(int duration)
    {
        DisplayStartingMessage(duration);
        Console.WriteLine("\nLet's begin...");
        int counter = 0;
        while (counter < duration)
        {
            var prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            ShowSpinner();
            Thread.Sleep(1000); // Pause for 1 second
            foreach (var question in questions)
            {
                Console.WriteLine("\n" + question);
                ShowSpinner();
                Thread.Sleep(2000); // Pause for 2 seconds
                counter += 3;
                if (counter >= duration)
                    break;
            }
            if (counter >= duration)
                break;
        }
        DisplayEndingMessage(duration);
    }
}
