﻿// See https://aka.ms/new-console-template for more information

// Simple syntax for creating a list and adding three items

using System.Collections.Immutable;

namespace WorkingWithCollections;

internal partial class Program
{
    public static void Main(string[] args)
    {
        List<string> cities = new();
        cities.Add("London");
        cities.Add("Paris");
        cities.Add("Milan");

        Output("Initial list", cities);
        WriteLine($"The first city is {cities[0]}.");
        WriteLine($"The last city is {cities[cities.Count - 1]}.");
        cities.Insert(0, "Sydney");
        Output("After inserting Sydney at index 0", cities);
        cities.RemoveAt(1);
        cities.Remove("Milan");
        Output("After removing two cities", cities);

        Dictionary<string, string> keywords = new();
        // add using named parameters
        keywords.Add("int", "32-bit integer data type");
        // add using positional parameters
        keywords.Add("long", "64-bit integer data type");
        keywords.Add("float", "Single precision floating point number");

        Output("Dictionary keys:", keywords.Keys);
        Output("Dictionary values:", keywords.Values);

        WriteLine("Keywords and their definitions");
        foreach (var item in keywords) WriteLine($" {item.Key}: {item.Value}");
        // look up a value using a key
        var key = "long";
        WriteLine($"The definition of {key} is {keywords[key]}");

        Queue<string> coffee = new();
        coffee.Enqueue("Damir"); // front of queue
        coffee.Enqueue("Andrea");
        coffee.Enqueue("Ronald");
        coffee.Enqueue("Amin");
        coffee.Enqueue("Irina"); // back of queue
        Output("Initial queue from front to back", coffee);
        // server handles next person in queue
        var served = coffee.Dequeue();
        WriteLine($"Served: {served}.");
        // server handles next person in queue
        served = coffee.Dequeue();
        WriteLine($"Served: {served}.");
        Output("Current queue from front to back", coffee);
        WriteLine($"{coffee.Peek()} is next in line.");
        Output("Current queue from front to back", coffee);

        PriorityQueue<string, int> vaccine = new();
        // add some people
        // 1 = high priority people in their 70s or poor health
        // 2 = medium priority e.g. middle-aged
        // 3 = low priority e.g. teens and twenties
        vaccine.Enqueue("Pamela", 1); // my mum (70s)
        vaccine.Enqueue("Rebecca", 3); // my niece (teens)
        vaccine.Enqueue("Juliet", 2); // my sister (40s)
        vaccine.Enqueue("Ian", 1); // my dad (70s)
        OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
        WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
        WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
        OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
        WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
        WriteLine("Adding Mark to queue with priority 2");
        vaccine.Enqueue("Mark", 2); // me (40s)
        WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
        OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);

        var immutableCities = cities.ToImmutableList();
        var newList = immutableCities.Add("Rio");
        Output("Immutable list of cities:", immutableCities);
        Output("New list of cities:", newList);
    }
}