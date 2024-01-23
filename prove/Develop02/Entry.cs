public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public string Location {get; set; }

    public Entry(string prompt, string response, string location)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
        Location = location;
    }

    public override string ToString()
    {
        return $"{Location} [{Date}] {Prompt}: {Response}";
    }

}