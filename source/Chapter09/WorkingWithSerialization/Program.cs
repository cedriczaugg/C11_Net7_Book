// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using Packt.Shared;
using FasrJson = System.Text.Json.JsonSerializer;

using static System.Environment;
using static  System.IO.Path;

// create an object graph
List<Person> people = new()
{
    new(30000M) 
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new(year: 1974, month: 3, day: 14)
    },
    new(40000M) 
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new(year: 1969, month: 11, day: 23)
    },
    new(20000M)
    {
        FirstName = "Charlie",
        LastName = "Cox",
        DateOfBirth = new(year: 1984, month: 5, day: 4),
        Children = new()
        {
            new(0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new(year: 2012, month: 7, day: 12)
            }
        }
    }
};

XmlSerializer xs = new (type: people.GetType());

// create a file to write to
string path = Combine(CurrentDirectory, "people.xml");
using (FileStream stream = File.Create(path))
{
    // serialize the object graph to the stream
    xs.Serialize(stream, people);
}
WriteLine("Written {0:N0} bytes of XML to {1}",
    arg0: new FileInfo(path).Length,
    arg1: path);
WriteLine();
// Display the serialized object graph
WriteLine(File.ReadAllText(path));

WriteLine();
WriteLine("* Desreializing XML files.");

using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    List<Person> loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;

    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} children.", p.LastName, p.Children?.Count ?? 0);
        }
    }
}

// Create a file to write to
string jsonPath = Combine(CurrentDirectory, "people.json");

using (StreamWriter jsonStream = File.CreateText(jsonPath))
{
    Newtonsoft.Json.JsonSerializer jss = new();
    jss.Serialize(jsonStream, people);
}

WriteLine();
WriteLine("Written {0:N0} bytes of JSON to: {1}",
    arg0: new FileInfo(jsonPath).Length,
arg1: jsonPath);
// display the serialized object graph
WriteLine(File.ReadAllText(jsonPath));

WriteLine();
WriteLine("* Deserializing JSON files");

using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
{
    List<Person>? loadedPeople =
        await FasrJson.DeserializeAsync(utf8Json: jsonLoad, returnType: typeof(List<Person>)) as List<Person>;

    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} children.",
                p.LastName, p.Children?.Count ?? 0);
        }
    }
}