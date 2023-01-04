using Packt.Shared;

Person harry = new Person()
{
    Name = "Harry",
    DateOfBirth = new(2001, 3, 25)
};

harry.WriteToConsole();

// Non-generic Lookup collection
System.Collections.Hashtable lookupObject = new ();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gammma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;

WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupObject[key]);

WriteLine(format: "Key {0} has value: {1}",
    arg0: harry,
    arg1: lookupObject[harry]);

// generic Lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");