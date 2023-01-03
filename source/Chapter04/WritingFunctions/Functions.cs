// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

// namespace WritingFunctions;

internal partial class Program
{
    private static void TimesTables(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        for (var row = 1; row <= size; row++) WriteLine($"{row} X {number} = {row * number}");
        WriteLine();
    }

    private static decimal CalculateTax(
        decimal amount, string twoLetterRegionCode)
    {
        var rate = twoLetterRegionCode switch
        {
            "CH" => // Switzerland
                0.08M,
            "DK" => // Denmark
                0.25M,
            "NO" => // Norway
                0.25M,
            "GB" => // United Kingdom
                0.2M,
            "FR" => // France
                0.2M,
            "HU" => // Hungary
                0.27M,
            "OR" => // Oregon
                0.0M,
            "AK" => // Alaska
                0.0M,
            "MT" => // Montana
                0.0M,
            "ND" => // North Dakota
                0.05M,
            "WI" => // Wisconsin
                0.05M,
            "ME" => // Maine
                0.05M,
            "VA" => // Virginia
                0.05M,
            "CA" => // California
                0.0825M,
            _ => 0.06M
        };
        return amount * rate;
    }
}