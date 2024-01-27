//Note that I have added a file with scriptures for the program to load there scriptures
//They are in the scripture.txt file
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