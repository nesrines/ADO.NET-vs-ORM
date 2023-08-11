namespace EntityFramework.Entities;
public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public override string ToString()
    {
        return $"Id: {Id} Name: {FirstName} {LastName}";
    }
}