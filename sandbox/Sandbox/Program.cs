using System;
 
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._firstName = "Steven";
        person._lastName = "Ssebuma";
        person._age = 24;

        string _fullName = person._firstName + " " + person._lastName;
        Console.WriteLine("Full name:" + _fullName );
     
    }
}
