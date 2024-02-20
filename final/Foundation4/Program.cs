using System;
class Program
{
    static void Main(string[] args)
    {
        // Create activities and add them to the list
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 02, 20), 30, 3.0),
            new Cycling(new DateTime(2024, 02, 20), 30, 15.0),
            new Swimming(new DateTime(2024, 02, 20), 30, 20)
        };

        // Iterate through the activities and display the summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}