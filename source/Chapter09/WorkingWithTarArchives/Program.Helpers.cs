// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

// namespace WorkingWithTarArchives;

internal partial class Program
{
    private static void WriteError(string message)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"FAIL: {message}");
        ForegroundColor = previousColor;
    }

    private static void WriteWarning(string message)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"WARN: {message}");
        ForegroundColor = previousColor;
    }

    private static void WriteInformation(string message)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Blue;
        WriteLine($"INFO: {message}");
        ForegroundColor = previousColor;
    }
}