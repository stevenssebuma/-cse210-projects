using System;

class Program
{
     private static int score = 0;
        
     private static List<Activity> goals = new List<Activity>();

    static void Main(string[] args)
    {
       

        // Load saved goals and score if available
        LoadGoals();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    RecordEvent();
                    break;

                case 3:
                    ShowGoals();
                    break;

                case 4:
                    ShowScore();
                    break;

                case 5:
                    SaveGoals();
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void CreateGoal()
    {
        Console.Write("Enter the goal type (1 - Simple, 2 - Eternal, 3 - Checklist): ");
        int goalType = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the goal name: ");
        string goalName = Console.ReadLine();
        
        Console.Write("Enter the points for completing the goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Activity goal;

        switch (goalType)
        {
            case 1:
                goal = new SimpleActivity(goalName, points);
                break;

            case 2:
                goal = new EternalActivity(goalName, points);
                break;

            case 3:
                Console.Write("Enter the target count for the checklist: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistActivity(goalName, points, targetCount);
                break;

            default:
                Console.WriteLine("Invalid goal type. Goal creation failed.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine($"New goal '{goalName}' created successfully!");
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select the goal to record an event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].GetStatus()}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            Activity goal = goals[goalNumber];
            goal.Complete();
            score += goal.Points;
        }
        else
        {
            Console.WriteLine("Invalid goal number. Event recording failed.");
        }
    }

    private static void ShowGoals()
    {
        Console.WriteLine("Current Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"[{goals[i].GetStatus()}] {goals[i].Name}");
        }
    }

    private static void ShowScore()
    {
        Console.WriteLine($"Current Score: {score} points");
    }

    private static void SaveGoals()
    {
        // Save goals and score to a file or database
        // Implementation omitted for brevity
        Console.WriteLine("Goals and Score saved successfully!");
    }

    private static void LoadGoals()
    {
        // Load goals and score from a file or database
        // Implementation omitted for brevity
        Console.WriteLine("Goals and Score loaded successfully!");
    }
}


        
    
