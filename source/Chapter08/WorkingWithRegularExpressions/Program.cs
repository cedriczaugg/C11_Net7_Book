// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions;

internal partial class Program
{
    public static void Main(string[] args)
    {
        Write("Enter your age:");
        string input = ReadLine()!;

        // Regex ageChecker = new (@"\d");
        // Regex ageChecker = new (@"^\d+$");
        //Regex ageChecker = new (digitsOnlyText);
        Regex ageChecker = DigitsOnly();

        if (ageChecker.IsMatch(input))
        {
            WriteLine("Thank you.");
        }
        else
        {
            WriteLine($"This is not a valid age: {input}");
        }

// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
// C# 11 or later: Use """ to start and end a raw string literal
        string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
        WriteLine($"Films to split: {films}");
        string[] filmsDumb = films.Split(',');
        WriteLine("Splitting with string.Split method:");
        foreach (string film in filmsDumb)
        {
            WriteLine(film);
        }

        //Regex csv = new(
        //    "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
        //Regex csv = new(commaSeparatorText);
        Regex csv = CommaSeparator();
        MatchCollection filmsSmart = csv.Matches(films);
        WriteLine("Splitting with regular expression:"); 
        foreach (Match film in filmsSmart)
        {
            WriteLine(film.Groups[2].Value);
        }
    }
}