// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Instrumenting;

internal static partial class Program
{
    private static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string member = "",
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))] string expression = "")
    {
        Trace.WriteLine(string.Format("[{0}]\n  {1} on line {2}. Expression: {3}", filePath, member, line, expression));
    }
}