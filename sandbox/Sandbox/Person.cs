public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetInformationSignature()
    {
        return "Thanks, " + _firstName + " " + _lastName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }
}
