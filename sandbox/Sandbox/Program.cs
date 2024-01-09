using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is in C#.");

        int number = 5;
        number = 6;
        number = 9;
        Console.WriteLine($"{number}");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        
    }
}