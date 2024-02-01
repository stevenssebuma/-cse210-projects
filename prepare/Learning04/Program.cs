using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment("Steven", "Programming");
        
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Jonathan Aloya", "Fractions", "7.9", "9-9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Dennis", "Public Health", "Enviromental Awareness");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());

        
    }
}