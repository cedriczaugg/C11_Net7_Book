// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;


namespace WorkingWithRegularExpressions;

internal partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    const string digitsOnlyText = @"^\d+$";
    [StringSyntax(StringSyntaxAttribute.Regex)]
    const string commaSeparatorText = 
        "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";
    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    const string fullDateTime = "dddd, d MMMM yyyy";
}