namespace Packt.Shared;

public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateTime HireDate { get; set; }

    public new void WriteToConsole()
    {
        WriteLine("{0} was born in {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            Name,
            DateOfBirth,
            HireDate);
    }
}