using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scriptures.txt"; //This will load scriptures from the scripture.txt file

        Scriptures scriptures = new Scriptures(filePath);
        scriptures.DisplayScriptures();
      
    }
}