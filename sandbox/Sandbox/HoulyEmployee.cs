public class HoulyEmployee : Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float calculateSalary()
    {
        return rate * hours;
    }
}