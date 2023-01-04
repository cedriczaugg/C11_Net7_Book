// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

namespace Packt.Shared;

public class Person : object
{
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    public DateTime DateOfBirth;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    // Fields
    public string? Name;

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
}