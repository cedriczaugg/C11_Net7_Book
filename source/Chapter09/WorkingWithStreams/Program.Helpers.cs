// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

// namespace WorkingWithStreams;

internal partial class Program
{
    private static void SectionTitle(string title)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("*");
        WriteLine($"* {title}");
        WriteLine("*");
        ForegroundColor = previousColor;
    }
}