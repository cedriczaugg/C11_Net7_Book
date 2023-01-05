// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

namespace Packt.Shared;

internal partial class Program
{
    private static void OutputPeopleNames(Person?[] people, string title)
    {
        WriteLine(title);
        foreach (var p in people)
            WriteLine(" {0}",
                p is null ? "<null> Person" : p.Name ?? "<null> Name");
    }
}