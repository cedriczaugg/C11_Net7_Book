using System.Diagnostics.CodeAnalysis;

namespace WorkingWithText;

internal partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string digitsOnlyText = @"^\d+$";

    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string commaSeparatorText =
        "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";

    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string fullDateTime = "";
}