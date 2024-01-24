using System;
 
class Program
{
    static void Main(string[] args)
    {

        Person p = new Person();
        p.SetLastName("Ssebuma");

        Console.Write("First Name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"{_firstName} {lastName}");
    }
}
