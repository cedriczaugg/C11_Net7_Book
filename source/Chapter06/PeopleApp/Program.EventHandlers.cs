// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

namespace Packt.Shared;

internal partial class Program
{
    private static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender is null) return;

        if (sender is not Person p) return;

        WriteLine($"{p.Name} is angry: {p.AngerLevel}");
    }

// another method to handle the Shout event received by the harry object
    private static void Harry_Shout2(object? sender, EventArgs e)
    {
        if (sender is null) return;
        var p = sender as Person;
        if (p is null) return;
        WriteLine("Stop it!");
    }
}