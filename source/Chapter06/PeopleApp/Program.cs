using System.Collections;

namespace Packt.Shared;

internal partial class Program
{
    public static void Main(string[] args)
    {
        var harry = new Person
        {
            Name = "Harry",
            DateOfBirth = new DateTime(2001, 3, 25)
        };

        harry.WriteToConsole();

// Non-generic Lookup collection
        Hashtable lookupObject = new();
        lookupObject.Add(1, "Alpha");
        lookupObject.Add(2, "Beta");
        lookupObject.Add(3, "Gammma");
        lookupObject.Add(harry, "Delta");

        var key = 2;

        WriteLine("Key {0} has value: {1}",
            key,
            lookupObject[key]);

        WriteLine("Key {0} has value: {1}",
            harry,
            lookupObject[harry]);

// generic Lookup collection
        Dictionary<int, string> lookupIntString = new();
        lookupIntString.Add(1, "Alpha");
        lookupIntString.Add(2, "Beta");
        lookupIntString.Add(3, "Gamma");
        lookupIntString.Add(4, "Delta");

        key = 3;
        WriteLine("Key {0} has value: {1}",
            key,
            lookupIntString[key]);

        // Assign a method to the Shout delegate.
        harry.Shout += Harry_Shout;
        harry.Shout += Harry_Shout2;

        // call the poke method that raises the Shout event
        harry.Poke();
        harry.Poke();
        harry.Poke();
        harry.Poke();

        Person?[] people =
        {
            null,
            new() { Name = "Simon" },
            new() { Name = "Jenny" },
            new() { Name = "Adam" },
            new() { Name = null },
            new() { Name = "Richard" }
        };

        OutputPeopleNames(people, "Initial list of people:");

        Array.Sort(people, new PersonComparer());

        OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

        var dv1 = new displacementVector(3, 5);
        var dv2 = new displacementVector(-2, 7);

        var dv3 = dv1 + dv2;
        WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

        Employee john = new()
        {
            Name = "John Jones",
            DateOfBirth = new(1990, 7, 28)
        };
        john.WriteToConsole();
        john.EmployeeCode = "JJ001";
        john.HireDate = new(204, 11, 23);
        WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

        WriteLine(john.ToString());

        Employee aliceInEmployee = new()
            { Name = "Alice", EmployeeCode = "AA123" };
        Person aliceInPerson = aliceInEmployee;
        aliceInEmployee.WriteToConsole();
        aliceInPerson.WriteToConsole();
        WriteLine(aliceInEmployee.ToString());
        WriteLine(aliceInPerson.ToString());

        Employee explicitAlice = (Employee)aliceInPerson;
        if (aliceInPerson is Employee)
        {
            WriteLine($"{nameof(aliceInPerson)} IS an Employee");
        }
        
        try
        {
            john.TimeTravel(when: new(1999, 12, 31));
            john.TimeTravel(when: new(1950, 12, 25));
        }
        catch (PersonException ex)
        {
            WriteLine(ex.Message);
        }

        string email1 = "foo@test.com";
        string email2 = "foo&bar&test.com";
        
        WriteLine("{0} is a valid e-mail address: {1}", 
            arg0: email1,
            arg1: email1.IsValidEmail());
        WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email2,
            arg1: email2.IsValidEmail());
    }
}