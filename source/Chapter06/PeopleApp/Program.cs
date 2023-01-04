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

        Array.Sort(people);
        
        OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");
    }
}