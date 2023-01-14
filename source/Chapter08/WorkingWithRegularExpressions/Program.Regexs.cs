using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions;

internal partial class Program
{
    [GeneratedRegex(digitsOnlyText, RegexOptions.IgnoreCase)]
    private static partial Regex DigitsOnly();

    [GeneratedRegex(commaSeparatorText, RegexOptions.IgnoreCase)]
    private static partial Regex CommaSeparator();
}