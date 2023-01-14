// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using Newtonsoft.Json;
using Packt.Shared;
using FastJson = System.Text.Json.JsonSerializer;
using static System.Environment;
using static System.IO.Path;

// create an object graph
List<Person> people = new()
{
    new Person(30000M)
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new DateTime(1974, 3, 14)
    },
    new Person(40000M)
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new DateTime(1969, 11, 23)
    },
    new(20000M)
    {
        FirstName = "Charlie",
        LastName = "Cox",
        DateOfBirth = new DateTime(1984, 5, 4),
        Children = new HashSet<Person>
        {
            new(0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new DateTime(2012, 7, 12)
            }
        }
    }
};

XmlSerializer xs = new(people.GetType());

// create a file to write to
var path = Combine(CurrentDirectory, "people.xml");
using (var stream = File.Create(path))
{
    // serialize the object graph to the stream
    xs.Serialize(stream, people);
}

WriteLine("Written {0:N0} bytes of XML to {1}",
    new FileInfo(path).Length,
    path);
WriteLine();
// Display the serialized object graph
WriteLine(File.ReadAllText(path));

WriteLine();
WriteLine("* Desreializing XML files.");

using (var xmlLoad = File.Open(path, FileMode.Open))
{
    var loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;

    if (loadedPeople is not null)
        foreach (var p in loadedPeople)
            WriteLine("{0} has {1} children.", p.LastName, p.Children?.Count ?? 0);
}

// Create a file to write to
var jsonPath = Combine(CurrentDirectory, "people.json");

using (var jsonStream = File.CreateText(jsonPath))
{
    JsonSerializer jss = new();
    jss.Serialize(jsonStream, people);
}

WriteLine();
WriteLine("Written {0:N0} bytes of JSON to: {1}",
    new FileInfo(jsonPath).Length,
    jsonPath);
// display the serialized object graph
WriteLine(File.ReadAllText(jsonPath));

WriteLine();
WriteLine("* Deserializing JSON files");

using (var jsonLoad = File.Open(jsonPath, FileMode.Open))
{
    var loadedPeople =
        await FastJson.DeserializeAsync(jsonLoad, typeof(List<Person>)) as List<Person>;

    if (loadedPeople is not null)
        foreach (var p in loadedPeople)
            WriteLine("{0} has {1} children.",
                p.LastName, p.Children?.Count ?? 0);
}