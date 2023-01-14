// namespace Packt.Shared;

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

    private static void Fail(string message)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Fail > {message}");
        ForegroundColor = previousColor;
    }

    private static void Info(string message)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Cyan;
        WriteLine($"Info > {message}");
        ForegroundColor = previousColor;
    }
}