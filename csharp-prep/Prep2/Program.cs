using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 97)
        {
            letter = "A+";
        }
        else if (percent >= 93 && percent < 97)
        {
            letter = "A";
        }
        else if (percent >= 90 && percent < 93)
        {
            letter = "A-";
        }
        else if (percent >=87 && percent < 90)
        {
            letter = "B+";
        }
        else if (percent >= 83 && percent < 87)
        {
            letter = "B";
        }
        else if (percent >= 80 && percent < 84)
        {
            letter = "B-";
        }
        else if (percent >= 77 && percent < 80)
        {
            letter = "C+";
        }
         else if (percent >= 73 && percent < 77)
        {
            letter = "C";
        }
         else if (percent >= 70 && percent < 73)
        {
            letter = "C-";
        }
         else if (percent >= 67 && percent < 70)
        {
            letter = "D+";
        }
         else if (percent >= 65 && percent < 67)
        {
            letter = "D";
        }
        else{
            letter = "F";

        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}