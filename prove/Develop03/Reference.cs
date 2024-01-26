class Reference
{
    public string Book { get; private set; }
    public string Chapter { get; private set; }
    public string Verse { get; private set; }
    public string VerseEnd { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter.ToString();
        Verse = verse.ToString();
    }

    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        Book = book;
        Chapter = chapter.ToString();
        Verse = verse.ToString();
        VerseEnd = verseEnd.ToString();
    }

    public override string ToString()
    {
        if (string.IsNullOrEmpty(VerseEnd))
            return $"{Book} {Chapter}:{Verse}";
        else
            return $"{Book} {Chapter}:{Verse}-{VerseEnd}";
    }
}
