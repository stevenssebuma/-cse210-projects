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




