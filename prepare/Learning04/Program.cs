using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Steven", "Programming");
        
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jonathan Aloya", "Fractions", "7.9", "9-9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Dennis", "Public Health", "Enviromental Awareness");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}