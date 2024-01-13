using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        int chances = 0;

        while (guess != magicNumber)
        {
           
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            chances++; 

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }

            Console.WriteLine($"You have used {chances} chances.");

        }                    
    
    }
}