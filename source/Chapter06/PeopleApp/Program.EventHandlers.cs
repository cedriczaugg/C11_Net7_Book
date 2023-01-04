// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

namespace Packt.Shared;

internal partial class Program
{
    static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender is null)
        {
            return;
        }

        if (sender is not Person p)
        {
            return;
        }
        
        WriteLine($"{p.Name} is angry: {p.AngerLevel}");
    }
}