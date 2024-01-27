class Scriptures

    {
    private Dictionary<Reference, string> scriptureDictionary;

    public Scriptures(string filePath)
    {
        scriptureDictionary = new Dictionary<Reference, string>();
        LoadScripturesFromFile(filePath);
    }

    private void LoadScripturesFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 4)
            {
                string book = parts[0].Trim();
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string scriptureText = parts[3].Trim();

                scriptureDictionary.Add(new Reference(book, chapter, verse), scriptureText);
            }
            else
            {
                Console.WriteLine("Invalid format: " + line);
            }
        }
    }


    // public Scriptures()
    // {
    //     scriptureDictionary = new Dictionary<Reference, string>
    //     {
    //         { new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." },
    //         { new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight." },
    //         { new Reference("1 Nephi", 3, 7), "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them."},            
    //         { new Reference("John", 1, 1), "In the beginning was the Word, and the Word was with God, and the Word was eGod."},
    //         { new Reference("1 Nephi", 31, 20), "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eeternal life."}
    //         // Add more scriptures here if needed
    //     };
    // }
    
    public void DisplayScriptures()
    {
        foreach (var scripture in scriptureDictionary)
        {
            Console.Clear();
            Console.WriteLine(scripture.Key);
            Console.WriteLine(scripture.Value);

            Console.WriteLine("\nPress Enter to hide words, or type quit to exit.");
            string userInput = Console.ReadLine();

            if (string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
                return;

            HideScripture(scripture.Value);
        }
    }
    private void HideScripture(string scriptureText)
{
    Console.Clear();

    Word[] words = GetWords(scriptureText);

    Console.WriteLine(string.Join(" ", words.Select(word => word.ToString())));

    int hiddenWordsCount = 0;
    int totalWordsCount = words.Length;

    while (hiddenWordsCount < totalWordsCount)
    {
        Console.WriteLine("\nPress Enter to hide the next word, or type quit to exit.");
        string userInput = Console.ReadLine();
        Console.Write("> ");

        if (string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
            return;

        int index = GetRandomIndex(words.Length);

        while (words[index].IsHidden)
        {
            index = GetRandomIndex(words.Length);
        }

        words[index].Hide();
        hiddenWordsCount++;

        Console.Clear();
        Console.WriteLine(string.Join(" ", words.Select(word => word.ToString())));
    }
}
    private Word[] GetWords(string scriptureText)
    {
        string[] wordTexts = scriptureText.Split(' ');
        return wordTexts.Select(text => new Word(text)).ToArray();
    }

    private int GetRandomIndex(int max)
    {
        Random random = new Random();
        return random.Next(max);
    }
}




