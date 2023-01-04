// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

namespace Packt.Shared;

partial class Program
{
    static void OutputPeopleNames(IEnumerable<Person> people, string title)
    {
        WriteLine(title);
        foreach (Person? p in people)
        {
            WriteLine(" {0}",
                p is null ? "<null> Person" : p.Name ?? "<null> Name");
        }
    }
}