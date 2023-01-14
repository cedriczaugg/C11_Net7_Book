// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

namespace WorkingWithRegularExpressions;

internal partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string digitsOnlyText = @"^\d+$";

    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string commaSeparatorText =
        "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";

    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string fullDateTime = "dddd, d MMMM yyyy";
}