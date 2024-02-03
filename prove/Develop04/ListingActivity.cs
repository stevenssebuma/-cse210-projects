//Note I added a method to save the Listings in a seperate file named 
public class ListingActivity : Activity
{
    private readonly Random random;
    private readonly string[] prompts;

    public ListingActivity() : base("Listing", "This activity will help you focus on the positive things in your life by listing items")
    {
        random = new Random();
        prompts = new[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void StartActivity(int duration)
    {
        DisplayStartingMessage(duration);
        Console.WriteLine("\nLet's begin...");
        var prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner();
        Thread.Sleep(3000); // Pause for 3 seconds
        var startTime = DateTime.Now;
        var itemsCount = 0;
        List<string> items = new List<string>();
        while ((DateTime.Now - startTime).TotalSeconds <= duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            itemsCount++;
        }
        Console.Write("Enter the name of the file to save the items: ");
        string filename = Console.ReadLine();
        File.WriteAllLines(filename, items); // Save items to the specified file
        Console.WriteLine($"\nYou listed {itemsCount} items. The items have been saved to the file: {filename}.");
        DisplayEndingMessage(duration);
    }
}