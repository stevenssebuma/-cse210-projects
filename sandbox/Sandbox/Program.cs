using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World!");
//         Console.WriteLine("This is in C#.");

//         int number = 5;
//         number = 6;
//         number = 9;
//         Console.WriteLine($"{number}");

//         Console.Write("What is your name? ");
//         string name = Console.ReadLine();
//         Console.WriteLine(name);
        
//     }
// }


    // A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "Steven";
        public string _familyName = "Ssebuma";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }
    