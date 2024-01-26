

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetInformationSignature()
    {
        return "Thanks,  " + _firstName;
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
    public void SetLastName()
    {
        _lastName = lastName;
    }
}

