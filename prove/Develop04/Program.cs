using System;

class Program
{
    static void Main(string[] args)
    {
       BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        // Menu system
        var activities = new Dictionary<string, Activity>
        {
            { "1", breathingActivity },
            { "2", reflectionActivity },
            { "3", listingActivity }
        };

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an activity (1-4): ");
            var choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Thanks for your participation! ");
                break;  
            }
                
            if (activities.TryGetValue(choice, out var activity))
            {
                Console.Write("Enter the duration in seconds: ");
                var duration = int.Parse(Console.ReadLine());
                activity.StartActivity(duration);
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

}
